#pragma checksum "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\UsuarioConfirmed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21ef59bdad8382b8af72cc9ba0df6aff38d5b9c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Principal_UsuarioConfirmed), @"mvc.1.0.view", @"/Views/Principal/UsuarioConfirmed.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21ef59bdad8382b8af72cc9ba0df6aff38d5b9c5", @"/Views/Principal/UsuarioConfirmed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23a3017679a57eb646949b40ff63d2e4c81b9fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Principal_UsuarioConfirmed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppWebBD.Models.Usuario>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\UsuarioConfirmed.cshtml"
  
    ViewData["Title"] = "UsuarioConfirmed";
    Layout = "~/Views/Shared/_LayoutUsuario.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21ef59bdad8382b8af72cc9ba0df6aff38d5b9c53438", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Bienvenido ");
#nullable restore
#line 9 "C:\Users\yeico\Desktop\BaseDeDatos-Proyecto1\AppWebBD\Views\Principal\UsuarioConfirmed.cshtml"
                                    Write(Model.User);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <footer class=""border-top footer text-muted"">
        <p>&copy; Jacob Guzmán / Darío Vargas.</p>
    </footer>
");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppWebBD.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
