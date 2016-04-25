using System.Data;
using System.Data.SqlClient;

namespace EP.SOLID.SRP.Solution
{
    public class ClientRepository
    {
        public void AddClient(Client client)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "ConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENT (NOME, EMAIL CPF, DATA_REGISTER) VALUES (@nome, @email, @cpf, @dataCad))";

                cmd.Parameters.AddWithValue("nome", client.Nome);
                cmd.Parameters.AddWithValue("email", client.Email);
                cmd.Parameters.AddWithValue("cpf", client.CPF);
                cmd.Parameters.AddWithValue("dataCad", client.DataRegister);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}