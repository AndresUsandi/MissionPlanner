/************************************************/
#include <Servo.h>
#include <math.h>
/************************************************/

const int joystickXPin = A0;     //X attach to A0
const int joystickYPin = A1;     //Y attach to A1
const int joystickBtPin = 7;     //Bt attach to digital 7

int servo1Value;
int servo2Value;

Servo servo1;
Servo servo2;

/************************************************/
void setup()
{
  servo1Value = 90;
  servo2Value = 180;
  
  servo1.attach(3);
  servo1.write(servo1Value);
  servo2.attach(4);
  servo2.write(servo2Value);

  pinMode(joystickBtPin, INPUT); //set btpin as INPUT
  digitalWrite(joystickBtPin, HIGH); //and HIGH
  
  Serial.begin(115200);
  Serial.println("Instructions: [servo number][degrees (1 = -90 to 90, 2 = 0 to 90)]");
}
/*************************************************/
void loop()
{  
  int joystickXValue = analogRead(joystickXPin);
  int joystickYValue = analogRead(joystickYPin);
  int joystickBtValue = digitalRead(joystickBtPin);

  // X = -5 to 5 (left to right), Y = 5 to -5 (up to down)
  joystickXValue = round((float)joystickXValue / 100) - 5;
  joystickYValue = (round((float)joystickYValue / 100) - 5) * -1;

  if(joystickXValue != 0) {
    servo1Value = servo1Value + joystickXValue;
    if(servo1Value < 0)
      servo1Value = 0;
    if(servo1Value > 180)
      servo1Value = 180;
    servo1.write(servo1Value);
    delay(50);
  }

  if(joystickYValue != 0) {
    servo2Value = servo2Value + joystickYValue;
    if(servo2Value < 90)
      servo2Value = 90;
    if(servo2Value > 180)
      servo2Value = 180;
    servo2.write(servo2Value);
    delay(50);
  }
  
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
      servo1Value = deg;
      servo1.write(servo1Value);
    }
    else if(servo == 2) {
      if(deg > 90)
        deg = 90;
      if(deg < 0)
        deg = 0;
      deg = 180 - deg;
      servo2Value = deg;
      servo2.write(servo2Value);
    }
  }
}
/**************************************************/
