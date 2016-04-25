using System;

namespace EP.SOLID.LSP.Solution
{
    public class Square : Parallelogram
    {
        public Square(int height, int widh)
            : base(height, widh)
        {
            if(widh != height)
                throw new ArgumentException("The two sides of the square must be equal");
        }
    }
}