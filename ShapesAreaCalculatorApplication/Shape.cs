namespace ShapesAreaCalculatorApplication
{
    internal class Shape
    {
        protected double Width { get; set; }
        protected double Height { get; set; }
        protected readonly double Area;

        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
            Area = Width * Height;
        }

        public virtual void DisplayInformations()
        {
        }
    }
}
