#pragma checksum "C:\Users\jacoL\Documents\Visual Studio 2017\Projects\SistemaVendasAspNetCore\SistemaVendasAspNetCore\Views\Cliente\ExcluirCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c2309ee9f2597a395eb64cf743686c70e8ca87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_ExcluirCliente), @"mvc.1.0.view", @"/Views/Cliente/ExcluirCliente.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/ExcluirCliente.cshtml", typeof(AspNetCore.Views_Cliente_ExcluirCliente))]
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
#line 1 "C:\Users\jacoL\Documents\Visual Studio 2017\Projects\SistemaVendasAspNetCore\SistemaVendasAspNetCore\Views\_ViewImports.cshtml"
using SistemaVendasAspNetCore;

#line default
#line hidden
#line 2 "C:\Users\jacoL\Documents\Visual Studio 2017\Projects\SistemaVendasAspNetCore\SistemaVendasAspNetCore\Views\_ViewImports.cshtml"
using SistemaVendasAspNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c2309ee9f2597a395eb64cf743686c70e8ca87", @"/Views/Cliente/ExcluirCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94a07b345e062074d715a4d42b5cc3b194252ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_ExcluirCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 247, true);
            WriteLiteral("<h2>Cliente Excluído com sucesso!</h2>\r\n\r\n<button type=\"button\" class=\"btn btn-success\" onclick=\"Voltar()\">Listagem de Clientes.</button>\r\n\r\n<script>\r\n    function Voltar() {\r\n        window.location.href = \'../../Cliente/Index\';\r\n    }\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
