#pragma checksum "F:\Dev\Projects\[C#,ASPNET] Repertoire-Client\RepertoireClient\Views\RepertoireClient\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d28026c0653758a35cf87d0b32398070136ef34b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RepertoireClient_Index), @"mvc.1.0.view", @"/Views/RepertoireClient/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RepertoireClient/Index.cshtml", typeof(AspNetCore.Views_RepertoireClient_Index))]
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
#line 1 "F:\Dev\Projects\[C#,ASPNET] Repertoire-Client\RepertoireClient\Views\_ViewImports.cshtml"
using RepertoireClient;

#line default
#line hidden
#line 2 "F:\Dev\Projects\[C#,ASPNET] Repertoire-Client\RepertoireClient\Views\_ViewImports.cshtml"
using RepertoireClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d28026c0653758a35cf87d0b32398070136ef34b", @"/Views/RepertoireClient/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff6646c96b0305870df4aa42702dbe1b70f502ea", @"/Views/_ViewImports.cshtml")]
    public class Views_RepertoireClient_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\Dev\Projects\[C#,ASPNET] Repertoire-Client\RepertoireClient\Views\RepertoireClient\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.RepertoireClient.cshtml";
    ViewBag.Title = "Home Page";

#line default
#line hidden
            BeginContext(105, 353, true);
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1>Répertoire client</h1>
    <p class=""lead"">Répertorie tous les clients de Gefco Strasbourg</p>
</div>

<div class=""row"">
    <div class=""col-md-6"">
        <h2>Paramètres</h2>
        <p>
            Renseigner le document source :
        </p>
        <div class=""btn"" ondrop=""alert('e')""><input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 458, "\"", 481, 1);
#line 17 "F:\Dev\Projects\[C#,ASPNET] Repertoire-Client\RepertoireClient\Views\RepertoireClient\Index.cshtml"
WriteAttributeValue("", 466, Model.Document, 466, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(482, 413, true);
            WriteLiteral(@" /><input type=""button"" class=""btn btn-default"" value=""&raquo;"" /></div>
    </div>
    <div class=""col-md-6"">
        <h2>Web Hosting</h2>
        <p>You can easily find a web hosting company that offers the right mix of features and price for your applications.</p>
        <p><a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkId=301867"">Learn more &raquo;</a></p>
    </div>
</div>
");
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
