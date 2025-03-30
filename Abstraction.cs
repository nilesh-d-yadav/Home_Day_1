using System;
using MyDemonstration;
public class Class1
{

	public static void Main(string[] args)
	{
		//Creating reference of the Shape class which refer to the Square class instance.
		Shape sh = new Square(4);
		double result = sh.area();
		Console.WriteLine($"Result is: {result}");

		//Creating referece of the interface which refers to the Geeky class instance.
		Student obj = new Geeky();
		obj.FavSub();

	}	
}

namespace MyDemonstration {
	abstract class Shape
	{
		//abstract method, so no direct access
		public abstract int area();
	}

	class Square : Shape
	{
		private int side;

		public Square(int x=0)
		{
			side = x;
		}
		public override int area() {
			Console.Write("Area of Square: ");
			return side * side;
		}
	}
}


public interface Student
{
	void FavSub();
}

public class Geeky : Student
{
	public void FavSub() {
		Console.WriteLine("My Favourite Nilesh");
	}
}



//Notes:-
/*
1. Essential Details are shown to the user and non-essential ones are hidden from user.
2. Abstraction can be achieved using Abstract class or Interface.

2. Abstraction vs Encapsulation
--> Abstraction is hiding the implementaion and exposing the essential detials only.
--> Encapsulate the data and information in a single unit and provide access through accessors.

--> Abstraction is used to hide the complex functionality and show the user-friendly interface.
--> Encapsulation provides security and prevent unauthorized access.

--> A class can have many features like drive(), break() and gear() without knowing the implementation that is Abstraction.
--> Get() and Set() accessors to provide access controls to the data.


*/