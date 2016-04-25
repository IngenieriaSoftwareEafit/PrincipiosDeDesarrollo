using System;

namespace EP.SOLID.OCP.SolutionWithExtensionMethods
{
    public class CashMachine
    {
        public static void Operations()
        {
            OperationsMenu();

            var option = Console.ReadKey();
            var returnValue = string.Empty;

            var debitAccount = DadosDebito();

            switch (option.KeyChar)
            {
                case '1':
                    Console.WriteLine("Operation -> Current Account");
                    returnValue = debitAccount.chargeCurrentAccount();
                    break;
                case '2':
                    Console.WriteLine("Operation -> Savings Account");
                    returnValue = debitAccount.chargeSavingsAccount();
                    break;
                case '3':
                    Console.WriteLine("Operation -> Investment Account");
                    returnValue = debitAccount.chargeInvestmentAccount();
                    break;
            }

            TransactionReturn(returnValue);
        }

        private static void OperationsMenu()
        {
            Console.Clear();
            Console.WriteLine("SOLID CASH MACHINE");
            Console.WriteLine("OPTIONS:");
            Console.WriteLine();
            Console.WriteLine("1 - Withdraw money from savings account");
            Console.WriteLine("2 - Withdraw money from current account");
            Console.WriteLine("3 - Withdraw money from investment account");
        }

        private static DebitAccount DadosDebito()
        {
            Console.WriteLine();
            Console.WriteLine("..............................");
            Console.WriteLine();
            Console.WriteLine("ACCOUNT:");
            var account = Console.ReadLine();
            Console.WriteLine("VALUE:");
            var value = Convert.ToDecimal(Console.ReadLine());

            var debitAccount = new DebitAccount()
            {
                AccountNumber = account,
                Value = value
            };

            return debitAccount;
        }

        private static void TransactionReturn(string returnValue)
        {
            Console.WriteLine();
            Console.WriteLine("SUCCESS, TRANSACTION NUMBER: " + returnValue);
            Console.ReadKey();
        }
    }
}