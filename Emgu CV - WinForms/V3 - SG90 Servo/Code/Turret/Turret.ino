#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

#define SCREEN_WIDTH 128 // OLED display width, in pixels
#define SCREEN_HEIGHT 64 // OLED display height, in pixels

// Declaration for an SSD1306 display connected to I2C (SDA, SCL pins)
#define OLED_RESET     4 // Reset pin # (or -1 if sharing Arduino reset pin)
Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);

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
