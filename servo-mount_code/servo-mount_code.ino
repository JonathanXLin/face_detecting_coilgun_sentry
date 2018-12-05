#include <Servo.h>

const int servoHorizontal = 5;//Horizontal servo

Servo servoH;

void setup() {
  servoH.attach(servoHorizontal);

  Serial.begin(9600);
}

void loop() {
  for (int i=0; i<360; i++)
  {
    servoH.write(i*4);
    delay(100);
  }

  delay(1000);
}
