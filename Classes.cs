using CreateClasses;
using BaseClass;
using System;

namespace BaseClass
{
    class Mian
    {

        //Constructor is a special method of the class which gets automatically invoked whenever an instance of the class is created.
        //Constructors in C# are fundamental components of object-oriented programming. Like methods, It contains the collection of instructions
        //that are executed at the time of Object creation. It is used to assign initial values to the data members of the same class.
        //Some important points about Constructors are mentioned below:

        //The constructor of a class must have the same name as the class name in which it resides.
        //A class can have any number of constructors.
        //A constructor can not be abstract, final, and Synchronized.
        //A constructor doesn’t have any return type.

        //Types of Constructor

        //There are different types of constructors in C#, each serving different purposes. These are the most commonly used:-

        //1. Default Constructor - 
        //2. Parameterized Constructor
        //3. Copy Constructor
        //4. Private Constructor
        //5. Static Constructor

        public static void Main(string[] args)
        {
            MyClass m = new MyClass(10);
            m.Display();
            MyClass m2 = new MyClass(20);
            m2.Display();
        }
        
    }
}


namespace CreateClasses
{
    class MyClass
    {
        static MyClass() // static constructor
        {
            Console.WriteLine("Static  Called");
        }

        public MyClass(int i)
        {
            Console.WriteLine("Normal Constructor is Called");
        }
        public  void Display()
        {
            Console.WriteLine("Display Method is Called");
        }

    }
}

//Notes:-
    //1. default
    //2. parameterized
    //3. copy -  creating an object and then using that object as a parameter for another constructor in the same class.
    //4. private - no one can derive or create objects from this class. no class can derive from this and its instance cant be created.
    //5. static  - it is created when the first reference of member of the class. It is called automatically to initialize the class before the first instance is created. 
    //    this class will have 2 contructors one static and one public - to initialize values during object  creation. static constructor will be called once now matter 
    //    how many objects we create out of it.