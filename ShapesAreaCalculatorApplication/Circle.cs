namespace ShapesAreaCalculatorApplication
{
    internal class Circle : Shape
    {
        public Circle(double width, double height) : base(width, height)
        {
        }

        public override void DisplayInformations()
        {
            Console.WriteLine($"\nCircle R: {Height}, Area: {Area * 3.14}");
        }
    }
}
