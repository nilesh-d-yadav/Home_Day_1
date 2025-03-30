// See https://aka.ms/new-console-template for more information
using System;
using CreateClasses;
namespace MySystem
{
    class BaseClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello There");


            // ----------- Note: Data Types -----------
            #region DataTypes
            //float b = 21.75f;
            //double num2 = 74.2525456589d;
            //decimal a = 10M;
            //int ab=5+1;
            #endregion

            // ----------- Note: Get Data Type -----------
            #region GetDataType
            //To get Data Type
            //Console.WriteLine(a.GetType());
            #endregion

            // ----------- Note: Get Input Validation PRO -----------
            #region Validation
            //int num;
            //while (true)
            //{

            //    try
            //    {
            //        Console.Write("\nEnter a valid int: ");
            //        num = Convert.ToInt32(Console.ReadLine());
            //        if(num>int.MaxValue || num < int.MinValue)
            //        {
            //            throw new OverflowException();
            //        }
            //        break;
            //    }
            //    catch(FormatException ex)
            //    {
            //        Console.Write($"Error: {ex.Message}");
            //        continue;
            //    }
            //    catch(OverflowException){
            //        //Console.Write($"Error: {ex.Message}");
            //        Console.WriteLine($"Invalid range. Please enter value between {int.MinValue} and {int.MaxValue} ");
            //        continue;

            //    }


            //}

            //Console.WriteLine(num);
            #endregion

            // ----------- Note: Switch within switch -----------
            #region switch
            //No Duplicate Case Values: In C#, duplicate case values are not allowed.

            /*
             int outerVal = 2;
            int innerVal = 1;
            switch (outerVal)
            {
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    switch (innerVal)
                    {
                        case 1:
                            Console.WriteLine("One ka one");
                            break;
                        case 2:
                            Console.WriteLine("Two ka two");
                            break;
                        default:
                            Console.WriteLine("Default ka default");
                            break;
                    }
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                default: Console.WriteLine("Default ka default");
                    break;

            }
            Console.Read();
            */
            #endregion

            int number = 20;
            #region goto
            // go to case statement statement
            /*
            switch (number)
            {
                case 5:
                    Console.WriteLine("case 5");
                    break;
                case 10:
                    Console.WriteLine("case 10");
                    break;
                case 20:
                    Console.WriteLine("case 20");

                    // goto statement transfers 
                    // control to case 5
                    goto case 5;

                default:
                    Console.WriteLine("No match found");
                    break;
            }
            */
            #endregion
           

        }
        
    }
}

