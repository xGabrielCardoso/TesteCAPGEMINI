using TesteCAPGEMINI.Repositories;

namespace TesteCAPGEMINI.Services
{
    public class PedidoService
    {
        public RepositoryVwPedido oRepositoryVwPedido { get; set; }
        public RepositoryCliente oRepositoryCliente { get; set; }
        public RepositoryProduto oRepositoryProduto { get; set; }
        public RepositoryPedido oRepositoryPedido { get; set; }

        public PedidoService()
        {
            oRepositoryVwPedido = new RepositoryVwPedido();
            oRepositoryCliente = new RepositoryCliente();
            oRepositoryProduto = new RepositoryProduto();
            oRepositoryPedido = new RepositoryPedido();
        }
    }
}
