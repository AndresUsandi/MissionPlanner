/************************************************/
#include <Wire.h>
#include <Servo.h>
#include <math.h>
/************************************************/


const int MPU_addr=0x68;  // I2C address of the MPU-6050
int16_t GyX,GyY,GyZ,AcX,AcY,AcZ,Tmp;

int xOffset = 0;
int yOffset = 0;
int zOffset = 0;

int i = 0;

long X = 0;
long Y = 0;
long Z = 0;

unsigned long previousMillis = 0;
unsigned long currentMillis = millis();
const long interval = 10;

unsigned long TIMERpreviousMillis = 0;
unsigned long TIMERcurrentMillis = millis();
const long TIMERinterval = 1;

int headMoveThreashold = 5;
int horizontalHeadPosition = 90;
int horizontalHeadPositionPrev = 90;
int verticalHeadPosition = 110;
int verticalHeadPositionPrev = 110;
int sideTiltPosition = 90;
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
  
    GetCalibrationData();
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

void GetCalibrationData()
{
  int i = 0;
  long xCal = 0;
  long yCal = 0;
  long zCal = 0;

  Serial.println("Calculating Gyro Offset Values...");

  while(i < 1000)
  {
    Wire.beginTransmission(MPU_addr);
    Wire.write(0x3B);  // starting with register 0x3B (ACCEL_XOUT_H)
    Wire.endTransmission(false);
    Wire.requestFrom(MPU_addr,14,true);  // request a total of 14 registers
    AcX=Wire.read()<<8|Wire.read();  // 0x3B (ACCEL_XOUT_H) & 0x3C (ACCEL_XOUT_L)     
    AcY=Wire.read()<<8|Wire.read();  // 0x3D (ACCEL_YOUT_H) & 0x3E (ACCEL_YOUT_L)
    AcZ=Wire.read()<<8|Wire.read();  // 0x3F (ACCEL_ZOUT_H) & 0x40 (ACCEL_ZOUT_L)
    Tmp=Wire.read()<<8|Wire.read();  // 0x41 (TEMP_OUT_H) & 0x42 (TEMP_OUT_L)
    GyX=Wire.read()<<8|Wire.read();  // 0x43 (GYRO_XOUT_H) & 0x44 (GYRO_XOUT_L)
    GyY=Wire.read()<<8|Wire.read();  // 0x45 (GYRO_YOUT_H) & 0x46 (GYRO_YOUT_L)
    GyZ=Wire.read()<<8|Wire.read();  // 0x47 (GYRO_ZOUT_H) & 0x48 (GYRO_ZOUT_L)

    xCal = xCal + GyX;
    yCal = yCal + GyY;
    zCal = zCal + GyZ;

    i = i + 1;
  }

  xOffset = xCal/1000;
  yOffset = yCal/1000;
  zOffset = zCal/1000;

  Serial.print("X Offset: ");
  Serial.println(xOffset);

  Serial.print("Y Offset: ");
  Serial.println(yOffset);

  Serial.print("Z Offset: ");
  Serial.println(zOffset);

  Serial.println("--------------------");
  Serial.println();

  delay(2500);

  Serial.println("Ready");

  digitalWrite(13,HIGH);
  
  return;
}

void moveWithHeadtracker()
{
  if(isImuPresent)
  {
    TIMERcurrentMillis = millis();
    if (TIMERcurrentMillis - TIMERpreviousMillis >= TIMERinterval)
    {
      //reset timer
      TIMERpreviousMillis = TIMERcurrentMillis;
    }
    
    Wire.beginTransmission(MPU_addr);
    Wire.write(0x43);  // starting with register 0x43 (GYRO_XOUT_H)
    Wire.endTransmission(false);
    Wire.requestFrom(MPU_addr,14,true);  // request a total of 6 registers
    
    GyX=Wire.read()<<8|Wire.read();  // 0x43 (GYRO_XOUT_H) & 0x44 (GYRO_XOUT_L)
    GyY=Wire.read()<<8|Wire.read();  // 0x45 (GYRO_YOUT_H) & 0x46 (GYRO_YOUT_L)
    GyZ=Wire.read()<<8|Wire.read();  // 0x47 (GYRO_ZOUT_H) & 0x48 (GYRO_ZOUT_L)
  
    GyX=(GyX-xOffset)/131;
    GyY=(GyY-yOffset)/131;
    GyZ=(GyZ-zOffset)/131;
  
    X = X + GyX;
    Y = Y + GyY;
    Z = Z + GyZ;
  
    i = i + 1;
    
    currentMillis = millis();
    if (currentMillis - previousMillis >= interval)
    {    
      //take average
      X = X/i;
      Y = Y/i;
      Z = Z/i;
  
      //multiply by 0.01 (ten milliseconds)
      X = X*0.02;
      Y = Y*0.02;
      Z = Z*0.02;
  
      //reset i
      i = 0;
  
      //reset timer
      previousMillis = currentMillis;
  
      verticalHeadPosition = verticalHeadPosition + Y;
      int verticalDiff = verticalHeadPositionPrev - verticalHeadPosition;
      if(verticalDiff >= headMoveThreashold || verticalDiff <= -headMoveThreashold)
      {
        verticalServoValue = verticalServoValue + verticalDiff;
        moveVerticalServo(verticalServoValue);
        verticalHeadPositionPrev = verticalHeadPosition;
      }
      
      horizontalHeadPosition = horizontalHeadPosition + (-Z);
      int horizontalDiff = horizontalHeadPositionPrev - horizontalHeadPosition;
      if(horizontalDiff >= headMoveThreashold || horizontalDiff <= -headMoveThreashold)
      {
        horizontalServoValue = horizontalServoValue + horizontalDiff;
        moveHorizontalServo(horizontalServoValue);
        horizontalHeadPositionPrev = horizontalHeadPosition;
      }
      
      //reset averages
      X = 0;
      Y = 0;
      Z = 0;
    }
  }
}

/**************************************************/
