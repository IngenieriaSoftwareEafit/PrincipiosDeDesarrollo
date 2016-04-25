using System.Data;
using System.Data.SqlClient;

namespace EP.SOLID.DIP.Breach
{
    public class ClientRepository
    {

        public void InsertClient(Client client)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

                cmd.Parameters.AddWithValue("nome", client.Name);
                cmd.Parameters.AddWithValue("email", client.Email);
                cmd.Parameters.AddWithValue("cpf", client.CPF);
                cmd.Parameters.AddWithValue("dataCad", client.RegisterData);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}