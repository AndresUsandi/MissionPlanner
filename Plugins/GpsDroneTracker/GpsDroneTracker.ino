/************************************************/
#include <Wire.h>
#include <Servo.h>
#include <math.h>
/************************************************/

const int MPU_addr=0x68;  // I2C address of the MPU-6050
const int headMoveThreashold = 5;

float accAngleX, accAngleY, gyroAngleX, gyroAngleY, gyroAngleZ;
float roll;
float pitch;
float yaw = 90;
float AcErrorX, AcErrorY, GyErrorX, GyErrorY, GyErrorZ;
float elapsedTime, currentTime, previousTime;
float GyX,GyY,GyZ,AcX,AcY,AcZ,Tmp;
float pitchPrev;
float yawPrev = 90;

bool isImuPresent = true;

const int joystickXPin = A0;     //X attach to A0
const int joystickYPin = A1;     //Y attach to A1
const int joystickBtPin = 7;     //Bt attach to digital 7

int horizontalServoValue = 90;
int verticalServoValue = 180;

Servo horizontalServo;
Servo verticalServo;

/************************************************/
void setup()
{
  Serial.begin(115200);
  
  horizontalServoValue = 90;
  verticalServoValue = 180;

  Serial.println("Initializing Servos");
  horizontalServo.attach(3);
  horizontalServo.write(horizontalServoValue);
  verticalServo.attach(4);
  verticalServo.write(verticalServoValue);

  Serial.println("Initializing Joystick");
  pinMode(joystickBtPin, INPUT); //set btpin as INPUT
  digitalWrite(joystickBtPin, HIGH); //and HIGH

  pinMode(13,OUTPUT);
  digitalWrite(13,LOW);

  if(isImuPresent)
  {
    Serial.println("IMU Found");
    
    Wire.begin();
    Wire.beginTransmission(MPU_addr);
    Wire.write(0x6B);  // PWR_MGMT_1 register
    Wire.write(0);     // set to zero (wakes up the MPU-6050)
    Wire.endTransmission(true);
  }
  
  Serial.println("Instructions: [servo number][degrees (1: horizontal = -90 to 90, 2: vertical = 0 to 90)]");
}
/*************************************************/
void loop()
{  
  moveWithJoystick();
  moveWithHeadtracker();
  moveWithSerialValue();
}

void moveWithSerialValue()
{
  if(Serial.available()) {
    String data = Serial.readString();
    int servo = data.substring(0, 1).toInt();
    int deg = data.substring(1).toInt();
    
    Serial.print("got data - servo: ");
    Serial.print(servo);
    Serial.print(" - degress: ");
    Serial.println(deg);
    
    if(servo == 1) {
      if(deg > 90)
        deg = 90;
      if (deg < -90)
        deg = -90;
      deg = deg * -1;
      deg = (deg + 90);
      horizontalServoValue = deg;
      moveHorizontalServo(horizontalServoValue);
    }
    else if(servo == 2) {
      if(deg > 90)
        deg = 90;
      if(deg < 0)
        deg = 0;
      deg = 180 - deg;
      verticalServoValue = deg;
      moveVerticalServo(verticalServoValue);
    }
  }
}

void moveWithJoystick()
{
  int joystickXValue = analogRead(joystickXPin);
  int joystickYValue = analogRead(joystickYPin);
  int joystickBtValue = digitalRead(joystickBtPin);

  // X = -5 to 5 (left to right), Y = 5 to -5 (up to down)
  joystickXValue = round((float)joystickXValue / 100) - 5;
  joystickYValue = (round((float)joystickYValue / 100) - 5) * -1;

  if(joystickXValue != 0) {
    horizontalServoValue = horizontalServoValue + joystickXValue;
    moveHorizontalServo(horizontalServoValue);
    delay(50);
  }

  if(joystickYValue != 0) {
    verticalServoValue = verticalServoValue + joystickYValue;
    moveVerticalServo(verticalServoValue);
    delay(50);
  }
}

