using EP.SOLID.DIP.Solucao.Interfaces;

namespace EP.SOLID.DIP.Solucao
{
    public class ClientServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClientServices(
            IEmailServices emailServices, 
            IClienteRepository clienteRepository)
        {
            _emailServices = emailServices;
            _clienteRepository = clienteRepository;
        }

        public string InsertClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid Data";

            _clienteRepository.InsertClient(client);

            _emailServices.Enviar("empresa@empresa.com", client.Email, "Welcome!", "you successfully joined in our platform!");

            return "Client successfully registered.";
        }
    }
}