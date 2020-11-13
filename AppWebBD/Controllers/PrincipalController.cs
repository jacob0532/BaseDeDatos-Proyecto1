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
        SP_Parentezco SP_ProcedureParentezco = new SP_Parentezco();
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
            List<Beneficiarios> beneficariosList = SP_ProcedureBeneficiario.SeleccionarBeneficiarios(numeroCuenta).ToList();
            List<Cliente> clientesList = new List<Cliente>();
            List<Parentezco> parentezcoList = new List<Parentezco>();
            foreach (var item in beneficariosList)
            {
                Cliente cliente = SP_ProcedureCliente.SeleccionarClientePorCedula(item.ValorDocumentoIdentidadBeneficiario);
                clientesList.Add(cliente);
                Parentezco parentezco = SP_ProcedureParentezco.SeleccionarParentezco(item.ParentezcoId);
                parentezcoList.Add(parentezco);
            }
            Tablas tabla = new Tablas();
            tabla.ListaDeBeneficiarios = beneficariosList;
            tabla.ListaDeClientes = clientesList;
            tabla.ListaDeParentezcos = parentezcoList;
            return View(tabla);
        }
        public ActionResult verEstadoDeCuenta(int numeroCuenta)
        {
            return View();
        }
        public ActionResult agregarBeneficiario(int numeroCuenta)
        {
            return View();
        }
        public ActionResult editarBeneficiario(int ValorDocumentoIdentidadBeneficiario)
        {
            return View();
        }
        public ActionResult eliminarBeneficiario(int ValorDocumentoIdentidadBeneficiario,int numeroCuenta)
        {
            Beneficiarios beneficiario = SP_ProcedureBeneficiario.SeleccionarBeneficiarioPorCedula(ValorDocumentoIdentidadBeneficiario);
            if (beneficiario != null)
                return View(beneficiario);
            else
                return NotFound();
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult eliminarConfirmed(int ValorDocumentoIdentidadBeneficiario,int numeroCuenta)
        {
            try
            {
                SP_ProcedureBeneficiario.EliminarBeneficiario(ValorDocumentoIdentidadBeneficiario);
                return RedirectToAction("verBeneficiarios",numeroCuenta);
            }
            catch
            {
                return NotFound();
            }
        }

    }

}
