using Microsoft.AspNetCore.Mvc;
using TesteCAPGEMINI.Models;
using TesteCAPGEMINI.Services;

namespace TesteCAPGEMINI.Controllers
{
    public class PedidosController : Controller
    {
        private PedidoService _service = new PedidoService();
        public IActionResult Index()
        {
            List<VwPedido> oListVwPedido = _service.oRepositoryVwPedido.SelecionarTodos();
            return View(oListVwPedido);
        }

        public IActionResult Create()
        {
            PedidoViewModel oPedidoViewModel = new PedidoViewModel();
            List<Produto> oListProduto = _service.oRepositoryProduto.SelecionarTodos();
            List<Cliente> oListCliente = _service.oRepositoryCliente.SelecionarTodos();

            oPedidoViewModel.oListProduto = oListProduto;
            oPedidoViewModel.oListCliente = oListCliente;
            oPedidoViewModel.oVwPedido = new VwPedido();
            oPedidoViewModel.oVwPedido.Status = "Novo";
            oPedidoViewModel.oVwPedido.ValorFrete = "10,00";

            return View(oPedidoViewModel);
        }

        [HttpPost]
        public IActionResult Create(PedidoViewModel pedidoViewModel)
        {
            PedidoViewModel oPedidoViewModel = new PedidoViewModel();

            if (string.IsNullOrEmpty(pedidoViewModel.IdCliente.ToString()) || pedidoViewModel.IdCliente == 0)
            {
                return RedirectToAction("Create");
            }


            var pedido = new Pedido
            {
                IdCliente = pedidoViewModel.IdCliente,
                IdProduto = pedidoViewModel.IdProduto,
                EnderecoEntrega = pedidoViewModel.oVwPedido.EnderecoEntrega,
                Status = "Novo",
                ValorFrete = "10,00",
                ValorTotal = _service.oRepositoryProduto.SelecionarPk(pedidoViewModel.IdProduto).Preco
            };



            _service.oRepositoryPedido.Incluir(pedido);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            VwPedido oListVwPedido = _service.oRepositoryVwPedido.SelecionarPk(id);
            return View(oListVwPedido);
        }
    }
}
