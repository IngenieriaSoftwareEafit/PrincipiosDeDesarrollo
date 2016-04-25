namespace EP.SOLID.OCP.SolutionWithExtensionMethods
{
    public static class DebitoContaCorrente
    {
        public static string chargeCurrentAccount(this DebitAccount currentAccount)
        {
            // Bussiness Logic
            return currentAccount.FormatTransaction();
        }
    }
}