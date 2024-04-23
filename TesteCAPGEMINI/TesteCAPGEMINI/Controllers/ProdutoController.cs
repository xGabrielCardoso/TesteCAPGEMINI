using Microsoft.AspNetCore.Mvc;
using TesteCAPGEMINI.Models;
using TesteCAPGEMINI.Services;

namespace TesteCAPGEMINI.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoService oProdutoService = new ProdutoService();
        public IActionResult Index()
        {
            List<Produto> oListProduto = oProdutoService.oRepositoryProduto.SelecionarTodos();
            return View(oListProduto);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oProdutoService.oRepositoryProduto.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Produto oProduto = oProdutoService.oRepositoryProduto.SelecionarPk(id);
            return View(oProduto);
        }

        public IActionResult Edit(int id)
        {
            Produto oProduto = oProdutoService.oRepositoryProduto.SelecionarPk(id);
            return View(oProduto);
        }

        [HttpPost]
        public IActionResult Edit(Produto model)
        {
            Produto oProduto = oProdutoService.oRepositoryProduto.Alterar(model);
            int id = oProduto.Id;
            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            oProdutoService.oRepositoryProduto.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}
