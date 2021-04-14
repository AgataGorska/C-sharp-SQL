using System;

namespace PreworkBootcamp
{
    class HelloWorld
    {
		static void Main(string[]args )
		{
			Console.WriteLine("Hello World!");

			//string aFriend = "Bill";
			//Console.WriteLine(aFriend);
			//Console.WriteLine("Hello " + aFriend);
			//Console.WriteLine($"Hello {aFriend}");

			//string firstFriend = "Maria";
			//string secondFriend = "Sage";
			//Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
			//Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
			//Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
			//string greeting = "      Hello World!       ";
			//Console.WriteLine($"[{greeting}]");

			//string trimmedGreeting = greeting.TrimStart();
			//Console.WriteLine($"[{trimmedGreeting}]");

			//trimmedGreeting = greeting.TrimEnd();
			//Console.WriteLine($"[{trimmedGreeting}]");

			//trimmedGreeting = greeting.Trim();
			//Console.WriteLine($"[{trimmedGreeting}]");
			//string sayHello = "Hello World!";
			//Console.WriteLine(sayHello);
			//sayHello = sayHello.Replace("Hello", "Greetings");
			//Console.WriteLine(sayHello);
			//Console.WriteLine(sayHello.ToUpper());
			//Console.WriteLine(sayHello.ToLower());

			//string songLyrics = "You say goodbye, and I say hello";
			//Console.WriteLine(songLyrics.StartsWith("You"));
			//Console.WriteLine(songLyrics.StartsWith("goodbye"));

			//Console.WriteLine(songLyrics.EndsWith("hello"));
			//Console.WriteLine(songLyrics.EndsWith("goodbye"));

			// Integer
			int a = 10;
			int b = 200;
			int c;
			int max = int.MaxValue;
			int min = int.MinValue;
			Numbers n = new Numbers();
			c = n.Integer(a, b);
		Console.WriteLine("Integer returned: {0}",c);
		Console.WriteLine("Integer min and max value: {0} {1}", min, max);

			//Double
			double d = 19;
			double e = 76;
			double f = 3;
			double g;
			Numbers n1 = new Numbers();
			g = n1.Double(d,e,f);
			Console.WriteLine("Double returned: {0}",g);
			double max2 = double.MaxValue;
			double min2 = double.MinValue;
			Console.WriteLine("Double min and max value: {0} {1}", min2, max2);

			//Decimal

			decimal x = 1.0M;
			decimal y = 7.0M;
			decimal z;
			decimal min3 = decimal.MinValue;
			decimal max3 = decimal.MaxValue;
			Numbers n2 = new Numbers();
			z = n2.Decimal(x,y);
			Console.WriteLine("Decimal returned: {0}", z);
			Console.WriteLine("Decimal min and max value: {0} {1}", min3, max3);

		}
    }
}
