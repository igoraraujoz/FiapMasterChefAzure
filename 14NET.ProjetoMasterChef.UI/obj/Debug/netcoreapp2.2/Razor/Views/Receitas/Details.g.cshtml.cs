#pragma checksum "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c062afb54c653f5f5db7d8494401acf59774fb6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receitas_Details), @"mvc.1.0.view", @"/Views/Receitas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receitas/Details.cshtml", typeof(AspNetCore.Views_Receitas_Details))]
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
#line 1 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\_ViewImports.cshtml"
using _14NET.ProjetoMasterChef;

#line default
#line hidden
#line 2 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\_ViewImports.cshtml"
using _14NET.ProjetoMasterChef.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c062afb54c653f5f5db7d8494401acf59774fb6f", @"/Views/Receitas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d72c629891d30d2feb5f5e8070f2cbea7847da0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Receitas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_14NET.ProjetoMasterChef.Application.ViewModels.ReceitaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Sample Image222"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(165, 86, true);
            WriteLiteral("<div>\r\n    <h4>Receita</h4>\r\n    <hr />\r\n\r\n    <div style=\"padding:10px;\">\r\n\r\n        ");
            EndContext();
            BeginContext(251, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c062afb54c653f5f5db7d8494401acf59774fb6f5281", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 261, "~/Site_Images/", 261, 14, true);
#line 13 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml"
AddHtmlAttributeValue("", 275, Url.Content(Model.FotoURL), 275, 27, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(342, 81, true);
            WriteLiteral("\r\n\r\n    </div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(424, 42, false);
#line 18 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(466, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(528, 38, false);
#line 21 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(566, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(627, 48, false);
#line 24 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ingredientes));

#line default
#line hidden
            EndContext();
            BeginContext(675, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(737, 44, false);
#line 27 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ingredientes));

#line default
#line hidden
            EndContext();
            BeginContext(781, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(842, 47, false);
#line 30 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModoPreparo));

#line default
#line hidden
            EndContext();
            BeginContext(889, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(951, 43, false);
#line 33 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModoPreparo));

#line default
#line hidden
            EndContext();
            BeginContext(994, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1055, 40, false);
#line 36 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1157, 36, false);
#line 39 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1240, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c062afb54c653f5f5db7d8494401acf59774fb6f10793", async() => {
                BeginContext(1286, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Pessoal\FIAP\Trabalhos\Azure\14NET.ProjetoMasterChef\14NET.ProjetoMasterChef.UI\Views\Receitas\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1296, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1304, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c062afb54c653f5f5db7d8494401acf59774fb6f13150", async() => {
                BeginContext(1326, 32, true);
                WriteLiteral("Voltar para a lista de receitas!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1362, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_14NET.ProjetoMasterChef.Application.ViewModels.ReceitaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