void moveWithHeadtracker() 
{
  if(isImuPresent)
  {
    // === Read acceleromter data === //
    Wire.beginTransmission(MPU_addr);
    Wire.write(0x3B); // Start with register 0x3B (ACCEL_XOUT_H)
    Wire.endTransmission(false);
    Wire.requestFrom(MPU_addr, 6, true); // Read 6 registers total, each axis value is stored in 2 registers
    //For a range of +-2g, we need to divide the raw values by 16384, according to the datasheet
    AcX = (Wire.read() << 8 | Wire.read()) / 16384.0; // X-axis value
    AcY = (Wire.read() << 8 | Wire.read()) / 16384.0; // Y-axis value
    AcZ = (Wire.read() << 8 | Wire.read()) / 16384.0; // Z-axis value
    // Calculating Roll and Pitch from the accelerometer data
    accAngleX = (atan(AcY / sqrt(pow(AcX, 2) + pow(AcZ, 2))) * 180 / PI) - 0.58; // AcErrorX ~(0.58) See the calculate_IMU_error()custom function for more details
    accAngleY = (atan(-1 * AcX / sqrt(pow(AcY, 2) + pow(AcZ, 2))) * 180 / PI) + 1.58; // AcErrorY ~(-1.58)
    // === Read gyroscope data === //
    previousTime = currentTime;        // Previous time is stored before the actual time read
    currentTime = millis();            // Current time actual time read
    elapsedTime = (currentTime - previousTime) / 1000; // Divide by 1000 to get seconds
    Wire.beginTransmission(MPU_addr);
    Wire.write(0x43); // Gy data first register address 0x43
    Wire.endTransmission(false);
    Wire.requestFrom(MPU_addr, 6, true); // Read 4 registers total, each axis value is stored in 2 registers
    GyX = (Wire.read() << 8 | Wire.read()) / 131.0; // For a 250deg/s range we have to divide first the raw value by 131.0, according to the datasheet
    GyY = (Wire.read() << 8 | Wire.read()) / 131.0;
    GyZ = (Wire.read() << 8 | Wire.read()) / 131.0;
    // Correct the outputs with the calculated error values
    GyX = GyX + 0.56; // GyErrorX ~(-0.56)
    GyY = GyY - 2; // GyErrorY ~(2)
    GyZ = GyZ + 0.79; // GyErrorZ ~ (-0.8)
    // Currently the raw values are in degrees per seconds, deg/s, so we need to multiply by sendonds (s) to get the angle in degrees
    gyroAngleX = gyroAngleX + GyX * elapsedTime; // deg/s * s = deg
    gyroAngleY = gyroAngleY + GyY * elapsedTime;
    yaw =  yaw + GyZ * elapsedTime;
    // Complementary filter - combine acceleromter and gyro angle values
    roll = 0.96 * gyroAngleX + 0.04 * accAngleX;
    pitch = 180 - ((0.96 * gyroAngleY + 0.04 * accAngleY));
    
    // Print the values on the serial monitor
  //  Serial.print(roll);
  //  Serial.print("/");
  //  Serial.print(pitch);
  //  Serial.print("/");
  //  Serial.println(yaw);
  
    int verticalDiff = pitchPrev - pitch;
    if(verticalDiff >= headMoveThreashold || verticalDiff <= -headMoveThreashold)
    {
      verticalServoValue = pitch;
      moveVerticalServo(verticalServoValue);
      pitchPrev = pitch;
    }
  
    float horizontalDiff = yawPrev - yaw;
    if(horizontalDiff >= headMoveThreashold || horizontalDiff <= -headMoveThreashold)
    {
      horizontalServoValue = yaw;
      moveHorizontalServo(horizontalServoValue);
      yawPrev = yaw;
    }
  }
}

void moveHorizontalServo(int deg)
{
  if(horizontalServoValue < 0)
    horizontalServoValue = 0;
  if(horizontalServoValue > 180)
    horizontalServoValue = 180;
  horizontalServo.write(horizontalServoValue);
}

void moveVerticalServo(int deg)
{
  if(verticalServoValue < 90)
    verticalServoValue = 90;
  if(verticalServoValue > 180)
    verticalServoValue = 180;
  verticalServo.write(verticalServoValue);
}

/**************************************************/
