namespace EP.SOLID.SRP.Solution
{
    public class ClienteService
    {
        public string AdicionarCliente(Client client)
        {
            if (!client.IsValid())
                return "Invalid Data";

            var repo = new ClientRepository();
            repo.AddClient(client);

            EmailServices.Enviar("empresa@empresa.com", client.Email, "Welcome!", "Congratulations, you successfully joined in our platform!");

            return "Client successfully registered";
        }
    }
}