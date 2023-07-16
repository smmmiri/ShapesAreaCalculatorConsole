using ShapesAreaCalculatorApplication.Enums;

do
{
    Console.WriteLine("Please select a shape for calculating area: ");
    PrintShapes();
    var input = Console.ReadLine();

    try
    {
        var message = input switch
        {
            "1" => "",
            "2" => "",
            "3" => "",
            _ => ""
        };
    }
    catch (Exception)
    {

        throw;
    }
} while (true);

static void PrintShapes()
{
    var shapes = Enum.GetValues<Shapes>();
    foreach (var shape in shapes)
    {
        Console.WriteLine($"{(int)shape}) {shape}");
    }
    Console.WriteLine();
}