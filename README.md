MotorController
===============

Simple script to control Zaber motor using Zaber Console Script Runner on Linux

Dependencies
------------
mono-runtime 2.0

Installation
------------

Install the Zaber Console source from [here](http://www.zaber.com/wiki/Software/Zaber_Console#Installing_on_GNU.2FLinux)

Copy the script to the /bin directory of the file and use
`mono ScriptRunner.exe /showports`
`mono ScriptRunner.exe /port PORT_NAME /device 1 MotorController.cs`
