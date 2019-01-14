#include <Servo.h>

const int xServoPin = 5;//Horizontal servo
const int yServoPin = 6;//Vertical servo

int xSensitivity = 40;

Servo xServo;
Servo yServo;

void setup() {
  xServo.attach(xServoPin);
  yServo.attach(yServoPin);

  yServo.write(90);

  Serial.begin(9600);
}

void cw(int deg)
{
  xServo.writeMicroseconds(1500 - abs(15/100.0*200.0));  // Clockwise
  delay(double(deg)/360*4.0*1000);//One full rotation takes exactly 4s
  xServo.writeMicroseconds(1500);  // Stop
}

void ccw(int deg)
{
  xServo.writeMicroseconds(1500 + abs(15/100.0*200.0));  // Clockwise
  delay(double(deg)/360*4.0*1000);//One full rotation takes exactly 4s
  xServo.writeMicroseconds(1500);  // Stop
}

int xState = 0;
int yState = 0;

double xPos = 0.0;
double yPos = 90.0;

void loop() {

  loop_function();
  
}

void loop_function()
{
  read_joystick_data();
  print_joystick_data();

  xServo.writeMicroseconds(1500 + (xState/100.0*xSensitivity));
  yServo.write(yPos);

  Serial.println(yPos);

  delay(100);
}

void read_joystick_data()
{
  xState = map((int)analogRead(A5), 0, 1023, -100, 100);
  yState = map((int)analogRead(A6), 0, 1023, -100, 100);

  if (abs(xState) < 5)
    xState = 0;
  if (abs(yState) < 5)
    yState = 0;

  yPos += yState*0.5;
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
