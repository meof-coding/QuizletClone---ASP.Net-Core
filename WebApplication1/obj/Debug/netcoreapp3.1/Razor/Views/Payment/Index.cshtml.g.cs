#pragma checksum "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63771ab25d962f3e45192a5b1c2e8074204fdeeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
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
#line 1 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63771ab25d962f3e45192a5b1c2e8074204fdeeb", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bill>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/chip.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/visa.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "amount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
  
    ViewData["Title"] = "Payment";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .containerform{
    min-height: 100vh;
    display: flex;
    align-items: center;
    justify-content: center;
    flex-flow: column;
    padding-bottom: 60px;
}
.containerform form{
    background: #fff;
    border-radius: 5px;
    box-shadow: 0 10px 15px rgba(0,0,0,.1);
    padding: 20px;
    width: 600px;
    padding-top: 160px;
}
.container form .inputBox{
    margin-top: 20px;
}

.container form .inputBox span{
    display: block;
    color:#999;
    padding-bottom: 5px;
}
.submit-btn{
    width: 100%;
    background:linear-gradient(45deg, blueviolet, deeppink);
    margin-top: 20px;
    padding: 10px;
    font-size: 20px;
    color:#fff;
    border-radius: 10px;
    cursor: pointer;
    transition: .2s linear;
    border:none;
}
.pay-btn{
    width: 100%;
    background:linear-gradient(173deg, #3e4eaa, #14aaff);
    margin-top: 20px;
    padding: 10px;
    font-size: 20px;
    color:#fff;
    border-radius: 10px;
    cursor: pointer;
    transi");
            WriteLiteral(@"tion: .2s linear;
    border:none;
}
.submit-btn:hover{
    letter-spacing: 2px;
    opacity: .8;
}
.pay-btn:hover{
    letter-spacing: 2px;
    opacity: .8;
}
.mycard-container{
    margin-bottom: -150px;
    position: relative;
    height: 250px;
    width: 400px;
}
.mycard-container .front{
    position: absolute;
    height: 100%;
    width: 100%;
    top: 0; left: 0;
    background:linear-gradient(45deg, #7c12de, #ffca14);
    border-radius: 5px;
    backface-visibility: hidden;
    box-shadow: 0 15px 25px rgba(0,0,0,.2);
    padding:20px;
    transform:perspective(1000px) rotateY(0deg);
    transition:transform .4s ease-out;
}
.mycard-container .front .image{
    display: flex;
    align-items:center;
    justify-content: space-between;
    padding-top: 10px;
}
.image img{
    height: 50px;
}
.card-number-box{
    padding:30px 0;
    font-size: 22px;
    color:#fff;
}
.front .flexbox{
    display: flex;
}
.front .flexbox .box:nth-child(1){
    margin-right");
            WriteLiteral(": auto;\r\n}\r\n.front .flexbox .box{\r\n    font-size: 15px;\r\n    color:#fff;\r\n}\r\n</style>\r\n\r\n<div class=\"containerform\">\r\n   <div class=\"mycard-container\">\r\n\r\n        <div class=\"front\">\r\n            <div class=\"image\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63771ab25d962f3e45192a5b1c2e8074204fdeeb7543", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63771ab25d962f3e45192a5b1c2e8074204fdeeb8673", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-number-box\">################</div>\r\n            <div class=\"flexbox\">\r\n                <div class=\"box\">\r\n                    <span>card holder: <span class=\"text-warning\">");
#nullable restore
#line 119 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
                                                             Write(TempData.Peek("username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <div class=\"card-holder-name\">Amount to Pay: <span class=\"text-warning\">");
#nullable restore
#line 120 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
                                                                                       Write(Model.Amount.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" USD</span></div>
                </div>
                <div class=""box"">
                    <span>expires</span>
                    <div class=""expiration"">
                        <span class=""exp-month"">mm</span>
                        <span class=""exp-year"">yy</span>
                    </div>
                </div>
            </div>
        </div>

    </div>
");
#nullable restore
#line 133 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
     using (Html.BeginForm("Index", "Payment", FormMethod.Post)){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class = \"inputBox\">\r\n");
#nullable restore
#line 135 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
             if (ViewBag.Success!=null)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-primary\" role=\"alert\">\r\n              <strong>OTP</strong>  ");
#nullable restore
#line 138 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
                               Write(ViewBag.Success);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\n");
#nullable restore
#line 140 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            <span>\r\n               Enter your Phone number to get the OTP\r\n            </span>\r\n             ");
#nullable restore
#line 145 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
        Write(Html.TextBox("phonenumber", "", new { @style = "color:#444;width:100%;padding: 10px;border-radius: 10px;border:1px solid rgba(0,0,0,.3);",@id = "myInput", @maxlength = "10", @oninput = "myFunction()", @autocomplete = "off", @class = "card-number-input"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             <div class=\"alert alert-danger mt-3\" role=\"alert\" style=\"display:none;width:100%\">\r\n                 Invalid phone number, please try again!!\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63771ab25d962f3e45192a5b1c2e8074204fdeeb13231", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 149 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Amount);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
                                                                 WriteLiteral(Model.Amount.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 150 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
                 if (ViewBag.Success==null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" value=\"submit\" class=\"submit-btn\">\r\n");
#nullable restore
#line 152 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
                 }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <button id=\"rzp-button1\" class=\"pay-btn\">Pay</button>\r\n");
#nullable restore
#line 154 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 156 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //Verify Input
        let pattern = /^[0-9]{10}$/g;
        function myFunction() {
            var x = document.getElementById(""myInput"");
            console.log(x.value);
            x.value = x.value.replace(/[\D]/g, '').replace(/(\..*?)\..*/g, '$1');
        }
         $("".submit-btn"").click(function (e) {
        if (!pattern.test(document.getElementById(""myInput"").value)) {
             $("".alert-danger"").css(""display"", ""inline-block"");
               e.preventDefault();
             }
          });

    </script>
<script src=""https://checkout.razorpay.com/v1/checkout.js""></script>
<script>
var options = {
    ""key"": """);
#nullable restore
#line 179 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
       Write(ViewBag.Key);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", // Enter the Key ID generated from the Dashboard\r\n    \"amount\": \"3599\", // Amount is in currency subunits. Default currency is INR. Hence, 50000 refers to 50000 paise\r\n    \"currency\": \"USD\",\r\n    \"name\": \"Quizlet Clone\",\r\n    \"description\": \"");
#nullable restore
#line 183 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n    \"image\": \"https://cdn.razorpay.com/logos/IOiU2VCQv7Gc5E_medium.png\",\r\n    \"order_id\": \"");
#nullable restore
#line 185 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
            Write(Model.OrderId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""", //This is a sample Order ID. Pass the `id` obtained in the response of Step 1
    ""handler"": function (response){
        alert(response.razorpay_payment_id);
        alert(response.razorpay_order_id);
        alert(response.razorpay_signature)
    },
    ""prefill"": {
        ""name"": """);
#nullable restore
#line 192 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
            Write(TempData.Peek("username"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n        \"email\": \"");
#nullable restore
#line 193 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
             Write(TempData.Peek("userEmail"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n        \"contact\": \"");
#nullable restore
#line 194 "C:\Users\Macbook Pro\source\repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Payment\Index.cshtml"
               Write(ViewBag.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
    },
    ""notes"": {
        ""address"": ""Razorpay Corporate Office""
    },
    ""theme"": {
        ""color"": ""#516cf0""
    }
};
var rzp1 = new Razorpay(options);
rzp1.on('payment.failed', function (response){
        alert(""response.error.code""  response.error.code);
        alert(""response.error.description"" response.error.description);
        alert(""response.error.source"" + response.error.source);
        alert(""response.error.step"" + response.error.step);
        alert(""response.error.reason"" + response.error.reason);
        alert(""response.error.metadata.order_id"" + response.error.metadata.order_id);
        alert(""response.error.metadata.payment_id"" + response.error.metadata.payment_id);
});
document.getElementById('rzp-button1').onclick = function(e){
    rzp1.open();
    e.preventDefault();
}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bill> Html { get; private set; }
    }
}
#pragma warning restore 1591