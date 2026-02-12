namespace H10_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Figures();
        }
        internal class Figures
        {
            public Figures()
            {
                Triangle triangle1 = new Triangle();
                Triangle triangle2 = new Triangle();
                Rectangle rectangle1 = new Rectangle();
                Rectangle rectangle2 = new Rectangle();
                rectangle1.Width = -1;
                rectangle1.Width = 0;
                rectangle1.Width = 2.2;
                rectangle1.Height = 1.5;
                rectangle2.Width = 3;

                rectangle1.DemoFigures();
                rectangle2.DemoFigures();

                triangle1.Width = 3;
                triangle2.Width = 2;
                triangle2.Height = 2;

                triangle1.DemoFigures();
                triangle2.DemoFigures();
            }
        }

        internal class Triangle
        {
            private double height = 1.0;
            private double width = 1.0;

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
            private double height = 1.0;
            private double width = 1.0;

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
