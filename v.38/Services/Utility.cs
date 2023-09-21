using System;
namespace v._38.Services
{
	public class Utility
	{
		//Method 1. 
		public static string GetUserName()
		{
			Console.WriteLine("Enter Username");
			string userName = Console.ReadLine();
			return userName;
		}
		//Method 2.
		public static string GetWord()
		{
			Console.WriteLine("Enter Word");
			string word = Console.ReadLine();
			return "#" + word;
		}
		//Method 3.
		public static string GetNumber(string message)
		{
			Console.WriteLine(message);
			string age = Console.ReadLine();
			return age;
		}
		//Method 4.
		public static string AskHobby(string word)
		{
			Console.WriteLine($"Please Enter A {word}");
			string hobby = Console.ReadLine();
			return hobby;
		}
		//Method 5.
		
        public static string Getinfo( string firstName, string lastName)
        {
			string last = lastName.ToUpper();

			string first = firstName.ToLower();
				

			return $"{last}, {first}";

        }
		





    }
}

