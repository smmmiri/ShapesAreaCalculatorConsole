﻿using ShapesAreaCalculatorApplication;
using ShapesAreaCalculatorApplication.Enums;

string? continueInput;

do
{
    Console.WriteLine("Please select a shape for calculating area: ");
    PrintShapes();
    var input = Console.ReadLine();

    try
    {
        switch (input)
        {
            case "1":
                Console.WriteLine("\nEnter the side value between 1 and 2000: ");
                if (int.TryParse(Console.ReadLine(), out int side) && side >= 1 && side <= 2000)
                {
                    new Square(side, side).DisplayInformations();
                }
                else
                {
                    throw new Exception();
                }
                break;
            case "2":
                Console.WriteLine("\nEnter the height value between 1 and 2000: ");
                if (int.TryParse(Console.ReadLine(), out int height) && height >= 1 && height <= 2000)
                {
                    Console.WriteLine("\nEnter the width value between 1 and 2000: ");
                    if (int.TryParse(Console.ReadLine(), out int width) && width >= 1 && width <= 2000)
                    {
                        new Rectangle(width, height).DisplayInformations();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }
                break;
            case "3":
                break;
            default:
                throw new Exception();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("\nplease enter ");
    }
    finally
    {
        Console.WriteLine("\nDo you want to continue? (Y/N)");
        continueInput = Console.ReadLine();
        Console.WriteLine();
    }
} while (continueInput.ToLower() != "n");

static void PrintShapes()
{
    var shapes = Enum.GetValues<Shapes>();
    foreach (var shape in shapes)
    {
        Console.WriteLine($"{(int)shape}) {shape}");
    }
}