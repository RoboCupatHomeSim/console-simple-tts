# Simple Text-to-Speech
This is a submodule for the RoboCup@Home Simulation.

This console app uses SAPI to speak the given text.  
This project generates **ConsoleSimpleTTS.exe** and **Interop.SpeechLib.dll**.


## Prerequisites

- Windows 11
- Visual Studio 2022

## How to Build

1. Open the ConsoleSimpleTTS.sln with Visual Studio.
2. Click [Build]-[Build Solution].
2. **ConsoleSimpleTTS.exe** and **Interop.SpeechLib.dll** are generated in a "ConsoleSimpleTTS\bin\Release" folder.

## How to Run

1. Launch a command prompt.
1. You can confirm Text-to-Speech by executing the following command.  
    ```
    > cd ConsoleSimpleTTS\bin\Release
    > ConsoleSimpleTTS "I have a pen"
    ```
1. You can also set options to the second argument.  
    The 409 means English (United States).  
    However, an English (en-US) text-to-speech voice must be installed in Windows.  
    ```
    > ConsoleSimpleTTS "I have a pen" "Language=409;Gender=Female"
    ```
