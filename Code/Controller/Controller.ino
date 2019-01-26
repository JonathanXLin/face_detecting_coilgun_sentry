#include <SPI.h>
#include "nRF24L01.h"
#include "RF24.h"

RF24 radio(7, 8);
//CE, CSN

const byte address[6] = "00001";

void setup() {
  pinMode(A5, INPUT);
  pinMode(A6, INPUT);
  
  radio.begin();
  radio.openWritingPipe(address);
  radio.setPALevel(RF24_PA_MAX);
  radio.setDataRate(RF24_250KBPS);
  radio.setChannel(115);
  radio.stopListening();
  
  delay(200);

  Serial.begin(9600);
}

//ADC joystick value
int xRaw = 0;
int yRaw = 0;

//-100 to 100 joystick position
int xState = 0;
int yState = 0;

//All info sent via digits of package to radio
int package = 0;

void loop() {
  xRaw = analogRead(A5);
  yRaw = analogRead(A6);

  xState = map(xRaw, 0, 1024, -99, 99);//Conversion from angles to state ranges
  yState = 99 - map(yRaw, 0, 1024, 0, 99);

  if (xState>-15 && xState<15)//Range of values to trim to 0
    xState = 1;
  if (yState>40 && yState<60)
    yState = 50;

  if (xState>=0)//Converts states into package. Package is a 4 digit long integer, abcd, where ab is xState (-99 to 99), and cd is yState (0 to 99)
    package = xState * 100 + yState;
  else
    package = xState * 100 - yState;
      
  Serial.print(xRaw);
  Serial.print(" ");
  Serial.print(yRaw);
  Serial.print(" ");
  Serial.print(package);
  Serial.print(" ");
  Serial.println();

  radio.write(&package, sizeof(package));
  
  delay(10);
}
