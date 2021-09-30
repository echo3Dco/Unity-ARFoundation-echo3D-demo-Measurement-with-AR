# Unity-ARFoundation-echo3D-demo-Measurement-with-AR
Simple measurement application using AR Foundation, Unity, and echo3D. Tested on Android devices.

You can measure custom AR objects:

![ar_measure](/Screenshots/AR_object_measure.jpg)

Or real-life objects:

![measure](/Screenshots/real_object_measure.jpg)

## Register
If you don't have an echo3D API key yet, make sure to register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).

## Setup
* Clone this repository for prefabs,scenes and custom scripts.
* Open the project in Unity and follow the instructions on our [documentation page](https://docs.echo3D.co/unity/adding-ar-capabilities) to [set your API key](https://docs.echo3D.co/unity/adding-ar-capabilities#3-set-you-api-key).
* Set your echo3D API key in the echo3D prefab
* Add models to your echo3D project

## Run
* [Build and run the AR application](https://docs.echo3D.co/unity/adding-ar-capabilities#4-build-and-run-the-ar-application).

## Usage Instructions:
The app has two modes:
* Object Placement mode, which allows you to place an echo3D object on any plane
* Measurement Tape mode, which allows you to drag your finger between any two points on a plane to create a measurement.

- You can easily switch between modes by clicking on their respective buttons in the UI. 
- Note that because both modes depend on plane detection, it may take a few seconds to move your camera around before the plane you are trying to measure may register.
- Remember: if the placed Object is too large, you can modify the scale of the object in the echo3D console (see https://docs.echo3D.co/unity/transforming-content)

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join).


