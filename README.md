# Simple Text-to-Speech
This is a submodule software for the Partner Robot Challenge (Virtual Space) in the World Robot Competition.

The console application synthesize voice sounds of the given text using SAPI.  
This project generates Interop.SpeechLib.dll for the application.


## Prerequisites

- Windows 10
- Visual Studio 2017
- Microsoft Speech Platform  
    You can download installers for speech synthesis from the following link.  
    https://www.microsoft.com/en-us/download/details.aspx?id=27224

## How to Build

1. Launch Visual Studio 2017.
2. Open the ConsoleSimpleTTS.sln with Visual Studio.
3. Click [Build]-[Build Solution].
4. ConsoleSimpleTTS.exe and Interop.SpeechLib.dll are generated in a "ConsoleSimpleTTS\bin\Release" folder.

## How to Execute

1. Launch a command prompt.
2. You can confirm Text-to-Speech by executing the following command.  
```
> cd ConsoleSimpleTTS\bin\Release
> ConsoleSimpleTTS "I have a pen"
```
3. You can also set options to the second argument.  
The 409 means English (United States).  
```
> ConsoleSimpleTTS "I have a pen" "Language=409;Gender=Female"
```


## License

This project is licensed under the SIGVerse License - see the LICENSE.txt file for details.
