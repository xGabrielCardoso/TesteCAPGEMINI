using TesteCAPGEMINI.Interfaces;
using TesteCAPGEMINI.Models;

namespace TesteCAPGEMINI.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
