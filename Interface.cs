using System;

public class Class1
{
		public static void Main(string[] args) { 
			Pig p = new Pig();
			p.animalSound();
		}	
}

interface Animal
{
	void animalSound();
}

class Pig : Animal
{
	public void animalSound()
	{
		Console.WriteLine("The pig says: Wee wee");
	}
}

/*# Notes Interface:
	1. An interface is defined using the interface keyword and is similar to the class.
	2. It has properties, methods declaration. The implementation of interface's members will be given by a class that implements the interface explicitly
	   OR implicitly. So it is a completely "abstract class" which can contain only abstract methods and properties.
		Interface has just declaration of properties and methods but no body of them.
	3. Interface cannot have private members.
	4. By default, all members of interface are public and abstract.
	5. 
*/
