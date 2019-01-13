#include <Servo.h>

const int servoHorizontal = 5;//Horizontal servo

Servo servoH;

void setup() {
  servoH.attach(servoHorizontal);

  Serial.begin(9600);
}

void cw(int deg)
{
  servoH.writeMicroseconds(1500 - abs(15/100.0*200.0));  // Clockwise
  delay(double(deg)/360*4.0*1000);//One full rotation takes exactly 4s
  servoH.writeMicroseconds(1500);  // Stop
}

void ccw(int deg)
{
  servoH.writeMicroseconds(1500 + abs(15/100.0*200.0));  // Clockwise
  delay(double(deg)/360*4.0*1000);//One full rotation takes exactly 4s
  servoH.writeMicroseconds(1500);  // Stop
}

void loop() {

  cw(180);
  ccw(180);
  
}
