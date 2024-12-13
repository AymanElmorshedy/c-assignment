using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region Value type casting 
            #region Implicit casting-Safe casting 
            //int x = 4;//4 bytes in stack
            //long y = /*(long)*/x;
            #endregion
            #region Explicit casting-Unsafe Casting
            //long x = 1010101010101;//8 bytes
            //int y;
            //checked
            //{
            //y = (int)x;
            //}
            //Console.WriteLine(y);
            //int x = 44;
            //double y =/*(int)*/ x;//implicit casting

            //double x = 22.3;
            //int y =(int) x;
            //Console.WriteLine(y);
            #endregion
            #region Parse [Convert from string to any data type]

            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter Data User ");
            //Console.Write("please enter your name :");
            //string Name = Console.ReadLine();

            //Console.Write("please enter your age :");
            //int Age = int.Parse(Console.ReadLine());

            //Console.Write("Please enter your Salary : ");
            //double Salary = double.Parse(Console.ReadLine());

            //Console.Clear();//display data in new console 
            //Console.WriteLine("Name : " + Name + " age: " + Age + " Salary:" + Salary);


            #endregion
            #region Convert[Convert From Any Datatype to Any Datatype ]
            //Console.WriteLine("Please Enter Data User ");
            //Console.Write("please enter your name :");
            //string Name = Console.ReadLine();

            //Console.Write("please enter your age :");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter your Salary : ");
            //double Salary = Convert.ToDouble(Console.ReadLine());

            //Console.Clear();//display data in new console 
            //Console.WriteLine("Name : " + Name + " age: " + Age + " Salary:" + Salary);

            #endregion
            #endregion
            #region Operators
            #region Unary Operator [++ , -- ]
            //int x = 5;
            //x++; //Post fixx
            //++x; // prefix increament
            //Console.WriteLine(x++);
            //Console.WriteLine(x);
            //Console.WriteLine(--x);
            //Console.WriteLine(x--);
            //Console.WriteLine(x);
            #endregion
            #region Binary Operator
            //int a = 10;
            //int b = 5;
            //int sum, sub, mult, div, mod;
            //sum = a + b;
            //sub = a - b;
            //mult = b * a;
            //div = a / b;
            //mod = a % b;
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);
            //Console.WriteLine(div);
            //Console.WriteLine(mod);
            //Console.WriteLine(mult);
            #endregion
            #region Assignment Operator
            //int x = 10;
            //x += 10;//x=x+10
            //x-= 10;//x=x-10
            //x=x*10;
            //x=x/10;
            //x=x%10;
            #endregion
            #region Relation Operator
            //int a = 1;
            //int b = 2;
            //Console.WriteLine(a != b);
            #endregion
            #region Logical Operator[Short Circuts]
            //Console.WriteLine(!true);
            //Console.WriteLine(true && true);//true
            //Console.WriteLine(true && false);//false
            //Console.WriteLine(false && false);//false
            //Console.WriteLine(true || false);
            //true || false = true
            //true || true = true
            //false || false = true
            #endregion
            #region Bitwise Operator[Long Circuts]
            //Console.WriteLine(!true);
            //Console.WriteLine(true && true);//true
            //Console.WriteLine(true && false);//false
            //Console.WriteLine(false && false);//false
            //Console.WriteLine(true || false);
            //true || false = true
            //true || true = true
            //false || false = true
            #endregion
            #region Ternary Operator[Conditional Operator]
            //int x = 5;

            //string Message =x>5 ?"big number":"Small number";
            //Console.WriteLine(Message);


            #endregion
            #endregion
            #region Operator Periorety
            /*
             1. Unary Operator[Prefix]
             2.( )
             3.* / %
             4.+ -
             */
            //int a = 10;
            //int b = 20;
            //int c = 15;
            //int d = 5;
            //int Result;
            //Result = (a+b)*c/d;
            //Console.WriteLine(Result);
            #endregion
            #region String Formating
            //X + Y = Result
            //10 + 5 = 15
            //int Y = 5;
            //int X = 10;
            //int Result = X + Y;
            //Console.WriteLine("Equation: "+X+" + "+Y+" = "+Result);
            //Imutable datatype
            #region 1. Composite Format
            //string Message = string.Format("{0} +{1} = {2}", X, Y, Result);
            //Console.WriteLine(Message);
            #endregion
            #region String Manipulation
            //String Interpolation = $
            //Console.WriteLine($"{X} + {Y} = {Result}");
            #endregion

            #endregion
            #region If-Switch Case
            //1 = Month is Jan
            //2 = Month is Feb
            //1 = Month is Mar
            // Invalid input
            //Console.Write("Please enter mounth number :");
            //int MounthNumber = int .Parse(Console.ReadLine());
            //if (MounthNumber == 1)
            //{
            //    Console.WriteLine("Month is Jan");
            //}
            //else if (MounthNumber == 2)
            //{
            //    Console.WriteLine("Mounth is feb");

            //}
            //else if (MounthNumber == 3)
            //{
            //    Console.WriteLine("Mounth is Mar");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            //switch(MounthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Mounth is Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Mounth is Mar");
            //        break;
            //    case 3:
            //        Console.WriteLine("Invalid Input");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        break;
            //}
            //Console.Write("Please Enter Your name :");
            //string Name = Console.ReadLine();
            //if (Name == "May")
            //{
            //    Console.WriteLine("Welcome My");
            //}
            //else if (Name == "mona")
            //{
            //    Console.WriteLine("Welcome Mona");

            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}

            //switch (Name) {
            //    case "May":
            //        Console.WriteLine("Welcome My");
            //        break;
            //    case "mona":
            //        Console.WriteLine("Welcome Mona");
            //        break;


            //}
            #endregion
            #region Go-To
            //3000 => opttion 1,option 2,option 3
            //2000 => opttion 1,option 2
            //1000 => opttion 1
            //Console.WriteLine("Please enter option number ");
            //int Option = int.Parse(Console.ReadLine());
            //switch (Option)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 3");
            //        goto case 2000;

            //    case 2000:
            //        Console.WriteLine("Option 2");
            //        goto case 1000;

            //    case 1000:
            //        Console.WriteLine("Option 1");
            //        break;

            //}

            #endregion
            #region Evaluation of switch case
            #region c#6
            //Console.WriteLine("Enter your age ");
            //int age = int.Parse(Console.ReadLine());
            //switch (age)
            //{
            //    case > 22:
            //        Console.WriteLine("Age grater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Age is less than 22");
            //        break;
            //    case 22:
            //        Console.WriteLine("age is 22");
            //        break;

            #endregion
            #region c#7
            //object obj = new object();
            //obj = "mostafa";
            //obj = 89;
            //obj = true;
            //switch (obj)
            //{
            //    case int num when num>3:
            //        Console.WriteLine($"{num} is int ");
            //        break;
            //    case string Name:
            //        Console.WriteLine($"{Name} is string");
            //        break;
            //}
            #endregion
            #region C#8
            //Console.WriteLine("Please enter option ");
            //int Option = int.Parse(Console.ReadLine());
            //string message = Option switch//Switch exprition
            //{
            //    1 => "option 1",
            //    2 => "Option 2",
            //    3 => "Option 3",
            //    _ => "invalid input"
            //};
            //Console.WriteLine(message);
            //adding properityy from classs
            #endregion
            #region C#9

            //Adding logical operator with properity
            #endregion


            #endregion
            #endregion
            #region Assignment
            #region Q1
            //1 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 
            //otherwise print no.
            //Console.WriteLine("Please enter a numberber : ");
            //int number=int.Parse(Console.ReadLine());
            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");

            //}
            //else
            //{
            //    Console.WriteLine("No");

            //}

            #endregion
            #region Q2
            //Write a program that allows the user to insert an integer then print negative if it is negative 
            //number otherwise print positive.
            //Console.Write("Please enter a number:"); 
            //int Number = int.Parse(Console.ReadLine());
            //if (Number > 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else
            //{
            //    Console.WriteLine("Negative");
            //}
            #endregion
            #region Q3

            //Write a program that takes 3 integers from the user
            //then prints the max element and the min element.
            //Console.WriteLine("Please inter num1: ");
            //int Num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter num 2:");
            //int Num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter num3 :");
            //int Num3 = int.Parse(Console.ReadLine());
            //int max = 0, min = 0;

            //if (Num1 > Num2)
            //{
            //    max = Num1;
            //    if (Num3 > max)
            //        max = Num3;
            //}
            //if (Num2 > Num1)
            //{
            //    max = Num2;
            //    if (Num3 > max)
            //        max = Num3;
            //}
            //if (Num1 < Num2)
            //{
            //    min = Num1;
            //    if (Num3 < min)
            //        min = Num3;
            //}
            //if (Num2 < Num1)
            //{
            //    min = Num2;
            //    if (Num3 < min)
            //        min = Num3;
            //}
            //Console.WriteLine($"min is {min} and max is {max} ");

            #endregion
            #region Q4
            //Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Pleased entert a number:");
            //int Num = int.Parse(Console.ReadLine());
            //if(Num % 2==0)
            //{
            //    Console.WriteLine($"{Num} is even number");
            //}
            //else 
            //    {
            //    Console.WriteLine($"{Num} is Odd number");

            //    }
            #endregion
            #region Q5
            //Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u)
            //then print(vowel) otherwise print(consonant).
            //Console.WriteLine("Please enter a char:");
            //string character = Console.ReadLine();
            //switch(character)
            //{
            //    case "a" or  "A":
            //        Console.WriteLine("vowel");
            //        break;
            //    case "e" or "E":
            //        Console.WriteLine("vowel");
            //        break ;
            //    case "o" or "O":
            //        Console.WriteLine("vowel");
            //        break;
            //    case "i" or "I":
            //        Console.WriteLine("vowel");
            //        break;
            //    case "u" or "U":
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;

            //}
            #endregion
            #region Q7

            //Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12.
            //Console.WriteLine("Please enter a number:");
            //int Num = int.Parse(Console.ReadLine());
            //int mul;
            //Console.Clear();

            //for (int i = 1; i <= 12; i++)
            //{
            //    mul = Num * i;
            //    Console.WriteLine(mul);

            //}


            #endregion
            #region Q9
            //9- Write a program that takes two integers then prints the power.
            //Console.WriteLine("Please enter num 1:");
            //int Num1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter num 2 : ");
            //int Num2=int.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Pow(Num1,Num2));
            #endregion
            #region Q10
            //10 - Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.WriteLine("Please enter grade 1 :");
            //int Grade1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter grade 2 :");
            //int Grade2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter grade 3 :");
            //int Grade3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter grade 4 :");
            //int Grade4 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter grade 5 :");
            //int Grade5 = int.Parse(Console.ReadLine());
            //int total = 5;
            //int Sum = Grade1+Grade2+Grade3+Grade4+Grade5;
            //int Average = Sum/total;
            //int Persentage = Average;
            //Console.Clear();
            //Console.WriteLine($"Total Marks is { Sum}");
            //Console.WriteLine($"Average Marks is { Average}");
            //Console.WriteLine($"Persentage of marks is { Persentage}%");





            #endregion
            #region Q11
            //Console.WriteLine("Please enter a mounth number");
            //int Mounth = int.Parse(Console.ReadLine());
            //switch(Mounth)
            //{
            //    case 1:
            //        Console.WriteLine(31);
            //        break;
            //    case 2:
            //        Console.WriteLine(28);
            //        break;
            //    case 3:
            //        Console.WriteLine(31);
            //        break;
            //    case 5:
            //        Console.WriteLine(31);
            //        break;
            //    case 7:
            //        Console.WriteLine(31);
            //        break;
            //    case 8:
            //        Console.WriteLine(31);
            //        break;
            //    case 10:
            //        Console.WriteLine(31);
            //        break;
            //    case 12:
            //        Console.WriteLine(31);
            //        break;
            //    default:
            //        Console.WriteLine(30);
            //        break;



            #endregion
            #region Q17
            /*
            int x1,y1,x2,y2,x3,y3;
            Console.WriteLine("Enter your first point(x1,y1): ");
            x1=int.Parse(Console.ReadLine());
            y1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second point(x2,y2): ");
            x2=int.Parse(Console.ReadLine());
            y2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Third point(x3,y3): ");
            x3=int.Parse(Console.ReadLine());
            y3=int.Parse(Console.ReadLine());
            int m1 = (y2 - y1) / (x2 - x1),m2 = (y3 - y2) / (x3 - x2);
            if (Math.Abs(m1) == Math.Abs(m2))   
                Console.WriteLine($"The points ({x1},{y1}) , ({x2},{y2}) , ({x3},{y3}) is in stright line");
            else
                Console.WriteLine("The points is not in a stright line");
            */
            #endregion
            #region Q18
            //Console.WriteLine("Please enter duration time for your task");
            //double duration = double.Parse(Console.ReadLine());
            //if (duration >= 2 && duration <= 3)
            //{
            //    Console.WriteLine("Highly efficient");
            //}
            //else if (duration > 3 && duration <= 4)
            //{
            //    Console.WriteLine("increase your speed");
            //}
            //else if (duration > 4 && duration <= 5)
            //{
            //    Console.WriteLine("provide with trainng to enhance your speed");
            //}
            //else if (duration > 5 )
            //{
            //    Console.WriteLine("you are reqired to leave the company");
            //}


            #endregion
            #region Q21
            /*
            Write C# program that Assigning one value type variable to another and 
            modifying the value of one variable and mention what will happen
             */

            //int number1 = 10;
            //int number2 = number1; 

            //Console.WriteLine("Before modification:");
            //Console.WriteLine($"number1= {number1}");
            //Console.WriteLine($"number2 = {number2}");


            //number1 = 20;


            //Console.WriteLine("\nAfter modification:");
            //Console.WriteLine($"number1= {number1}");
            //Console.WriteLine($"number2 = {number2}");
            //This shows that the value types are stored as separate copies, and modifying one copy does not affect the other.
            #endregion
            #region Q22
            //object obj1 = new object ();
            //obj1 = "Ayman";
            //object obj2 = new object ();
            //obj2 = obj1;


            //Console.WriteLine("Before modification:");
            //Console.WriteLine($"obj1= {obj1} ");
            //Console.WriteLine($"obj2 = {obj2}");


            //obj1 = "Ali";

            //Console.WriteLine("After modification:");
            //Console.WriteLine($"obj1= {obj1} ");
            //Console.WriteLine($"obj2 = {obj2}");
            //When you assign a reference variable to another, both variables refer to the same object, so any modification to the object affects all references to it.
            #endregion
            #region Q23

            //23 - Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Answer b)	A value 1 will be assigned to d.

            #endregion
            #region Q24
            //24-	Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2); 
            // Answer d)6 1
            #endregion
            #region Q25
            //25-What will be the output of the C# code given below?
            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            //Answer > d)7 7
            #endregion

            #endregion
        }


    }
}
