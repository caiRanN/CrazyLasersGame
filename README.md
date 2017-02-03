# Uncovering Playful Interaction

## About the project
Crazy Lasers is a game created in 8 days during a seminar at the HKU expertise centre. It combines world interaction with motion capture and VR. The game requires two players, one player has to equip a motion capture suit, the other puts on the GearVR. The player with the GearVR has to guide the player with the motion capture suit through an invisible laser maze, the player with the motion capture suit has to follow the instructions and talk with the VR player to navigate to real world buttons to open doors. They can win the game by reaching the end of the maze.

## How To Use
Since this implementation relies heavily on the the tools provided by the HKU-ECT, make sure you've set that up first, which means you'll need the following:

* A computer running Motive
* A computer running the NatNet2OSCBridge (currently untested on Windows)
* A computer running the GearVRHandshaker

Once you have these things setup, you can download or clone this repository and open it using Unity 5.5+

### Connect with Isadora
You will first need to set up your isadora project, you can find the documentation about how to setup the isadora project [here](Isadora.md). You will need a OSC Sender in your project to send data to Unity.

__Isadora to Unity__
You can deactivate GameObjects in Unity when interacting with something in Isadora by listening for a OSC message. Create a empty GameObject and add the OSCReceiver script, you will need to setup you connection via the inspector. You can look at the GateController script for an example on how to enable/disable objects.

__Unity to Isadora__
You can add the OSCClient to your script, from here you can send data to Isadora. Look at the example provided in the [GameManager](Project/Assets/Scripts/Manager/GameManager.cs).

### Connect to the GearVR
You will need to go through the GearVRHandshaker scene first, here you can set your follow-up scene, this will be autoloaded once the handshake has been made. In your scene you are gonna need to add GearVRTracker to track the location of the player wearing the GearVR, and the GearVR GameObject.

### Dependencies
Make sure you have the following software dependencies installed!
* A computer running Motive
* Unity OSC Toolkit (https://github.com/hku-ect/UnityOSCToolkit)
* GearVR OSC Handshakker (https://github.com/hku-ect/GearVR-OSC-Handshaker)
* NatNet2 OSC Bridge (https://github.com/hku-ect/NatNet2OSCbridge)
* BareConductive Isadora (https://github.com/hku-ect/BareConductive)

## Credits
* Niels van Unen (Game Design)
* Cairan Steverink (Gameplay Programming)
* Nadia Groenewald (Interaction Design)
* Kay Volbeda (Game Art)
* Jelle Hoogenberg (Game Design)

Special thanks to the HKU-ECT (https://github.com/hku-ect) for providing us with the tools and support.
