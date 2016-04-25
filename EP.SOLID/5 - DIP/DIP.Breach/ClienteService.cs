namespace EP.SOLID.DIP.Breach
{
    public class ClienteService
    {
        public string AdicionarCliente(Client cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            var repo = new ClientRepository();
            repo.InsertClient(cliente);

            EmailServices.Send("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}