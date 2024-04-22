using TesteCAPGEMINI.Interfaces;
using TesteCAPGEMINI.Models;

namespace TesteCAPGEMINI.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        public RepositoryProduto(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
