using ChallengeOOP.Models;

Nokia nokia = new Nokia("+11945947571", "Nokia 120", "ABC123", 128);

nokia.MakeCall();
nokia.ReceiveCall();
nokia.InstallApp("Whatsapp");

iPhone iphone = new iPhone("+11945947571", "iPhone 12", "ABC123", 64);

nokia.MakeCall();
nokia.ReceiveCall();
nokia.InstallApp("Whatsapp");

iphone.MakeCall();
iphone.ReceiveCall();
iphone.InstallApp("Facebook");
