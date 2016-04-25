using System;

namespace EP.SOLID.ISP.Breach
{
    public class ProductRegistration : Register
    {
        public void DataValidation()
        {
            // Value Validation
        }

        public void SaveBankData()
        {
            // Insert Product Table
        }

        public void SendEmail()
        {
            // Product does not have e-mail, what do I do now ???
            throw new NotImplementedException("This method is for nothing");
        }
    }
}