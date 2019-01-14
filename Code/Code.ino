#include <Servo.h>

const int servoHorizontal = 5;//Horizontal servo

int xSensitivity = 40;

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

int xState = 0;
int yState = 0;

void loop() {

  read_joystick_data();
  print_joystick_data();

  servoH.writeMicroseconds(1500 + (xState/100.0*xSensitivity));  // Clockwise

  delay(10);
}

void read_joystick_data()
{
  xState = map((int)analogRead(A5), 0, 1023, -100, 100);
  yState = map((int)analogRead(A6), 0, 1023, -100, 100);

  if (abs(xState) < 5)
    xState = 0;
  if (abs(yState) < 5)
    yState = 0;
}

void print_joystick_data()
{
  Serial.print("X: ");
  Serial.print(xState);
  Serial.println();
  Serial.print("Y: ");
  Serial.print(yState);
  Serial.println();
}
