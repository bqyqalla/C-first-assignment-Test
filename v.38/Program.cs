// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");

Console.WriteLine("v38");
Console.WriteLine(23 + 23);
string text = "textual";


Console.WriteLine(text);






// Fråga 1.
string name = v._38.Services.Utility.GetUserName();

// Fråga 2.
string word = v._38.Services.Utility.GetWord();


//Fråga 3.
string age = v._38.Services.Utility.GetNumber("Enter Your Age");


// Fråga 4.

string hobby = v._38.Services.Utility.AskHobby("Hobby");

// Fråga 5.
string fullName = v._38.Services.Utility.Getinfo("firstName", "lastName");

Console.WriteLine(name);//Svar 1. 

Console.WriteLine(word);// Svar 2. 

Console.WriteLine(age); //Svar 3.

Console.WriteLine($"{hobby} sounds boring"); // Svar 4.

Console.WriteLine(fullName);  // svar 5.
Console.ReadLine();