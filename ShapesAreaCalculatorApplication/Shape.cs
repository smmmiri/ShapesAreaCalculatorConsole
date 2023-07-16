namespace ShapesAreaCalculatorApplication
{
    internal class Shape
    {
        protected double Width { get; set; }
        protected double Height { get; set; }
        protected readonly double Area;

        public Shape()
        {
            Area = Width * Height;
        }

        protected virtual void DisplayInformations()
        {
        }
    }
}
