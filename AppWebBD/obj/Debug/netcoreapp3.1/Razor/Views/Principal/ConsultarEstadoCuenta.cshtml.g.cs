#pragma checksum "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "228aa88acef7ace220f0a6370ebef8aeee85eff9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Principal_ConsultarEstadoCuenta), @"mvc.1.0.view", @"/Views/Principal/ConsultarEstadoCuenta.cshtml")]
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
#line 1 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\_ViewImports.cshtml"
using AppWebBD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\_ViewImports.cshtml"
using AppWebBD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"228aa88acef7ace220f0a6370ebef8aeee85eff9", @"/Views/Principal/ConsultarEstadoCuenta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23a3017679a57eb646949b40ff63d2e4c81b9fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Principal_ConsultarEstadoCuenta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppWebBD.Models.EstadoCuenta>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "228aa88acef7ace220f0a6370ebef8aeee85eff93615", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ConsultarEstadoCuenta</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "228aa88acef7ace220f0a6370ebef8aeee85eff94690", async() => {
                WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayNameFor(model => model.NumeroCuenta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayNameFor(model => model.SaldoInicial));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayNameFor(model => model.SaldoFinal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumeroCuenta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaInicio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaFin));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayFor(modelItem => item.SaldoInicial));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.DisplayFor(modelItem => item.SaldoFinal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                ");
#nullable restore
#line 62 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                ");
#nullable restore
#line 63 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\ConsultarEstadoCuenta.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppWebBD.Models.EstadoCuenta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
