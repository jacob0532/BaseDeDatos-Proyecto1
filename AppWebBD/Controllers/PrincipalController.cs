using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppWebBD.Context;
using AppWebBD.Models;

namespace AppWebBD.Controllers
{
    public class PrincipalController : Controller
    {
        SP_Cliente SP_ProcedureCliente = new SP_Cliente();
        SP_Usuario SP_ProcedureUsuario = new SP_Usuario();

        public object FlashMessage { get; private set; }

        public IActionResult Index()
        {
            List<Cliente> clienteList = SP_ProcedureCliente.SeleccionarClientes().ToList();
            return View(clienteList);
        }
        public ActionResult Details(int ValorDocIdentidad)
        {
            if (ValorDocIdentidad <= 0) return NotFound();
            Cliente cliente = SP_ProcedureCliente.SeleccionarClientePorCedula(ValorDocIdentidad);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost, ActionName("Login")]
        public ActionResult LoginConfirmed(string user,string pass)
        {
            Usuario usuario = SP_ProcedureUsuario.verUsuario(user, pass);
            System.Diagnostics.Trace.WriteLine(usuario);
            if (usuario.User != null)
            {
                return UsuarioConfirmed(usuario);
            }
            else
            {
                var msg = "El usuario o contraseña no son válidos.";    //Mensaje de error.
                TempData["ErrorMessage"] = msg;                         //Tempdata, guarda el mensaje de error.
                return RedirectToAction("Login");
            }

        }

        public ActionResult LogOut(Usuario usuario)
        {
            usuario = null;
            return View("Index");
        }

        public ActionResult UsuarioConfirmed(Usuario usuario)
        {
            if(usuario.User != null) 
            { 
                return View("UsuarioConfirmed",usuario);
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult AddBen()
        {
            return View();
        }
        public ActionResult EditarBen() 
        {
            return View();
        }
        public ActionResult DeleteBen()
        {
            return View();
        }
        public ActionResult ConsultarEstadoCuenta()
        {
            return View();
        }
    }

}
