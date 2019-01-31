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

void loop() {
  loop_function();
}

void loop_function()
{
  String rawXString = Serial.readStringUntil('e');
  rawXString.remove(rawXString.indexOf("e"));
  int rawX = rawXString.toInt();
  
  //xServo.writeMicroseconds(1500 + (xState/100.0*xSensitivity));
  yServo.writeMicroseconds(1500 + (rawX/100.0*ySensitivity));
}
