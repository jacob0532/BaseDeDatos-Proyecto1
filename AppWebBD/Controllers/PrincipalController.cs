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
            //System.Diagnostics.Trace.WriteLine("\n A VEEEEEER"+user);
            Usuario usuario = SP_ProcedureUsuario.verUsuario(user, pass);
            if(usuario.User != null)
            {
                return UsuarioConfirmed(usuario);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult UsuarioConfirmed(Usuario usuario) //jaguero  LaFacil
        {
            //System.Diagnostics.Trace.WriteLine("\n A VEEEEEER" + usuario.User);
            //ViewBag.user = usuario.User;
            return View("UsuarioConfirmed",usuario);
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
