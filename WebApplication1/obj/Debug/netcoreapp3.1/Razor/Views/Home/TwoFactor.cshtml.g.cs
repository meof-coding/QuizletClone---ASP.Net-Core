#pragma checksum "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Home\TwoFactor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68c42afa1c097bd8016b94719c632ff7cf1f3534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TwoFactor), @"mvc.1.0.view", @"/Views/Home/TwoFactor.cshtml")]
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
#line 1 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c42afa1c097bd8016b94719c632ff7cf1f3534", @"/Views/Home/TwoFactor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TwoFactor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/2FA.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Resend", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("py-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Home\TwoFactor.cshtml"
  
    ViewData["Title"] = "Email Verification";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #main-site {
        min-height: 100vh;
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .img-fluid {
        width: 80%;
        height: 80%;
    }

    .font-roboto {
        font-family: 'Roboto', sans-serif;
    }

    .font-poppins {
        font-family: 'Poppins', sans-serif;
    }

    .text-white {
        color: #efefef;
    }

    .text-light {
        color: #dee2e6;
    }

    .link {
        text-decoration: none;
        color: #fca311;
    }


    .glass {
        max-width: 550px;
        width: 100%;
        padding: 65px 90px 45px;
        background: rgba(255, 255, 255, 0.1);
        box-shadow: 10px 10px 80px rgba(0, 0, 0, 0.3);
        /* important property */
        backdrop-filter: blur(5px);
    }

        .glass .title h1 {
            font-size: 35px;
        }

        .glass form .form-control {
            width: 80px;
            padding: .3em .1em;
            font-siz");
            WriteLiteral(@"e: 25px;
            border-radius: 5px;
            text-align: center;
            font-family: 'Poppins', sans-serif;
        }

        .glass form .col .btn {
            width: 90%;
            padding: .6em .1em;
            font-family: 'Poppins', sans-serif;
            font-size: 20px;
            background-color: #fca311;
            color: #efefef;
            border: none;
        }

    input {
        margin: 0 10px;
    }
</style>
<section id=""main-site"">
    <div class=""glass text-center"">

        <!-- title -->
        <div class=""title"">
            <div class=""alert alert-success alert-dismissible fade show"" role=""alert"" style=""display:none"">
                Resend successfully!! Please check your mail again!
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <h1 class=""font-poppins text-white"">Two-Fa");
            WriteLiteral("ctor Authentication</h1>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "68c42afa1c097bd8016b94719c632ff7cf1f35348659", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <p class=\"font-poppins text-light\">A message with a verifycation code has been sent to your email.Enter the code to continue.</p>\r\n        </div>\r\n\r\n        <!-- form -->\r\n");
#nullable restore
#line 94 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Home\TwoFactor.cshtml"
         using (Html.BeginForm("TwoFactor", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68c42afa1c097bd8016b94719c632ff7cf1f353410360", async() => {
                WriteLiteral("\r\n                <h4 class=\"font-poppins text-light\">Enter your OTP Code Here:</h4>\r\n\r\n                <div class=\"col py-1 my-3 d-flex\" style=\"margin-left:-9%\">\r\n                    ");
#nullable restore
#line 100 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Home\TwoFactor.cshtml"
               Write(Html.TextBox("key", "", new { @id = "myInput", @maxlength = "1", @oninput = "myFunction()", @autocomplete = "off", @class = "form-control", @placeholder = "-" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 101 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Home\TwoFactor.cshtml"
               Write(Html.TextBox("key1", "", new { @id = "myInput", @maxlength = "1", @oninput = "myFunction()", @autocomplete = "off", @class = "form-control", @placeholder = "-" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 102 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Home\TwoFactor.cshtml"
               Write(Html.TextBox("key2", "", new { @id = "myInput", @maxlength = "1", @oninput = "myFunction()", @autocomplete = "off", @class = "form-control", @placeholder = "-" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 103 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Home\TwoFactor.cshtml"
               Write(Html.TextBox("key3", "", new { @id = "myInput", @maxlength = "1", @oninput = "myFunction()", @autocomplete = "off", @class = "form-control", @placeholder = "-" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 105 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Home\TwoFactor.cshtml"
                 if (ViewBag.Error != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"alert alert-warning\" role=\"alert\">\r\n                        ");
#nullable restore
#line 108 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Home\TwoFactor.cshtml"
                   Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 110 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Home\TwoFactor.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <div class=""col"">
                    <button type=""submit"" id=""button"" class=""btn"">Verify</button>
                </div>

                <div class=""py-1"">
                    <p class=""font-poppins text-light"">Not received your code? ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68c42afa1c097bd8016b94719c632ff7cf1f353413712", async() => {
                    WriteLiteral("Resend");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n                </div>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 121 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Home\TwoFactor.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //Verify Input
        function myFunction() {
            var x = document.getElementById(""myInput"");
            x.value = x.value.replace(/[\D]/g, '').replace(/(\..*?)\..*/g, '$1');
        }

        //Allow Redirect or reload if submit form
        document.getElementById('button').onclick = function () {
            window.onbeforeunload = null;
        };

        //Prevent redirect or reload if form DIDN'T submitted
        window.onbeforeunload = function () {
            return 'If you leave rightnow,the code for verivication is going to be expire. Are you sure you want to leave?';
        };

        //Resend Onclick
        $("".link"").click(function () {
            window.onbeforeunload = null;
            $("".alert-dismissible"").css(""display"", ""inline-block"");
        });
     //End check
    </script>
");
            }
            );
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
