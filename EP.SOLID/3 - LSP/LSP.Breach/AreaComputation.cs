using System;

namespace EP.SOLID.LSP.Breach
{
    public class AreaComputation
    {
        private static void GetRectangleArea(Rectangle ret)
        {
            Console.Clear();
            Console.WriteLine("Rectangle Area Computation");
            Console.WriteLine();
            Console.WriteLine(ret.Height + " * " + ret.Width);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Computation()
        {
            var quad = new Square()
            {
                Height = 10,
                Width = 5
            };

            GetRectangleArea(quad);
        }
    }
}