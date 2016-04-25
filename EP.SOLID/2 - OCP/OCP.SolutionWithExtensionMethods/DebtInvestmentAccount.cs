namespace EP.SOLID.OCP.SolutionWithExtensionMethods
{
    public static class DebitoContaInvestimento
    {
        public static string chargeInvestmentAccount(this DebitAccount investmentAccount)
        {
            // Bussiness Logic
            return investmentAccount.FormatTransaction();
        }
    }
}