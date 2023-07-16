using ShapesAreaCalculatorApplication;
using ShapesAreaCalculatorApplication.Enums;

string? continueInput;

do
{
    Console.WriteLine("Please select a shape for calculating area: ");
    PrintShapes();
    var input = Console.ReadLine();

    try
    {
        Console.WriteLine();
        var message = input switch
        {
            "1" => "Enter the side value between 1 and 2000: ",
            "2" => "Enter the width and height values between 1 and 2000 with a space between them: ",
            "3" => "Enter the radius value between 1 and 2000: ",
            _ => throw new Exception()
        };
        Console.Write(message);

        string[] number;
        switch (input)
        {
            case "1":
                number = Console.ReadLine().Split(" ");
                if (double.TryParse(number[0], out double side) && side > 2000 && side < 1)
                {
                    
                    throw new Exception();
                }
                new Rectangle(double.Parse(number[0]), double.Parse(number[1])).DisplayInformations();
                break;
            case "2":
                number = Console.ReadLine().Split(" ");
                var s = !double.TryParse(number[0], out double sds);
                if ((!double.TryParse(number[0], out double width) & !double.TryParse(number[1], out double height)) &&
                    (width > 2000 || width < 1) && (height > 2000 || height < 1))
                {
                    Console.WriteLine();
                    throw new Exception();
                }
                new Rectangle(width, height).DisplayInformations();
                break;
            case "3":
                number = Console.ReadLine().Split(" ");
                if (double.TryParse(number[0], out double radius) && radius > 2000 && radius < 1)
                {
                    throw new Exception();
                }
                new Rectangle(double.Parse(number[0]), double.Parse(number[1])).DisplayInformations();
                break;
            default:
                break;
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