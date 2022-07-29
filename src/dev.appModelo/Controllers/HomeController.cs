using System;
using dev.appModelo.Data;
using Microsoft.AspNetCore.Mvc;
using static dev.appModelo.Data.PedidoRepository;

namespace dev.appModelo.Controllers
{
   //controller com injeção de dependência
    public class HomeController: Controller
    {
        private IPedidoRepository _pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public IActionResult Index(/*[FromServices] IPedidoRepository _pedidorepository*/)
        {
            var pedido = _pedidoRepository.ObterPedido();
            return View();
        }
    }
}
