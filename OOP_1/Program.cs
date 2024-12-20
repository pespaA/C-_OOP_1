using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OOP_1
{
    
    internal class Program
    {
        enum WeekDays
        {
            Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
        }
        enum Season
        {
            Spring, Summer, Autumn, Winter
        }
        [Flags]
        enum Permissions
        {
            None = 0,
            Read = 1,
            write = 2,
            Delete = 4,
            Execute = 8
        }
        enum Colors
        {
            Red, Green, Blue
        }
        static void Main(string[] args)
        {
            Demo.Demo0();

            #region 01
            //Create an enum called "WeekDays" with the days of the week
            //(Monday to Sunday) as its members. Then, write a C# program
            //that prints out all the days of the week using this enum.

            foreach (WeekDays Day in Enum.GetValues(typeof(WeekDays)))
                Console.WriteLine(Day);
            #endregion

            #region 02
            //Define a struct "Person" with properties "Name" and "Age".
            //Create an array of three "Person" objects and populate it with data.
            //Then, write a C# program to display the details of all the persons in the array.

            Person[] per = new Person[3];
            per[0] = new Person("omar", 24);
            per[1] = new Person("Ahmed", 12);
            per[2] = new Person("omarrr", 35);
            foreach (var pr in per)
                pr.Display();
            #endregion

            #region 03
            //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            Console.WriteLine("Select Season (Spring, Summer, Autumn, Winter)");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, true, out Season selectedSeason))
            {
                switch (selectedSeason)
                {
                    case Season.Spring:
                        Console.WriteLine("spring from march to may");
                        break;
                    case Season.Summer:
                        Console.WriteLine("summer from june to august");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("autumn from September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("winter from December to February");
                        break;
                    default:
                        Console.WriteLine("this input not seasons");
                        break;
                }
            }


            #endregion

            
            #region 04
            //Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission is existed inside variable

            Permissions user = Permissions.None;
            user = Permissions.Read | Permissions.write;
            int inputFromUser=0;
            int addPer = 0;
            do
            {
                Console.WriteLine($"Current permissions for user is: {user}");
                Console.WriteLine("Type 0 to go out\ntype 1 to add Permission\ntype 2 to remove Permission");
                inputFromUser = int.Parse(Console.ReadLine());
                if (inputFromUser == 1)
                {
                    Console.WriteLine("What permissions you want to add { Read = 1 , write = 2 , Delete = 4 , Execute = 8 }");
                    addPer = int.Parse(Console.ReadLine());
                    if ((int)user >= addPer)
                    {
                        Console.WriteLine("The user have this permissions");
                    }
                    else if ((int)user <= addPer && addPer <9)
                    {
                        if (addPer == 8)
                            user = user | Permissions.Execute;
                        else if (addPer == 4)
                            user = user | Permissions.Delete;
                        else if (addPer == 2)
                            user = user | Permissions.write;
                        else if (addPer == 1)
                            user = user | Permissions.Read;
                        else
                            Console.WriteLine("invaled permission number");
                    }
                    else
                        Console.WriteLine("invaled permission number");
                }
                if (inputFromUser == 2)
                {
                    Console.WriteLine("What permissions you want to remove { Read = 1 , write = 2 , Delete = 4 , Execute = 8 }");
                    addPer = int.Parse(Console.ReadLine());
                    if ((int)user >= addPer && addPer > 0 )
                    {
                        if (addPer == 8)
                            user = user ^ Permissions.Execute;
                        else if (addPer == 4)
                            user = user ^ Permissions.Delete;
                        else if (addPer == 2)
                            user = user ^ Permissions.write;
                        else if (addPer == 1)
                            user = user ^ Permissions.Read;
                        else
                            Console.WriteLine("invaled permission number");
                    }
                    else
                    {
                        Console.WriteLine("invaled permission number");
                    }
                }
            } 
            while (inputFromUser != 0);

            Console.WriteLine($"Current permissions for user is: {user}");

            #endregion

            #region 05
            //Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            Console.WriteLine("input a color");
            string input2 = Console.ReadLine();
            string mssg = "";
            foreach (string color in Enum.GetNames(typeof(Colors)))
            {
                if (input2 == color)
                {
                    mssg = $"the {input2} is primary";
                    break;
                }

                else
                    mssg = $"the {input2} is not primary";
            }
            Console.WriteLine(mssg);



            #endregion

            #region 06
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.
            Console.WriteLine("Enter 2 point to calculates the distance");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Point point = new Point(x, y);
            point.calculates();
            #endregion

            #region 07
            //Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            Person person1;
            Person person2;
            Person person3;
            
            Console.Write("Enter Name For Person 1: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age For Person 1: ");
            int age = int.Parse(Console.ReadLine());
            person1 = new Person(name,age);
            Console.WriteLine("-----------------------------");
            Console.Write("Enter Name For Person 2: ");
            name = Console.ReadLine();
            Console.Write("Enter Age For Person 2: ");
            age = int.Parse(Console.ReadLine());
            person2 = new Person(name, age);
            Console.WriteLine("-----------------------------");
            Console.Write("Enter Name For Person 3: ");
            name = Console.ReadLine();
            Console.Write("Enter Age For Person 3: ");
            age = int.Parse(Console.ReadLine());
            person3 = new Person(name, age);

            if (person1.Age >= person2.Age && person1.Age >= person3.Age)
            {
                    Console.WriteLine($"{person1.Name} is the oldest person");  
            }
            else if (person2.Age >= person3.Age) 
            {
                   Console.WriteLine($"{person2.Name} is the oldest person");
            }
            else Console.WriteLine($"{person3.Name} is the oldest person");
            #endregion
        }
    }
}
