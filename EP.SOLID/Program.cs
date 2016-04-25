using System;
using EP.SOLID.LSP.Breach;
using EP.SOLID.OCP.SolutionWithExtensionMethods;

namespace EP.SOLID
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("1 - OCP");
            Console.WriteLine("2 - LSP");

            var option = Console.ReadKey();

            switch (option.KeyChar)
            {
                case '1':
                    CashMachine.Operations();
                    break;
                case '2':
                    AreaComputation.Computation();
                    break;
            }
        }
    }
}