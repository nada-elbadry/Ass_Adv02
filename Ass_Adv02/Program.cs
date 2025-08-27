using Ass_Adv02.Structs;
using System;
using System.Drawing;
using Point = Ass_Adv02.Structs.Point;
using Rectangle = Ass_Adv02.Structs.Rectangle;

namespace Ass_Adv02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Struct Person with Array
            Person[] persons =
            {
                new Person { Name = "Ali", Age = 22 },
                new Person { Name = "Sara", Age = 30 },
                new Person { Name = "Omar", Age = 27 }
            };

            Console.WriteLine("Q1: Persons List:");
            foreach (var p in persons)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            }
            Console.WriteLine();
            #endregion

            #region Q2 - Distance Between Two Points
            Console.WriteLine("Q2: Enter coordinates of first point:");
            Console.Write("X1: ");
            double x1 = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Y1: ");
            double y1 = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Enter coordinates of second point:");
            Console.Write("X2: ");
            double x2 = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Y2: ");
            double y2 = double.Parse(Console.ReadLine() ?? "0");

            Point p1 = new Point { X = x1, Y = y1 };
            Point p2 = new Point { X = x2, Y = y2 };

            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Distance = {distance:F2}");
            Console.WriteLine();
            #endregion

            #region Q3 - Oldest Person
            Person[] personsInput = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Q3: Enter details of person {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine() ?? "";
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine() ?? "0");

                personsInput[i] = new Person { Name = name, Age = age };
            }

            Person oldest = personsInput[0];
            foreach (var p in personsInput)
            {
                if (p.Age > oldest.Age)
                    oldest = p;
            }

            Console.WriteLine($"Oldest Person: {oldest.Name}, Age: {oldest.Age}");
            Console.WriteLine();
            #endregion

            #region Q4 - Rectangle with Encapsulation
            Rectangle rect = new Rectangle();
            rect.Width = 5.5;
            rect.Height = 3.2;
            rect.DisplayInfo();

            rect.Width = -10; // Invalid test
            rect.Height = 7.4;
            rect.DisplayInfo();
            #endregion
        }
    }
}
