using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppWebBD.Context;
using AppWebBD.Models;

namespace AppWebBD.Controllers
{
    public class ClienteController : Controller
    {
        SP SP_Procedure = new SP();
        public IActionResult Index()
        {
            List<Cliente> clienteList = SP_Procedure.SeleccionarClientes().ToList();
            return View(clienteList);
        }
        public ActionResult Details(int ValorDocIdentidad)
        {
            if (ValorDocIdentidad <= 0) return NotFound();
            Cliente cliente = SP_Procedure.SeleccionarClientePorCedula(ValorDocIdentidad);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }
    }

}
