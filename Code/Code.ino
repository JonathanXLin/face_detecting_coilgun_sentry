#include <Servo.h>

const int servoHorizontal = 5;//Horizontal servo

Servo servoH;

void setup() {
  servoH.attach(servoHorizontal);

  Serial.begin(9600);
}

void cw(int deg, int spd)
{
  servoH.writeMicroseconds(1500 - abs(spd/100.0*200.0));  // Clockwise
  delay(500);
  servoH.writeMicroseconds(1500);  // Stop
}

void ccw(int deg, int spd)
{
  servoH.writeMicroseconds(1500 + abs(spd/100.0*200.0));  // Clockwise
  delay(500);
  servoH.writeMicroseconds(1500);  // Stop
}

void loop() {
  
  cw(10, 50);
  delay(0);
  ccw(10, 50);
  delay(0);
}
