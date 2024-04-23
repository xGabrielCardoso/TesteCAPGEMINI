using TesteCAPGEMINI.Repositories;

namespace TesteCAPGEMINI.Services
{
    public class ProdutoService
    {
        public RepositoryProduto oRepositoryProduto { get; set; }

        public ProdutoService()
        {
            oRepositoryProduto = new RepositoryProduto();
        }
    }
}
