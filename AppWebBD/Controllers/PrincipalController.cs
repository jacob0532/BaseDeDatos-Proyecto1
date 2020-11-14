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
        SP_EstadoCuenta SP_ProcedureEstadoCuenta = new SP_EstadoCuenta();
        public static Usuario usuarioFijo { get; set; } = null;
        public static int cedulaAnterior { get; set; } = 0;
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
            usuarioFijo = usuario;
            if (usuario.User != null)
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
            if (usuario.EsAdmi == 0)
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
            return View("verBeneficiarios",tabla);
        }
        public ActionResult volverIndex()
        {
            return LoginConfirmed(usuarioFijo.User, usuarioFijo.Pass);
        }
        public ActionResult verEstadoDeCuenta(int numeroCuenta)
        {
            List<EstadoCuenta> estadosCuentasList = SP_ProcedureEstadoCuenta.SeleccionarEstadoDeCuenta(numeroCuenta).ToList();
            return View(estadosCuentasList);
        }
        public ActionResult agregarBeneficiario(int numeroCuenta)
        {
            return View();
        }

        [HttpPost, ActionName("agregarBeneficiario")]
        public ActionResult agregarBeneficiario([Bind]Beneficiarios beneficiario)
        {
            if (ModelState.IsValid)
            {
                SP_ProcedureBeneficiario.AgregarBeneficiario(beneficiario);
                return RedirectToAction("volverIndex");
            }
            return NotFound();
        }
        public ActionResult editarBeneficiario(int ValorDocumentoIdentidadBeneficiario)
        {
            cedulaAnterior = ValorDocumentoIdentidadBeneficiario;
            Beneficiarios beneficiario = SP_ProcedureBeneficiario.SeleccionarBeneficiarioPorCedula(ValorDocumentoIdentidadBeneficiario);
            if (beneficiario != null)
                return View(beneficiario);
            else
                return NotFound();   
        }
        [HttpPost, ActionName("editarBeneficiario")]
        public ActionResult editarBeneficiario(int ValorDocumentoIdentidadBeneficiario, [Bind]Beneficiarios beneficiario)
        {
            if (ModelState.IsValid)
            {
                SP_ProcedureBeneficiario.EditarBeneficiario(beneficiario, cedulaAnterior);
                return RedirectToAction("volverIndex");
            }
            return NotFound();
        }
        public ActionResult eliminarBeneficiario(int ValorDocumentoIdentidadBeneficiario,int numeroCuenta)
        {
            Beneficiarios beneficiario = SP_ProcedureBeneficiario.SeleccionarBeneficiarioPorCedula(ValorDocumentoIdentidadBeneficiario);
            if (beneficiario != null)
                return View(beneficiario);
            else
                return NotFound();
        }
        public ActionResult eliminarConfirmed(int ValorDocumentoIdentidadBeneficiario,int numeroCuenta)
        {
            try
            {
                SP_ProcedureBeneficiario.EliminarBeneficiario(ValorDocumentoIdentidadBeneficiario);
                return verBeneficiarios(numeroCuenta);
            }
            catch
            {
                return NotFound();
            }
        }

    }

}
