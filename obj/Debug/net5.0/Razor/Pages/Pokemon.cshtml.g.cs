#pragma checksum "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91fbe495e4b765de037b257a46be2257ebe61d8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Pokedex.Pages.Pages_Pokemon), @"mvc.1.0.razor-page", @"/Pages/Pokemon.cshtml")]
namespace Pokedex.Pages
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
#line 1 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\_ViewImports.cshtml"
using Pokedex;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91fbe495e4b765de037b257a46be2257ebe61d8c", @"/Pages/Pokemon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b26cfe8b91895f312e7a0bf7526294a9c39538", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pokemon : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-outline-dark float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Pokemon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-outline-dark float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container pb-5\">\n    <div class=\"row\">\n        <div class=\"col text-center\">\n            <h1 class=\"fw-light mt-5 mb-5\">\n");
#nullable restore
#line 11 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                 if (Model.Anterior !=null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91fbe495e4b765de037b257a46be2257ebe61d8c4821", async() => {
                WriteLiteral("\n                        Nº ");
#nullable restore
#line 14 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                      Write(Model.Anterior.Numero.ToString("000"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                                                             Write(Model.Anterior.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-numero", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                                                                                                WriteLiteral(Model.Anterior.Numero);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numero"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-numero", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numero"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 16 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <strong>");
#nullable restore
#line 17 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                   Write(Model.Pokemon.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Nº ");
#nullable restore
#line 17 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                                            Write(Model.Pokemon.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>\n");
#nullable restore
#line 18 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                 if (Model.Proximo !=null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91fbe495e4b765de037b257a46be2257ebe61d8c8708", async() => {
                WriteLiteral("\n                        Nº ");
#nullable restore
#line 21 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                      Write(Model.Proximo.Numero.ToString("000"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                                                            Write(Model.Proximo.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-numero", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                                                                                                 WriteLiteral(Model.Proximo.Numero);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numero"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-numero", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["numero"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   \n");
#nullable restore
#line 23 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </h1>\n        </div>\n    </div>\n    <div class=\"row\">\n        <div class=\"col-lg-6\">\n            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1089, "\"", 1129, 1);
#nullable restore
#line 29 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
WriteAttributeValue("", 1095, Url.Content(Model.Pokemon.Imagem), 1095, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1130, "\"", 1155, 1);
#nullable restore
#line 29 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
WriteAttributeValue("", 1136, Model.Pokemon.Nome, 1136, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        </div>\n        <div class=\"col-lg-6\">\n            <label class=\"titulo w-25\">Altura</label><label>");
#nullable restore
#line 32 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                                                       Write(Model.Pokemon.Altura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n            <hr>\n            <label class=\"titulo w-25\">Peso</label><label>");
#nullable restore
#line 34 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                                                     Write(Model.Pokemon.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n            <hr>\n\n            <div class=\"tipo mt-2\">\n                <label class=\"titulo w-25\">Tipo</label>\n");
#nullable restore
#line 39 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                 foreach (var tipo in Model.Pokemon.Tipo)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91fbe495e4b765de037b257a46be2257ebe61d8c13791", async() => {
#nullable restore
#line 41 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                                                                                          Write(tipo);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Tipo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                                              WriteLiteral(tipo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Tipo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Tipo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Tipo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1655, "btn", 1655, 3, true);
            AddHtmlAttributeValue(" ", 1658, "btn-sm", 1659, 7, true);
            AddHtmlAttributeValue(" ", 1665, "tipo-", 1666, 6, true);
#nullable restore
#line 41 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
AddHtmlAttributeValue("", 1671, tipo, 1671, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 42 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            <hr>\n            <div class=\"tipo mt-2\">\n                <label class=\"titulo w-25\">Fraqueza</label>\n");
#nullable restore
#line 47 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                 foreach (var fraqueza in Model.Pokemon.Fraqueza)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91fbe495e4b765de037b257a46be2257ebe61d8c17444", async() => {
#nullable restore
#line 49 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                                                                                                      Write(fraqueza);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Fraqueza", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                                                  WriteLiteral(fraqueza);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Fraqueza"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Fraqueza", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Fraqueza"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2002, "btn", 2002, 3, true);
            AddHtmlAttributeValue(" ", 2005, "btn-sm", 2006, 7, true);
            AddHtmlAttributeValue(" ", 2012, "tipo-", 2013, 6, true);
#nullable restore
#line 49 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
AddHtmlAttributeValue("", 2018, fraqueza, 2018, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 50 "C:\Users\everton.souza\source\Pokedex\Pokedex-main\Pages\Pokemon.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            <hr>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pokedex.Pages.PokemonModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pokedex.Pages.PokemonModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pokedex.Pages.PokemonModel>)PageContext?.ViewData;
        public Pokedex.Pages.PokemonModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591