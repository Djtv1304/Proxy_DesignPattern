using Microsoft.AspNetCore.Mvc;
using Proxy_DesignPattern.Models;
using Proxy_DesignPattern.Models.Proxy;
using System.Diagnostics;

namespace Proxy_DesignPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private Cuenta cuenta = new Cuenta(1, "Cuenta de ahorros", 100);
        private ICuenta cuentaProxy = new CuentaProxy();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewBag.cuentaSaldo = cuentaProxy.mostrarSaldo(cuenta);

            cuenta = cuentaProxy.depositarDinero(cuenta, 50);

            ViewBag.cuentaSaldoDepositado = cuentaProxy.mostrarSaldo(cuenta);

            cuenta = cuentaProxy.retirarDinero(cuenta, 20);

            ViewBag.cuentaSaldoRetirado = cuentaProxy.mostrarSaldo(cuenta);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
