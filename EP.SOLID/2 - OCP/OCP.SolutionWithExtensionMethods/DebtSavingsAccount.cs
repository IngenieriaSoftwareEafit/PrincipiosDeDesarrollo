namespace EP.SOLID.OCP.SolutionWithExtensionMethods
{
    public static class DebtSavingsAccount
    {
        public static string chargeSavingsAccount(this DebitAccount savingsAccount)
        {
            // Bussiness logic
            return savingsAccount.FormatTransaction();
        }
    }
}