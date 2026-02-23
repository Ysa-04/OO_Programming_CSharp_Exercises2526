namespace H10_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(-1, 1.0);
            Triangle triangle2 = new Triangle(3, 0);
            Rectangle rectangle1 = new Rectangle(2.2, 1.5);
            Rectangle rectangle2 = new Rectangle(3, 1);

            rectangle1.DemoFigures();
            rectangle2.DemoFigures();

            triangle1.DemoFigures();
            triangle2.DemoFigures();
        }

        internal class Triangle
        {

            private double height;
            public double Height
            {
                get { return height; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine($"Het is verboden om een hoogte van {value} in te stellen!");
                    }
                    else
                    {
                        height = value;
                    }
                }
            }
            private double width;
            public double Width
            {
                get { return width; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine($"Het is verboden om een breedte van {value} in te stellen!");
                    }
                    else
                    {
                        width = value;
                    }
                }
            }

            public Triangle(double height, double width)
            {
                Height = height;
                Width = width;
            }

            public double Area
            {
                get { return (width * height) / 2; }
            }
            public void DemoFigures()
            {
                Console.WriteLine($"Een driehoek met een breedte van {Width}m en een hoogte van {Height}m heeft een oppervlakte van {Math.Round(Area, 1)}m².");
            }
        }

        internal class Rectangle
        {
            private double height;
            public double Height
            {
                get { return height; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine($"Het is verboden een hoogte van {value} in te stellen!");
                    }
                    else
                    {
                        height = value;
                    }
                }
            }
            private double width;
            public double Width
            {
                get { return width; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine($"Het is verboden een breedte van {value} in te stellen!");
                    }
                    else
                    {
                        width = value;
                    }
                }
            }
            public Rectangle(double height, double width)
            {
                Height = height;
                Width = width;
            }
            public double Area
            {
                get { return width * height; }
            }
            public void DemoFigures()
            {
                Console.WriteLine($"Een rechthoek met een breedte van {Width}m en een hoogte van {Height}m heeft een oppervlakte van {Math.Round(Area, 1)}m².");
            }
        }
    }
}
