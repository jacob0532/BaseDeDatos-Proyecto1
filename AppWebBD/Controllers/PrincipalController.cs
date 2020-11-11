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
        SP_CuentaAhorro SP_ProcedureCuentaAhorro = new SP_CuentaAhorro();
        SP_Beneficiario SP_ProcedureBeneficiario = new SP_Beneficiario();
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
                return CuentasAhorro(usuario);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
            //System.Diagnostics.Trace.WriteLine("\n A VEEEEEER" + usuario.User); imprime y pasar un parametro a la vista 
            //ViewBag.user = usuario.User;
            //return View("UsuarioConfirmed",usuario);
        public ActionResult CuentasAhorro(Usuario usuario)
        {
            if(usuario.EsAdmi == 0)
            {
                List<CuentaAhorro> cuentaList = SP_ProcedureCuentaAhorro.SeleccionarCuentaPorCedula(usuario.ValorDocIdentidad).ToList();
                return View("CuentasAhorro", cuentaList);
            }
            else
            {
                List<CuentaAhorro> cuentaList = SP_ProcedureCuentaAhorro.ObtenerTodasLasCuentas().ToList();
                return View("CuentasAhorro", cuentaList);
            }
        }
        public ActionResult verBeneficiarios(int numeroCuenta)
        {
            System.Diagnostics.Trace.WriteLine("\n A VEEEEEER" + numeroCuenta);
            List<Beneficiarios> beneficariosList = SP_ProcedureBeneficiario.SeleccionarBeneficiarios(numeroCuenta).ToList();
            return View(beneficariosList);
        }
        public ActionResult verEstadoDeCuenta(int numeroCuenta)
        {
            return View();
        }
        public ActionResult agregarBeneficiario(int numeroCuenta)
        {
            return View();
        }
        public ActionResult editarBeneficiario(int numeroCuenta)
        {
            return View();
        }
        public ActionResult eliminarBeneficiario(int numeroCuenta)
        {
            return View();
        }

    }

}
