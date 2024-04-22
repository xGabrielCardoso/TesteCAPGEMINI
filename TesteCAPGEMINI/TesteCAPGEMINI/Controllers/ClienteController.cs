using Microsoft.AspNetCore.Mvc;
using TesteCAPGEMINI.Models;
using TesteCAPGEMINI.Services;

namespace TesteCAPGEMINI.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();  
        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oClienteService.oRepositoryCliente.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
