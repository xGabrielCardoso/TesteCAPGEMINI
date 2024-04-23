using TesteCAPGEMINI.Interfaces;
using TesteCAPGEMINI.Models;

namespace TesteCAPGEMINI.Repositories
{
    public class RepositoryVwPedido : RepositoryBase<VwPedido>, IRepositoryVwPedido
    {
        public RepositoryVwPedido(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
