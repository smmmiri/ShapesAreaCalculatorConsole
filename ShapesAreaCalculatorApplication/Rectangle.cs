namespace ShapesAreaCalculatorApplication
{
    internal class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override void DisplayInformations()
        {
            Console.WriteLine($"\nRectangle H: {Height}, W: {Width}, Area: {Area}");
        }
    }
}
