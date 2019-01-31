//=============================NRF RADIO================================
#include <SPI.h>
#include "nRF24L01.h"
#include "RF24.h"

RF24 radio(7, 8);
//CE, CSN

const byte address[6] = "00001";
//=============================SERVO================================
#include <Servo.h>

const int xServoPin = 5;//Horizontal servo
const int yServoPin = 6;//Vertical servo

int xSensitivity = 40;
int ySensitivity = 40;

Servo xServo;
Servo yServo;

void setup() {
  radio_setup();
  servo_setup();

  Serial.begin(9600);
  Serial.println("Turret Initialized");
}

void radio_setup()
{
  radio.begin();
  radio.openReadingPipe(0, address);
  radio.setPALevel(RF24_PA_MAX);
  radio.setDataRate(RF24_250KBPS);
  radio.setChannel(115);
  radio.startListening();
  
  delay(100);
}

void servo_setup()
{
  radio_setup();
  
  xServo.attach(xServoPin);
  yServo.attach(yServoPin);

  xServo.write(90);
  yServo.write(90);
}

int package = 0;//Raw RF data
int xState = 0;
int yState = 0;

double xPos = 0.0;
double yPos = 90.0;

void loop() {
  loop_function();
  delay(10);
}

void loop_function()
{
  radio_read();

  if (package != -1)
  {
    send_RF_data();
    print_RF_data();
  }
}

void radio_read()
{
  if (radio.available())
  {
    package = -1;
    radio.read(&package, sizeof(int));
    
    yState = package/100;
    if (yState > 0)
      xState = ((package - yState*100) - 50)*2;
    else
      xState = ((package - yState*100)*(-1) - 50)*2;
  }
}

void send_RF_data()
{
  xServo.writeMicroseconds(1500 + (xState/100.0*xSensitivity));
  yServo.writeMicroseconds(1500 + (yState/100.0*ySensitivity));
}

void print_RF_data()
{
  Serial.print("Pack: ");
  Serial.print(package);
  Serial.print(" X: ");
  Serial.print(xState);
  Serial.print(" Y: ");
  Serial.print(yState);
  Serial.println();
}
