using TesteCAPGEMINI.Repositories;

namespace TesteCAPGEMINI.Services
{
    public class ClienteService
    {
        public RepositoryCliente oRepositoryCliente { get; set; }

        public ClienteService()
        {
            oRepositoryCliente = new RepositoryCliente();
        }
    }
}
