#include <SPI.h>
#include "nRF24L01.h"
#include "RF24.h"

RF24 radio(7, 8);
//CE, CSN

const byte address[6] = "00001";

void setup() {
  
  radio.begin();
  radio.openReadingPipe(0, address);
  radio.setPALevel(RF24_PA_MAX);
  radio.setDataRate(RF24_250KBPS);
  radio.setChannel(115);
  radio.startListening();
  
  delay(100);

  Serial.begin(9600);
  Serial.println("Car Initialized");
}

void loop() {

  print_data();

  delay(10);
}

void print_data()
{
  if (radio.available())
  {
    int package = -1;
    radio.read(&package, sizeof(int));
    
    int xState = package/100;
    int yState = package - xState*100;

    Serial.print("Package: ");
    Serial.print(package);
    Serial.print("\t");
    Serial.print("X: ");
    Serial.print(xState);
    Serial.print(" ");
    Serial.print("Y: ");
    Serial.print(yState);
    Serial.println();
  }
}

void read_data(int* xState, int* yState)
{
    int package = -1;
    radio.read(&package, sizeof(int));
    
    int x = package/100;
    int y = 0;
    
    if (x > 0)
      y = package - x*100 - 50;
    else
      y = package - x*100 + 50;

      Serial.print("Package: ");
      Serial.print(package);
      Serial.print("\t");
      Serial.print("X: ");
      Serial.print(*xState);
      Serial.print(" ");
      Serial.print("Y: ");
      Serial.print(*yState);
      Serial.println();
}
