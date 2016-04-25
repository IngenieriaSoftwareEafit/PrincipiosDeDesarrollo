namespace EP.SOLID.OCP.Solution
{
    public class DebtInvestmentAccount : DebitAccount
    {
        public override string Charge(decimal valor, string conta)
        {
            // Debt Investment Account
            // Exempt rates
            return transaction();
        }
    }
}