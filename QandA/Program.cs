using System;

namespace QandA
{
	class MainClass
	{
		/*
		 * Author: Alex Munoz A.K.A Cubed
		 * Email: alex@napend.com
		 * Site: http://alex-munoz.net
		 * Site: http://napend.com
		 */
		public static void Main (string[] args)
		{

			// Set the color of the begining Red
			Console.ForegroundColor = ConsoleColor.Red;
			// Tells the user thats its a Q and A
			Console.Write ("Welcome to the Question And Answer, ");
			// Color is cyan
			Console.ForegroundColor = ConsoleColor.Cyan;
			// Text
			Console.Write ("By: ");
			// Color green
			Console.ForegroundColor = ConsoleColor.Green;
			// Text
			Console.Write ("Cubed ");
			// Color Red
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write ("| ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine ("Alex Munoz!");
			//Console.Write ("Test");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine (" These questions are about Alex Munoz...");

			// Question 1:

			Console.ForegroundColor = ConsoleColor.Yellow;
			// The text
			Console.Write("What is your name? ");
			// Color
			Console.ForegroundColor = ConsoleColor.DarkGray;
			// Allows input and sets it as a variable (choice)
			string name = Console.ReadLine();
			// Color
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			// Tells the user their name , Shows the input
			Console.WriteLine("Hello {0}", name);

			// Question 2:

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write ("What company do I own? ");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			string company = Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;

//			Console.Write("Ask any question: ");
//			string question = Console.ReadLine();

			// Tells the user if there correct or wrong
			if (company.ToLower () == "napend") {
				Console.WriteLine ("Correct");
			} else {
				Console.WriteLine ("Wrong, the answer is 'Napend' ");
			}

			// Question 3:

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write ("What language do I use for making games? ");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			string lua = Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;

			//			Console.Write("Ask any question: ");
			//			string question = Console.ReadLine();

			// Tells the user if there correct or wrong
			if (lua.ToLower () == "lua") {
				Console.WriteLine ("Correct");
			} else {
				Console.WriteLine ("Wrong, the answer is 'lua' ");
			}

			// Question 4:

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write ("What is my online name? ");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			string oname = Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;

			//			Console.Write("Ask any question: ");
			//			string question = Console.ReadLine();

			// Tells the user if there correct or wrong
			if (oname.ToLower () == "cubed") {
				Console.WriteLine ("Correct");
			} else {
				Console.WriteLine ("Wrong, The answer is 'Cubed' ");
			}

	}
}
}