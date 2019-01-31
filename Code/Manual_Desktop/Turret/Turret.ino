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
  Serial.println("Turret Initialized");
}

void servo_setup()
{
  xServo.attach(xServoPin);
  yServo.attach(yServoPin);
}

void loop() {
  loop_function();
  delay(10);
}

void loop_function()
{
  
}
