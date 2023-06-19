﻿namespace homework8
{
    internal class Program
    {
        static void Main()
        {
            List<Shape> shapes = new();
            for (int i = 0; i < 2; i++) 
            {
                string? nameToAdd = "";
                do
                {
                    Console.WriteLine("enter square's name");
                    nameToAdd = Console.ReadLine();
                } while (nameToAdd == null);
                double sideToAdd = 0;
                a1:
                try
                {
                    Console.WriteLine("Enter square's side size");
                    sideToAdd = Convert.ToDouble(Console.ReadLine());
                } catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto a1;
                }

                shapes.Add(new Square(nameToAdd, sideToAdd));
            }

            for (int i = 0; i < 2; i++)
            {
                string? nameToAdd = "";
                do
                {
                    Console.WriteLine("enter circle's name");
                    nameToAdd = Console.ReadLine();
                } while (nameToAdd == null);
                double radiusToAdd = 0;
            a1:
                try
                {
                    Console.WriteLine("Enter circle's radius");
                    radiusToAdd = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto a1;
                }

                shapes.Add(new Circle(nameToAdd, radiusToAdd));
            }

            foreach (Shape shape in shapes) 
            {
                shape.Print();
            }

            Console.WriteLine($"Shape with the biggest perimeter is {shapes.MaxBy(Shape => Shape.Perimeter()).Name}");
            shapes.Sort();

            foreach (Shape shape in shapes)
            {
                shape.Print();
            }
        }
    }
}