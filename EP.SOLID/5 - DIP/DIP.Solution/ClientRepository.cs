using System.Data;
using System.Data.SqlClient;
using EP.SOLID.DIP.Solucao.Interfaces;

namespace EP.SOLID.DIP.Solucao
{
    public class ClientRepository : IClienteRepository
    {
        public void InsertClient(Client client)
        {

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "ConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

                cmd.Parameters.AddWithValue("nome", client.Nome);
                cmd.Parameters.AddWithValue("email", client.Email);
                cmd.Parameters.AddWithValue("cpf", client.CPF);
                cmd.Parameters.AddWithValue("dataCad", client.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}