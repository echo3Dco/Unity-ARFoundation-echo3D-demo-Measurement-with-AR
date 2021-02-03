# Unity-ARFoundation-echoAR-demo-Measurement-with-AR
Simple measurement application using AR Foundation, Unity, and EchoAR. Tested on Android devices.

You can measure custom AR objects:

![ar_measure](/Screenshots/AR_object_measure.jpg)

Or real-life objects:

![measure](/Screenshots/real_object_measure.jpg)


## Register
If you don't have an echoAR API key yet, make sure to register for FREE at [echoAR](https://console.echoar.xyz/#/auth/register).

## Setup
* Clone this repository for prefabs,scenes and custom scripts.
* Open the project in Unity and follow the instructions on our [doumention page](https://docs.echoar.xyz/unity/adding-ar-capabilities) to [set your API key](https://docs.echoar.xyz/unity/adding-ar-capabilities#3-set-you-api-key).
* Set your echoAR API key in the echoAR prefab
* Add models to your echoAR project

## Run
* [Build and run the AR application](https://docs.echoar.xyz/unity/adding-ar-capabilities#4-build-and-run-the-ar-application).

## Usage Instructions:
The app has two modes:
* Object Placement mode, which allows you to place an EchoAR object on any plane
* Measurement Tape mode, which allows you to drag your finger between any two points on a plane to create a measurement.

- You can easily switch between modes by clicking on their respective buttons in the UI. 
- Note that because both modes depend on plane detection, it may take a few seconds to move your camera around before the plane you are trying to measure may register.
- Remember: if the placed Object is too large, you can modify the scale of the object in the EchoAR console (see https://docs.echoar.xyz/unity/transforming-content)
