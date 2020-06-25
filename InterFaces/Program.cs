using System;

namespace InterFaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Square: ");
            Square sq = null;

            try
            {
                sq = new Square(-2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                sq = new Square(2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Square Perimeter = {sq.Perimeter():0.00}");
            Console.WriteLine($"Square Area = {sq.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Rectangle: ");
            Rectangle rec = null;

            try
            {
                rec = new Rectangle(2.0, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                rec = new Rectangle(2.0, 4.0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Rectangle Perimeter: {rec.Perimeter():0.00}");
            Console.WriteLine($"Rectangle Area: {rec.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Triangle: ");
            Triangle triangle = null;

            try
            {
                triangle = new Triangle(10, 12, -97);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                triangle = new Triangle(10, 12, 197);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                triangle = new Triangle(10, 12, 97);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Third side: {triangle.ThirdSide():0.00}");
            Console.WriteLine($"Height: {triangle.Height:0.00}");
            Console.WriteLine($"Triangle Perimeter: {triangle.Perimeter():0.00}");
            Console.WriteLine($"Triangle Area: {triangle.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Parallelogram: ");
            Parallelogram pg = null;

            try
            {
                pg = new Parallelogram(0, 12, 97);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                pg = new Parallelogram(10, 12, 197);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                pg = new Parallelogram(10, 12, 97);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Parallelogram Perimeter: {pg.Perimeter():0.00}");
            Console.WriteLine($"Parallelogram Height: {pg.Height:0.00}");
            Console.WriteLine($"Parallelogram Area: {pg.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Circle: ");
            Circle circle = null;

            try
            {
                circle = new Circle(-9);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                circle = new Circle(9);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Circle radius: {circle.SideBase:0.00}");
            Console.WriteLine($"Circle diameter: {circle.Height:0.00}");
            Console.WriteLine($"Circle Perimeter: {circle.Perimeter():0.00}");
            Console.WriteLine($"Circle Area: {circle.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Rhombus: ");
            Rhombus rhombus = null;

            try
            {
                rhombus = new Rhombus(10, -45);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                rhombus = new Rhombus(10, 245);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                rhombus = new Rhombus(10, 45);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Rhombus Perimeter: {rhombus.Perimeter():0.00}");
            Console.WriteLine($"Rhombus Height: {rhombus.Height:0.00}");
            Console.WriteLine($"Rhombus Area: {rhombus.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Compound Figure:");
            CompoundFigure cf = new CompoundFigure(5);
            cf.AddFigure(sq);
            cf.AddFigure(rec);
            cf.AddFigure(triangle);
            cf.AddFigure(pg);
            cf.AddFigure(rhombus);
            Console.WriteLine($"Square Area = {sq.Area():0.00}");
            Console.WriteLine($"Rectangle Area: {rec.Area():0.00}");
            Console.WriteLine($"Triangle Area: {triangle.Area():0.00}");
            Console.WriteLine($"Parallelogram Area: {pg.Area():0.00}");
            Console.WriteLine($"Rhombus Area: {rhombus.Area():0.00}");
            Console.WriteLine($"The area of this figure = {cf.FindArea():0.00}");
        }
    }
}

