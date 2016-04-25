using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace EP.SOLID.SRP.Breach
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataRegister { get; set; }

        public string AddClient()
        {
            if (!Email.Contains("@"))
                return "Invalid E-MAIL";

            if (CPF.Length != 11)
                return "Invalid CPF";


            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "ConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENT (NOME, EMAIL CPF, DATA_REGISTER) VALUES (@nome, @email, @cpf, @dataCad))";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("dataCad", DataRegister);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("empresa@empresa.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome!.";
            mail.Body = "Congratulations, you successfully joined in our platform!";
            client.Send(mail);

            return "Client successfully registered.";
        }
    }
}