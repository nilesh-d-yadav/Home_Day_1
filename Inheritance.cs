using System;
//using Class1;


class Grandfather
{
	public string theName;
	public int theAge;	
	public void GetDetails()
	{		
		Console.WriteLine($"GrandFather: The name is {theName} and the age is {theAge}");

	}
}

class Father: Grandfather
{

	public void Intro()
	{
		Console.WriteLine("I am Father");
	}
}

class Child:Father
{
	public void Intro()
		{
			Console.WriteLine("I am Child");
		}

}

public class Class1
{

    public static void Main(string[] args)
    {
        Grandfather p1 = new Grandfather();
        p1.theAge = 20;
        p1.theName = "Williams";

        //"John Wick"

        p1.GetDetails();
        Father d1 = new Father();
        d1.Intro();

        d1.theAge = 22;
        d1.GetDetails();

        Child c1 = new Child();
        
		c1.Intro();
		
		
		
    }

}

/*Notes:-
// 1. Derived Class = Child Class
// 2. Base Class = Parent Class

Types Of Inheritance:-
	a. Single Inheritance
	b. Multi-level  Inheritance - a derived class that inherits from the base class and the derived class itself becomes the base class for another derived class.
	c. Hierarchial Inheritance - a base class that servers as a parent for more than one dreived class
	d. Multiple Inheritance - a derived class that inherits from two or more base classes.
	e. Hybrid Inhheritance - mix of two or more inheritance
 
*/
