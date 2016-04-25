namespace EP.SOLID.OCP.Breach
{
    public class ChargeToAccount
    {
        public void Cherge(decimal valor, string conta, AccountType account)
        {
            if (account == AccountType.Current)
            {
                // Debits on Debit Account
            }

            if (account == AccountType.Savings)
            {
                // Validates the Account by Birthday Information
                // Debits on Savings Account
            }
        }
    }
}