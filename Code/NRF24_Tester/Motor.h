#define ena     5
#define enb     6

#define in1     2
#define in2     3
#define in3     4
#define in4     9

//At too low PWM speeds motors will stall. TO overcome, every speed
//below lowPowerCutoff except for 0 will be rounded up to lowPowerCutoff
//for all motor functions
#define lowPowerCutoff  60

void drive(int spdLeft, int spdRight, int dur)
{
  //Both forward
  if (spdLeft >= 0 && spdRight >= 0)
  {
    int spdLeftConvert;
    int spdRightConvert;
  
    if (spdLeft >= lowPowerCutoff)
      spdLeftConvert = int(255*(spdLeft/100.0));
    else if (spdLeft != 0)
      spdLeftConvert = int(255*(lowPowerCutoff/100.0));
    else
      spdLeftConvert = 0;

    if (spdRight >= lowPowerCutoff)
      spdRightConvert = int(255*(spdRight/100.0));
    else if (spdRight != 0)
      spdRightConvert = int(255*(lowPowerCutoff/100.0));
    else
      spdRightConvert = 0;
      
    
    analogWrite(ena, spdLeftConvert);
    digitalWrite(in1, LOW);
    digitalWrite(in2, HIGH);

    analogWrite(enb, spdRightConvert);
    digitalWrite(in3, HIGH);
    digitalWrite(in4, LOW);
    
    delay(dur);
  
    digitalWrite(ena, LOW);
    digitalWrite(in1, LOW);
    digitalWrite(in2, LOW);

    digitalWrite(enb, LOW);
    digitalWrite(in3, LOW);
    digitalWrite(in4, LOW);
  }
  //Right forward, left backward
  else if (spdLeft < 0 && spdRight >= 0)
  {
    int spdLeftConvert;
    int spdRightConvert;
  
    if (spdLeft >= lowPowerCutoff)
      spdLeftConvert = int(255*(spdLeft/100.0));
    else if (spdLeft != 0)
      spdLeftConvert = int(255*(lowPowerCutoff/100.0));
    else
      spdLeftConvert = 0;

    if (spdRight >= lowPowerCutoff)
      spdRightConvert = int(255*(spdRight/100.0));
    else if (spdRight != 0)
      spdRightConvert = int(255*(lowPowerCutoff/100.0));
    else
      spdRightConvert = 0;
      
    
    analogWrite(ena, spdLeftConvert);
    digitalWrite(in1, LOW);
    digitalWrite(in2, HIGH);

    analogWrite(enb, spdRightConvert);
    digitalWrite(in3, LOW);
    digitalWrite(in4, HIGH);
    
    delay(dur);
  
    digitalWrite(ena, LOW);
    digitalWrite(in1, LOW);
    digitalWrite(in2, LOW);

    digitalWrite(enb, LOW);
    digitalWrite(in3, LOW);
    digitalWrite(in4, LOW);
  }
  //Left forward, right backward
  else if (spdLeft >= 0 && spdRight < 0)
  {
    int spdLeftConvert;
    int spdRightConvert;
  
    if (spdLeft >= lowPowerCutoff)
      spdLeftConvert = int(255*(spdLeft/100.0));
    else if (spdLeft != 0)
      spdLeftConvert = int(255*(lowPowerCutoff/100.0));
    else
      spdLeftConvert = 0;

    if (spdRight >= lowPowerCutoff)
      spdRightConvert = int(255*(spdRight/100.0));
    else if (spdRight != 0)
      spdRightConvert = int(255*(lowPowerCutoff/100.0));
    else
      spdRightConvert = 0;
      
    
    analogWrite(ena, spdLeftConvert);
    digitalWrite(in1, HIGH);
    digitalWrite(in2, LOW);

    analogWrite(enb, spdRightConvert);
    digitalWrite(in3, HIGH);
    digitalWrite(in4, LOW);
    
    delay(dur);
  
    digitalWrite(ena, LOW);
    digitalWrite(in1, LOW);
    digitalWrite(in2, LOW);

    digitalWrite(enb, LOW);
    digitalWrite(in3, LOW);
    digitalWrite(in4, LOW);
  }
  //Both backward
  else if (spdLeft < 0 && spdRight < 0)
  {
    int spdLeftConvert;
    int spdRightConvert;
  
    if (spdLeft >= lowPowerCutoff)
      spdLeftConvert = int(255*(spdLeft/100.0));
    else if (spdLeft != 0)
      spdLeftConvert = int(255*(lowPowerCutoff/100.0));
    else
      spdLeftConvert = 0;

    if (spdRight >= lowPowerCutoff)
      spdRightConvert = int(255*(spdRight/100.0));
    else if (spdRight != 0)
      spdRightConvert = int(255*(lowPowerCutoff/100.0));
    else
      spdRightConvert = 0;
      
    
    analogWrite(ena, spdLeftConvert);
    digitalWrite(in1, HIGH);
    digitalWrite(in2, LOW);

    analogWrite(enb, spdRightConvert);
    digitalWrite(in3, LOW);
    digitalWrite(in4, HIGH);
    
    delay(dur);
  
    digitalWrite(ena, LOW);
    digitalWrite(in1, LOW);
    digitalWrite(in2, LOW);

    digitalWrite(enb, LOW);
    digitalWrite(in3, LOW);
    digitalWrite(in4, LOW);
  }
}

void motorRight(int spd, int dur)
{
  int spdConvert;
  
  if (spd >= lowPowerCutoff)
    spdConvert = int(255*(spd/100.0));
  else if (spd != 0)
    spdConvert = int(255*(lowPowerCutoff/100.0));
  else
    spdConvert = 0;
    
  
  analogWrite(ena, spdConvert);
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
  
  delay(dur);

  digitalWrite(ena, LOW);
  digitalWrite(in1, LOW);
  digitalWrite(in2, LOW);
}

void motorLeft(int spd, int dur)
{
  int spdConvert;
  
  if (spd >= lowPowerCutoff)
    spdConvert = int(255*(spd/100.0));
  else if (spd != 0)
    spdConvert = int(255*(lowPowerCutoff/100.0));
  else
    spdConvert = 0;

    Serial.println(spdConvert);
    
  
  analogWrite(enb, spdConvert);
  digitalWrite(in3, LOW);
  digitalWrite(in4, HIGH);
  
  delay(dur);

  digitalWrite(enb, LOW);
  digitalWrite(in3, LOW);
  digitalWrite(in4, LOW);
}
