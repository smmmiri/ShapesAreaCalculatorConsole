namespace ShapesAreaCalculatorApplication
{
    internal class Square : Shape
    {
        public Square(double width, double height) : base(width, height)
        {
        }

        public override void DisplayInformations()
        {
            Console.WriteLine($"\nSquare S: {Height}, Area: {Area}");
        }
    }
}
