# Isadora Setup
_Isadora documentation provided by Niels van Unen._

Isadora is a visual scripting program which enables user to script by drawing lines between instances, The experience we build exists out of of a bareconductive with sensors, projector, sound and lights, Isadora is connected with the barconductive and measures the values from the sensors and translates it to isadora. 

__IMPORTANT!__ The bareconductive is connected with tinfoil underneath the ground. 

In the image below you can see the how I setup a pressure plate within isadora. First the values from the barconductive are measured. Then the values are learned by comparing someone who stands on the trigger against when nobody stands on it. The next step is to check with a comparator if the value is high enough. Then is toggles the pictures which changes the projection. 

The other part of the setup starts also with a comparator which triggers the sound and finally connects with the lights. The last part is the connections with unity. By using a OSCsender it sends the values from isadora to unity.

![](https://i.gyazo.com/5ab83a62971bfb40560d789c02a96f83.jpg)

The image below is the regular setup of the scene. It exists out of a receiver which receives values from unity and triggers the toggle. This way it activates the projection of the beamer and the wave form. The wave is connected to the intensity of the image and is also connected with the lights and sound. 

The last part exists out of just an background image which always projects the image on the ground. 

![](https://i.gyazo.com/77e9354a800c497a1589f9950a7ad8b1.jpg)
