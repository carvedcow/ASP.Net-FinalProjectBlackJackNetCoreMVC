#pragma checksum "C:\Users\Johnny\source\repos\BlackJackFinalProjectNetCoreMVC\Views\BlackJack\BlackJackBet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cda7a6659af850929226b55333666e6d07cdf56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BlackJack_BlackJackBet), @"mvc.1.0.view", @"/Views/BlackJack/BlackJackBet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BlackJack/BlackJackBet.cshtml", typeof(AspNetCore.Views_BlackJack_BlackJackBet))]
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
#line 1 "C:\Users\Johnny\source\repos\BlackJackFinalProjectNetCoreMVC\Views\_ViewImports.cshtml"
using BlackJackFinalProjectNetCoreMVC;

#line default
#line hidden
#line 2 "C:\Users\Johnny\source\repos\BlackJackFinalProjectNetCoreMVC\Views\_ViewImports.cshtml"
using BlackJackFinalProjectNetCoreMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cda7a6659af850929226b55333666e6d07cdf56", @"/Views/BlackJack/BlackJackBet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e150ba9c7591464960d1c084afecd8f0bbe4aa0", @"/Views/_ViewImports.cshtml")]
    public class Views_BlackJack_BlackJackBet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Johnny\source\repos\BlackJackFinalProjectNetCoreMVC\Views\BlackJack\BlackJackBet.cshtml"
  
    ViewData["Title"] = "BlackJack";

#line default
#line hidden
            BeginContext(45, 67, true);
            WriteLiteral("\r\n<h2>BlackJack Betting Page</h2>\r\n<hr />\r\n\r\n<!-- Message -->\r\n<h3>");
            EndContext();
            BeginContext(113, 19, false);
#line 9 "C:\Users\Johnny\source\repos\BlackJackFinalProjectNetCoreMVC\Views\BlackJack\BlackJackBet.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(132, 31, true);
            WriteLiteral("</h3>\r\n\r\n<!-- Button Form -->\r\n");
            EndContext();
            BeginContext(163, 646, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e002b444f5dc40a399f8e18d3b50c91d", async() => {
                BeginContext(183, 58, true);
                WriteLiteral("\r\n    <!-- Player\'s current money-->\r\n    Player\'s Money: ");
                EndContext();
                BeginContext(242, 18, false);
#line 14 "C:\Users\Johnny\source\repos\BlackJackFinalProjectNetCoreMVC\Views\BlackJack\BlackJackBet.cshtml"
               Write(Model.player.money);

#line default
#line hidden
                EndContext();
                BeginContext(260, 45, true);
                WriteLiteral("\r\n\r\n    <br />\r\n\r\n    <!-- Betting form -->\r\n");
                EndContext();
#line 19 "C:\Users\Johnny\source\repos\BlackJackFinalProjectNetCoreMVC\Views\BlackJack\BlackJackBet.cshtml"
     if (Model.player.money <= 0)
    {

#line default
#line hidden
                BeginContext(347, 107, true);
                WriteLiteral("        <button class=\"btn btn-success\" type=\"submit\" name=\"action\" value=\"startover\">Start Over</button>\r\n");
                EndContext();
#line 22 "C:\Users\Johnny\source\repos\BlackJackFinalProjectNetCoreMVC\Views\BlackJack\BlackJackBet.cshtml"
    }
    else
    { 

#line default
#line hidden
                BeginContext(479, 150, true);
                WriteLiteral("        <div id=\"betButtons\">\r\n            <label for=\"bet\">Player\'s Bet Amount:</label>\r\n            <input id=\"bet\" name=\"bet\" type=\"number\" min=\"1\"");
                EndContext();
                BeginWriteAttribute("max", " max=\"", 629, "\"", 654, 1);
#line 27 "C:\Users\Johnny\source\repos\BlackJackFinalProjectNetCoreMVC\Views\BlackJack\BlackJackBet.cshtml"
WriteAttributeValue("", 635, Model.player.money, 635, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(655, 128, true);
                WriteLiteral(" required />\r\n            <button class=\"btn btn-success\" type=\"submit\" name=\"action\" value=\"bet\">Bet</button>\r\n        </div>\r\n");
                EndContext();
#line 30 "C:\Users\Johnny\source\repos\BlackJackFinalProjectNetCoreMVC\Views\BlackJack\BlackJackBet.cshtml"
    }

#line default
#line hidden
                BeginContext(790, 12, true);
                WriteLiteral("    \r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(809, 2, true);
            WriteLiteral("\r\n");
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