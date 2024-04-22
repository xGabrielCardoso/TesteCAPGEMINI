using TesteCAPGEMINI.Interfaces;
using TesteCAPGEMINI.Models;

namespace TesteCAPGEMINI.Repositories
{
    public class RepositoryPedido : RepositoryBase<Pedido>, IRepositoryPedido
    {
        public RepositoryPedido(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
