#include <Servo.h>

Servo xServo;
Servo yServo;

const int xServoPin = 2;//Horizontal servo
const int yServoPin = 3;//Vertical servo

void setup() {
  xServo.attach(xServoPin);
  yServo.attach(yServoPin);

  Serial.begin(9600);
  Serial.setTimeout(100);
}

String rawString = "";
int xPos = 0;
int yPos = 0;

void loop() {
  rawString = Serial.readStringUntil('E');
  rawString.remove(rawString.indexOf("E"));

  parse_raw_string(rawString, &xPos, &yPos);
  
  Serial.print(xPos);
  Serial.print(" ");
  Serial.print(yPos);
  Serial.println();
  
  xServo.write(xPos);
  yServo.write(yPos);
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
