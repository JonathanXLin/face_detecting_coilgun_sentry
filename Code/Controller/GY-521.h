#include "Wire.h"

const int MPU_ADDR = 0x68; //ADO pin low
//SCL A5, SDA A4

int accX, accY, accZ;
int gyrX, gyrY, gyrZ;
int temp;

int angX, angY, angZ;

void setup_gyro()
{
  Serial.begin(9600);
  Wire.begin();
  Wire.beginTransmission(MPU_ADDR); //Begin transmission to I2C slave
  Wire.write(0x6B); //PWR_MGMT_1 register
  Wire.write(0); //set to zero (wakes up MPU-6050)
  Wire.endTransmission(true);
}

void print_data()
{
  Serial.print("accX : ");
  Serial.print(accX);
  Serial.print(" ");

  Serial.print("accY : ");
  Serial.print(accY);
  Serial.print(" ");

  Serial.print("accZ : ");
  Serial.print(accZ);
  Serial.print(" ");

  Serial.print("gyrX : ");
  Serial.print(gyrX);
  Serial.print(" ");

  Serial.print("gyrY : ");
  Serial.print(gyrY);
  Serial.print(" ");

  Serial.print("gyrZ : ");
  Serial.print(gyrZ);
  Serial.print(" ");

  Serial.print("Temperature : ");
  Serial.print(temp);
  Serial.print(" ");

  Serial.println();
}

void print_angles()
{
  Serial.print("angX : ");
  Serial.print(acos(constrain(accX/16384.0f, -1, 1))*180.0f/PI);
  Serial.print(" ");

  Serial.print("angY : ");
  Serial.print(acos(constrain(accY/16384.0f, -1, 1))*180.0f/PI);
  Serial.print(" ");

  Serial.print("angZ : ");
  Serial.print(acos(constrain(accZ/16384.0f, -1, 1))*180.0f/PI);
  Serial.print(" ");

  Serial.println();
}

void refresh_gyro() {
  Wire.beginTransmission(MPU_ADDR);
  Wire.write(0x3B);
  Wire.endTransmission(false);
  Wire.requestFrom(MPU_ADDR, 7*2, true);

  accX = Wire.read()<<8 | Wire.read(); 
  accY = Wire.read()<<8 | Wire.read();
  accZ = Wire.read()<<8 | Wire.read();
  gyrX = Wire.read()<<8 | Wire.read();
  gyrY = Wire.read()<<8 | Wire.read();
  gyrZ = Wire.read()<<8 | Wire.read();
  temp = Wire.read()<<8 | Wire.read();

  angX = acos(constrain(accX/16384.0f, -1, 1))*180.0f/PI;
  angY = acos(constrain(accY/16384.0f, -1, 1))*180.0f/PI;
  angZ = acos(constrain(accZ/16384.0f, -1, 1))*180.0f/PI;
}
