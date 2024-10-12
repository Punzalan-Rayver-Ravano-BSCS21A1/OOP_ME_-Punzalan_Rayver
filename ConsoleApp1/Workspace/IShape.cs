namespace ConsoleApp1.Exam
{
    public interface IShape
    {
        double GetArea();
        double GetPerimeter();
    }

    public class Rectangle : IShape
    {
        private double _length;
        private double _width;

        public double Length { get; set; }
        public double Width { get; set; }

        public double GetArea()
        {
            return Length * Width;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Length);
        }
    }

    public class Triangle : IShape 
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {
            //// Heron's formula: Area = sqrt(s * (s - a) * (s - b) * (s - c))
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s* (s - SideA) * (s - SideB) * (s - SideC));
           
        }

        /// <summary>
        /// A + B + C
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }


}
