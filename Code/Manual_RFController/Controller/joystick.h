#define joystickX     A6
#define joystickY     A7

void setup_joystick()
{
  pinMode(joystickX, INPUT);
  pinMode(joystickY, INPUT);
}

void get_joystick_location(int* x, int* y)
{
  *x = map((1024 - analogRead(joystickX)), 0, 1023, -99, 99);
  *y = map((1024 - analogRead(joystickY)), 0, 1023, -49, 49);

  if (*x>-5 && *x<5)
    *x = 1;//0 is recognized as failed radio transmission, so 1 represents 0

  Serial.print("X: ");
  Serial.print(*x);
  Serial.print(" Y: ");
  Serial.print(*y);
  Serial.println();
}

void print_joystick_location()
{
  Serial.print("X: ");
  Serial.print(map((1024 - analogRead(joystickX)), 0, 1023, -99, 99));
  Serial.print("\tY: ");
  Serial.print(map((1024 - analogRead(joystickY)), 0, 1023, -99, 99));
  Serial.println();
}

