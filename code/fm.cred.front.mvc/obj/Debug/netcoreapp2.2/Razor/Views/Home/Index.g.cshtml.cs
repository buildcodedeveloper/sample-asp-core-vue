#pragma checksum "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db08907a1d7fe9b182acdb28816d9fbf61db55b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\_ViewImports.cshtml"
using fm.cred.front.mvc;

#line default
#line hidden
#line 2 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\_ViewImports.cshtml"
using fm.cred.front.mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db08907a1d7fe9b182acdb28816d9fbf61db55b8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"750c0f4d03b4408cafe3daa269ef14e6bf68eb4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<fm.cred.front.mvc.Models.ConfiguracaoGeralVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
      
    ViewData["Title"] = "Home Page";
    

#line default
#line hidden
            BeginContext(122, 232, true);
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome</h1>\r\n        <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 13 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
          var price=25;

#line default
#line hidden
            BeginContext(380, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 14 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
         foreach (var config in Model.OrderBy(c => c.VlOrdem))
        {
            var tipoHtml = config.TipoCampo.TipoCampoHtml;

#line default
#line hidden
            BeginContext(515, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 527, "\"", 552, 1);
#line 17 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 535, config.Class_Css, 535, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(553, 24, true);
            WriteLiteral(">\r\n\r\n            <label>");
            EndContext();
            BeginContext(578, 14, false);
#line 19 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
              Write(config.NoCampo);

#line default
#line hidden
            EndContext();
            BeginContext(592, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 20 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
             if(tipoHtml.Equals(TipoCampoHtml.TEXT)){

#line default
#line hidden
            BeginContext(657, 18, true);
            WriteLiteral("            <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 675, "\"", 711, 1);
#line 21 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 682, config.TipoCampo.DsTipoCampo, 682, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(712, 21, true);
            WriteLiteral(" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("asp-is-disabled", "\r\n                asp-is-disabled=\"", 733, "\"", 783, 1);
#line 22 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 768, config.FlAtivo, 768, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(784, 11, true);
            WriteLiteral("></input>\r\n");
            EndContext();
#line 23 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
            }
             else if(tipoHtml.Equals(TipoCampoHtml.RADIO) | tipoHtml.Equals(TipoCampoHtml.CHECKBOX) |
                 tipoHtml.Equals(TipoCampoHtml.SELECT))
                 {
                     

#line default
#line hidden
#line 27 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                      if(tipoHtml.Equals(TipoCampoHtml.SELECT)){

#line default
#line hidden
            BeginContext(1056, 43, true);
            WriteLiteral("                        <!-- <select name=\"");
            EndContext();
            BeginContext(1100, 28, false);
#line 28 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                                      Write(config.TipoCampo.DsTipoCampo);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 40, true);
            WriteLiteral("\" class=\"form-control\" asp-is-disabled=\"");
            EndContext();
            BeginContext(1169, 14, false);
#line 28 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                                                                                                           Write(config.FlAtivo);

#line default
#line hidden
            EndContext();
            BeginContext(1183, 8, true);
            WriteLiteral("\"> -->\r\n");
            EndContext();
#line 29 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                         foreach (var option in config.OptionConfig.OrderBy(o => o.Order))
                        {

#line default
#line hidden
            BeginContext(1310, 48, true);
            WriteLiteral("                            <!-- <option value=\"");
            EndContext();
            BeginContext(1359, 9, false);
#line 31 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                                           Write(option.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1368, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1371, 11, false);
#line 31 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                                                       Write(option.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1382, 74, true);
            WriteLiteral("</option> -->\r\n                            <!-- <input type=\"radio\" name=\"");
            EndContext();
            BeginContext(1457, 28, false);
#line 32 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                                                      Write(config.TipoCampo.DsTipoCampo);

#line default
#line hidden
            EndContext();
            BeginContext(1485, 6, true);
            WriteLiteral("\" id=\"");
            EndContext();
            BeginContext(1492, 9, false);
#line 32 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                                                                                         Write(option.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1501, 9, true);
            WriteLiteral("\" value=\"");
            EndContext();
            BeginContext(1511, 9, false);
#line 32 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                                                                                                            Write(option.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1520, 61, true);
            WriteLiteral("\" /> -->\r\n                             <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("checked", " checked=\'", 1581, "\'", 1625, 1);
#line 33 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 1591, option.Checked ? "checked" : "", 1591, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1626, "\"", 1662, 1);
#line 33 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 1633, config.TipoCampo.DsTipoCampo, 1633, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1663, "\"", 1697, 1);
#line 33 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 1668, config.TipoCampo.DsTipoCampo, 1668, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1698, 6, true);
            WriteLiteral("  />\r\n");
            EndContext();
            BeginContext(1706, 35, true);
            WriteLiteral("                            <label>");
            EndContext();
            BeginContext(1742, 11, false);
#line 35 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                              Write(option.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1753, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 36 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1790, 44, true);
            WriteLiteral("                        <!-- </select> -->\r\n");
            EndContext();
#line 38 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                     } else if(tipoHtml.Equals(TipoCampoHtml.RADIO)) {
                          

#line default
#line hidden
#line 39 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                           foreach (var option in config.OptionConfig.OrderBy(o => o.Order))
                        {

#line default
#line hidden
            BeginContext(2027, 48, true);
            WriteLiteral("                             <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2075, "\"", 2111, 1);
#line 41 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 2082, config.TipoCampo.DsTipoCampo, 2082, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2112, "\"", 2127, 1);
#line 41 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 2117, option.Id, 2117, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2128, "\"", 2146, 1);
#line 41 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 2136, option.Id, 2136, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2147, 40, true);
            WriteLiteral(" />\r\n                            <label>");
            EndContext();
            BeginContext(2188, 11, false);
#line 42 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                              Write(option.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2199, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 43 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#line 43 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                         
                         
                     }

                     else if(tipoHtml.Equals(TipoCampoHtml.CHECKBOX)) {
                           

#line default
#line hidden
#line 48 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                            foreach (var option in config.OptionConfig.OrderBy(o => o.Order))
                        {

#line default
#line hidden
            BeginContext(2484, 51, true);
            WriteLiteral("                             <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2535, "\"", 2571, 1);
#line 50 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 2542, config.TipoCampo.DsTipoCampo, 2542, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2572, "\"", 2606, 1);
#line 50 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 2577, config.TipoCampo.DsTipoCampo, 2577, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2607, 41, true);
            WriteLiteral("  />\r\n                            <label>");
            EndContext();
            BeginContext(2649, 11, false);
#line 51 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                              Write(option.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2660, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 52 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#line 52 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                         
                     }

#line default
#line hidden
#line 53 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"
                      
                    
            }           

#line default
#line hidden
            BeginContext(2769, 20, true);
            WriteLiteral("\r\n\r\n        </div>\r\n");
            EndContext();
#line 59 "d:\data\www\private\Fazendo Mais\private\web-dev\asp-net-core\core\fm-cred-front-mvc\code\fm.cred.front.mvc\Views\Home\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(2802, 12, true);
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<fm.cred.front.mvc.Models.ConfiguracaoGeralVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
