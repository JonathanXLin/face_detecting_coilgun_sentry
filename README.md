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

## Schematic

Interfacing between desktop app and servos is done through a serial connection to an Arduino, which generates the PWM signals to power the X and Y axis servos. The Arduino and servos are powered by a 2S 7.4V Li-Ion battery pack, with each servo's 5V source supplied by its own 5V regulator.

<p align="center"> 
  <img src="https://i.imgur.com/jd1juZd.png" width="600">
</p>

## Design and 3D Printing

All components were designed on SolidWorks and 3D printed using PLA.

<p align="center"> 
  <img src="https://i.imgur.com/QGyq9Oa.png" width="600">
</p>

## Desktop App

The desktop app was created using Visual Studio. Once loaded, the user selects the correct camera feed and COM port. The user can switch between manual and automatic (face tracking) modes. Manual mode uses the arrow keys to control camera movement, while automatic mode follows the closest detected face. Speed, servo calibration, and PID tuning can be changed at any time. 

<p align="center"> 
  <img src="https://i.imgur.com/gTeaxC8.png" width="800">
</p>
