#pragma checksum "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\eliminarBeneficiario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3b52795dc451dfbd31884674fb7b198866b8da9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Principal_eliminarBeneficiario), @"mvc.1.0.view", @"/Views/Principal/eliminarBeneficiario.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\_ViewImports.cshtml"
using AppWebBD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\_ViewImports.cshtml"
using AppWebBD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3b52795dc451dfbd31884674fb7b198866b8da9", @"/Views/Principal/eliminarBeneficiario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23a3017679a57eb646949b40ff63d2e4c81b9fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Principal_eliminarBeneficiario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppWebBD.Models.Beneficiarios>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\eliminarBeneficiario.cshtml"
  
    ViewData["Title"] = "eliminarBeneficiario";
    Layout = "~/Views/Shared/_LayoutUsuario.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Eliminar Beneficiario</h1>\r\n\r\n\r\n<br />\r\n<div>\r\n    <h4>Beneficiario</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\eliminarBeneficiario.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroCuenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-12\">\r\n            ");
#nullable restore
#line 20 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\eliminarBeneficiario.cshtml"
       Write(Html.DisplayFor(model => model.NumeroCuenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\eliminarBeneficiario.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorDocumentoIdentidadBeneficiario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-12\">\r\n            ");
#nullable restore
#line 26 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\eliminarBeneficiario.cshtml"
       Write(Html.DisplayFor(model => model.ValorDocumentoIdentidadBeneficiario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\eliminarBeneficiario.cshtml"
       Write(Html.DisplayNameFor(model => model.ParentezcoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-12\">\r\n            ");
#nullable restore
#line 32 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\eliminarBeneficiario.cshtml"
       Write(Html.DisplayFor(model => model.ParentezcoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\eliminarBeneficiario.cshtml"
       Write(Html.DisplayNameFor(model => model.Porcentaje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-12\">\r\n            ");
#nullable restore
#line 38 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\eliminarBeneficiario.cshtml"
       Write(Html.DisplayFor(model => model.Porcentaje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    ");
#nullable restore
#line 41 "C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\eliminarBeneficiario.cshtml"
Write(Html.ActionLink("Eliminar", "eliminarConfirmed", new {ValorDocumentoIdentidadBeneficiario = Model.ValorDocumentoIdentidadBeneficiario,numeroCuenta=Model.NumeroCuenta}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppWebBD.Models.Beneficiarios> Html { get; private set; }
    }
}
#pragma warning restore 1591
