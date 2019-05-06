//=============================SERVO================================
#include <Servo.h>

const int xServoPin = 5;//Horizontal servo
const int yServoPin = 6;//Vertical servo

int xSensitivity = 40;
int ySensitivity = 40;

Servo xServo;
Servo yServo;

void setup() {
  servo_setup();

  Serial.begin(9600);
  Serial.setTimeout(100);
}

void servo_setup()
{
  xServo.attach(xServoPin);
  yServo.attach(yServoPin);
}

void loop() 
{
  loop_function();
}

void SerialEvent()
{
  loop_function();
}

String rawString = "";
int xSpeed = 0;
int ySpeed = 0;

void loop_function()
{
  rawString = Serial.readStringUntil('E');
  rawString.remove(rawString.indexOf("E"));

  parse_raw_string(rawString, &xSpeed, &ySpeed);
  
  Serial.print(xSpeed);
  Serial.print(" ");
  Serial.print(ySpeed);
  Serial.println();
  
  xServo.writeMicroseconds(1500 + (xSpeed/100.0*xSensitivity));
  yServo.writeMicroseconds(1500 + (ySpeed/100.0*ySensitivity));
}

void parse_raw_string(String rawString, int *x, int *y)
{
  String rawStringX = rawString;
  String rawStringY = rawString;
  
  rawStringX.remove(rawStringX.indexOf("Y"));
  rawStringX.remove(rawStringX.indexOf("X"), 1);
  *x = rawStringX.toInt();

  rawStringY.remove(0, rawStringY.indexOf("Y") + 1);
  *y = rawStringY.toInt();
}
