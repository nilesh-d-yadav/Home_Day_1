using System;

public class Class1
{
	public static void Main(string[] args)
	{
		//MainTailwind t = new MainTailwind();
		//t.OneData();
		Tailwind t2 = new Tailwind();	
		t2.OneData();
	}
	
}

public class MainTailwind
{
    public  void OneData()
    {
        Console.WriteLine("Main Tail Wind First Data");
    }
}


public class Tailwind:MainTailwind
{
	public void OneData()
	{
		Console.WriteLine("Tail Wind First Data");
	}
	public void OneData(int i)
	{
		Console.WriteLine("Second Data");
    }
    public void OneData(int i, int j) {
		Console.WriteLine("Third Data");
	}
}

/*See notations in C#

1. Compile - Time Polymorphism
--> In C#, we can achieve this using 'C# Method Overloading' which happens at compile-time.

2. Run - Time Polymorphism
--> In C#, the method that is determined at the runtime not at compile time.
--> Method Overriding - I
a method is present in both superclass and subclass, the method in subclass overrides the same method in superclass.
*/