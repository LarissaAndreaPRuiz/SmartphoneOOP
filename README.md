# Challenge OOP - Smartphone Simulation

This project is a simple object-oriented programming (OOP) challenge that simulates the functionality of different smartphones. It includes an abstract class `Smartphone`, which is extended by specific phone models such as `Nokia` and `iPhone`. Each phone can make a call, receive a call, and install apps.

## Features

- **Smartphone Class**: An abstract class with properties like phone number, model, IMEI, and memory. It contains basic methods to make and receive calls, and an abstract method to install apps.
- **Nokia Class**: Inherits from `Smartphone` and implements the method to install an app.
- **iPhone Class**: Also inherits from `Smartphone` and implements the method to install an app.

## Installation

To run this project, simply clone the repository and compile the code using any compatible C# development environment.

## Usage

The Main class demonstrates how to create instances of Nokia and iPhone, and how to use their methods:
using ChallengeOOP.Models;

```csharp
Nokia nokia = new Nokia("+11945947571", "Nokia 120", "ABC123", 128);
nokia.MakeCall();
nokia.ReceiveCall();
nokia.InstallApp("Whatsapp");
iPhone iphone = new iPhone("+11945947571", "iPhone 12", "ABC123", 64);
iphone.MakeCall();
iphone.ReceiveCall();
iphone.InstallApp("Facebook");
```
##Methods
- **MakeCall()** : Simulates making a call.
- **ReceiveCall()** : Simulates receiving a call.
- **InstallApp(string appName)** : Installs the specified app.


