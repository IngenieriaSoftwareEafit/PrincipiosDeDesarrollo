namespace EP.SOLID.OCP.Solution
{
    public class DebitCurrentAccount : DebitAccount
    {
        public override string Charge(decimal valor, string conta)
        {
            // Debit Current Account
            return transaction();
        }
    }
}