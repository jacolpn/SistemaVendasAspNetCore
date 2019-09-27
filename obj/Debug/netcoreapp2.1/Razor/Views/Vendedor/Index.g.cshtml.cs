#pragma checksum "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\Vendedor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b04805b7787ec25c073ca1bf9f4bfa359e0435d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendedor_Index), @"mvc.1.0.view", @"/Views/Vendedor/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendedor/Index.cshtml", typeof(AspNetCore.Views_Vendedor_Index))]
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
#line 1 "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\_ViewImports.cshtml"
using SistemaVendasAspNetCore;

#line default
#line hidden
#line 2 "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\_ViewImports.cshtml"
using SistemaVendasAspNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b04805b7787ec25c073ca1bf9f4bfa359e0435d", @"/Views/Vendedor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94a07b345e062074d715a4d42b5cc3b194252ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendedor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 480, true);
            WriteLiteral(@"<h3>Lista de Vendedores</h3>
<br />
<button class=""btn btn-block btn-default"" type=""button"" onclick=""Voltar()"">Voltar</button>
<button class=""btn btn-block btn-primary"" type=""button"" onclick=""Cadastrar()"">Cadastrar Vendedor</button>
<br />
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th></th>
            <th></th>
            <th>Id</th>
            <th>Nome</th>
            <th>Email</th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 18 "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\Vendedor\Index.cshtml"
          
            foreach (var item in (List<VendedorModel>)ViewBag.ListaVendedores)
            {

#line default
#line hidden
            BeginContext(587, 91, true);
            WriteLiteral("                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 678, "\"", 704, 3);
            WriteAttributeValue("", 688, "Editar(", 688, 7, true);
#line 22 "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\Vendedor\Index.cshtml"
WriteAttributeValue("", 695, item.Id, 695, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 703, ")", 703, 1, true);
            EndWriteAttribute();
            BeginContext(705, 91, true);
            WriteLiteral(">Editar</button></td>\r\n                    <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 796, "\"", 823, 3);
            WriteAttributeValue("", 806, "Excluir(", 806, 8, true);
#line 23 "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\Vendedor\Index.cshtml"
WriteAttributeValue("", 814, item.Id, 814, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 822, ")", 822, 1, true);
            EndWriteAttribute();
            BeginContext(824, 48, true);
            WriteLiteral(">Excluir</button></td>\r\n                    <td>");
            EndContext();
            BeginContext(873, 7, false);
#line 24 "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\Vendedor\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(880, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(912, 9, false);
#line 25 "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\Vendedor\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(921, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(953, 10, false);
#line 26 "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\Vendedor\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(963, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\jacol\source\repos\SistemaVendasAspNetCore\Views\Vendedor\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1019, 411, true);
            WriteLiteral(@"    </tbody>
</table>

<script>
    function Cadastrar() {
        window.location.href = ""../Vendedor/Cadastro"";
    }
    function Editar(id) {
        window.location.href = ""../Vendedor/Cadastro/"" + id;
    }
    function Excluir(id) {
        window.location.href = ""../Vendedor/Excluir/"" + id;
    }
    function Voltar() {
        window.location.href = '../../Home/Menu';
    }
</script>");
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
