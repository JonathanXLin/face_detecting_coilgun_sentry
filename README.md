# Face Detecting Sentry

Face detecting motorized alt-azimuth coilgun sentry with PID controller, EmguCV facial recognition, and desktop app controller.

<br>

<p align="center"> 
  <img src="https://i.imgur.com/2wQFcx7.jpg" width="400">
</p>

<br>

<p align="center"> 
  <img src="https://i.imgur.com/gTeaxC8.png" width="800">
</p>

# Schematic

Interfacing between desktop app and servos is done through a serial connection to an Arduino, which generates the PWM signals to power the X and Y axis servos. The Arduino and servos are powered by a 2S 7.4V Li-Ion battery pack, with each servo's 5V source supplied by its own 5V regulator.

<p align="center"> 
  <img src="https://i.imgur.com/jd1juZd.png" width="800">
</p>

