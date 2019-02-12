# Face Detection Example
#
# This example shows off the built-in face detection feature of the OpenMV Cam.
#
# Face detection works by using the Haar Cascade feature detector on an image. A
# Haar Cascade is a series of simple area contrasts checks. For the built-in
# frontalface detector there are 25 stages of checks with each stage having
# hundreds of checks a piece. Haar Cascades run fast because later stages are
# only evaluated if previous stages pass. Additionally, your OpenMV Cam uses
# a data structure called the integral image to quickly execute each area
# contrast check in constant time (the reason for feature detection being
# grayscale only is because of the space requirment for the integral image).

import sensor, time, image
import pyb
from pyb import Servo

# servo on position 1 (P7)
servoY = Servo(1)

# Reset sensor
sensor.reset()

# Sensor settings
sensor.set_contrast(1)
sensor.set_gainceiling(32)
# HQVGA and GRAYSCALE are the best for face tracking.
sensor.set_framesize(sensor.HQVGA)
sensor.set_pixformat(sensor.GRAYSCALE)

# Load Haar Cascade
# By default this will use all stages, lower stages is faster but less accurate.
face_cascade = image.HaarCascade("frontalface", stages=35)
print(face_cascade)

# FPS clock
clock = time.clock()

servoY.pulse_width(1500)

# If face not detected for given number of consecutive retries, stop movement
consecRetries = 0;
consecRetryLimit = 10;

while (True):
    clock.tick()

    # Capture snapshot
    img = sensor.snapshot()

    # Find objects.
    # Note: Lower scale factor scales-down the image more and detects smaller objects.
    # Higher threshold results in a higher detection rate, with more false positives.
    objects = img.find_features(face_cascade, threshold=0.75, scale_factor=1.25)

    # Draw objects
    for r in objects:
        img.draw_rectangle(r)

    # print face coordinates

    if objects:
        consecRetries = 0
        print(objects[0][0]/1.6, " ", (80 - objects[0][1])/0.8)
    else:
        if (consecRetries <= consecRetryLimit):
            print("N/A, consec. retries: ", consecRetries)
            consecRetries += 1
        else:
            print("N/A, consec. retry limit reached")

    # Print FPS.
    # Note: Actual FPS is higher, streaming the FB makes it slower.
    # print(clock.fps())
