#pragma checksum "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00b1bd4947536084aa531c1dc8e55ebea0930b3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flashcard_Users), @"mvc.1.0.view", @"/Views/Flashcard/Users.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00b1bd4947536084aa531c1dc8e55ebea0930b3d", @"/Views/Flashcard/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Flashcard_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-title h3 text-light text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Flashcard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-subtitle text-decoration-none h5 text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
  
    ViewData["Title"] = ViewBag.UserInfo.Username;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    input:focus {\r\n        outline: none;\r\n    }\r\n</style>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    //Preview Avatar goes here
    imgInp.onchange = evt => {
        const [file] = imgInp.files
        if (file) {
            blah.src = URL.createObjectURL(file)
        }
    }
    //Edit function
    function editfunction() {
        $("".editpart"").css(""display"", ""inline-block"");
        $("".showpro"").css(""display"", ""none"");
    }
    function cancel() {
        $("".editpart"").css(""display"", ""none"");
        $("".showpro"").css(""display"", ""inline-block"");
    }
    //Dangerzone
    function dangerzone() {
        $("".dangerzone"").css(""display"", ""inline-block"");
    }
    function cancel2() {
        $("".dangerzone"").css(""display"", ""none"");
    }
    //Avatar file goes here
    const url = ""https://api.cloudinary.com/v1_1/djhjuqgne/image/upload/?upload_preset=yfm96suk"";
    const form = document.querySelector(""#form"");

    form.addEventListener(""submit"", (e) => {
        e.preventDefault();

        const files = document.querySelector(""[type=file]"").files;
    ");
                WriteLiteral(@"    const formData = new FormData();

        for (let i = 0; i < files.length; i++) {
            let file = files[i];
            formData.append(""file"", file);
            formData.append(""upload_preset"", ""docs_upload_example_us_preset"");

            fetch(url, {
                method: ""POST"",
                body: formData
            })
                .then((response) => {
                    return response.text();
                })

                .then((data) => {
                    console.log(data)
                    const object = JSON.parse(data)
                    document.getElementById(""data"").value = object.url;
                });
        }
    });
</script>
");
            }
            );
            WriteLiteral(@"    <section class=""h-100 gradient-custom-2"">
        <div class=""container h-100"">
            <div class=""row d-flex justify-content-center align-items-center h-100"">
                <div class=""col col-lg-12 col-xl-12"">
                    <div class=""card"">
                        <div class=""rounded-top text-white d-flex flex-row"" style=""background: url('https://i.pinimg.com/564x/12/5b/42/125b423f6917dcbb4a0ce634c0cba5ca.jpg'); height: 250px; object-fit: cover "">
                            <div class=""ms-4 mx-2 d-flex flex-column  mt-5 pt-5"" style=""width: 200px;display:flex"">
                                
                                <img");
            BeginWriteAttribute("src", " src=\"", 2590, "\"", 2623, 1);
#nullable restore
#line 75 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
WriteAttributeValue("", 2596, ViewBag.UserInfo.AvatarUrl, 2596, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Generic placeholder image\" class=\"img-fluid img-thumbnail mt-4 mb-2\" style=\"width: 200px; z-index: 1\" id=\"blah\">\r\n");
#nullable restore
#line 76 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                 if (TempData.ContainsKey("username") && ViewBag.UserInfo.Id == int.Parse(TempData.Peek("uid").ToString()))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <button onclick=""editfunction()"" type=""submit"" class=""btn btn-outline-primary edit"" data-mdb-ripple-color=""dark"" style=""z-index: 1;"">
                                        Edit profile
                                    </button>
");
#nullable restore
#line 81 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"ms-3 mx-2 text-primary\" style=\"margin-top: 200px;\">\r\n                                <h1 class=\"font-weight-bold\">");
#nullable restore
#line 84 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                                        Write(ViewBag.UserInfo.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                            </div>
                        </div>
                        <div class=""p-4 text-black"" style=""background-color: #f8f9fa;"">
                            <div class=""d-flex justify-content-end text-center py-1"">
                                <div>
                                    <p class=""mb-1 h5"">");
#nullable restore
#line 90 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                                  Write(ViewBag.MySet.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <p class=""small text-muted mb-0"">Total Quizz Set</p>
                                </div>
                            </div>
                        </div>
                        <div class=""card-body p-4 text-black"">
                            <div class=""mb-5"">
                                <p class=""lead fw-normal mt-3 mb-1 font-weight-bold"">About</p>
                                <div class=""p-4 showpro"" style=""background-color: #f8f9fa;"">
                                    <p class=""font-italic mb-1"">
                                        <span class=""font-weight-bold"">Email contact</span>:");
#nullable restore
#line 100 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                                                                       Write(ViewBag.UserInfo.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <p class=\"font-italic mb-1\"><span class=\"font-weight-bold\">D.o.b </span>: ");
#nullable restore
#line 102 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                                                                                         Write(ViewBag.UserInfo.Dob.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <!--Edit part-->\r\n                                \r\n                                <div class=\"p-4 editpart mt-3\" style=\"background-color: #f8f9fa;display:none\">\r\n");
#nullable restore
#line 107 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                     using (Html.BeginForm("EditProfile", "Flashcard", FormMethod.Post))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <p class=""font-italic mb-1"">
                                            <i class=""fas fa-envelope fa-lg me-3 fa-fw""></i>
                                            <span class=""font-weight-bold"">Email contact</span>:
                                            ");
#nullable restore
#line 112 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                       Write(Html.TextBox("Email", $"{@ViewBag.UserInfo.Email}", new { @required = "required", @type = "text", @id = "form1", @class = "mt-3 h5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                        <p class=""font-italic mb-1"">
                                            <i class=""fas fa-birthday-cake fa-lg me-3 fa-fw""></i>
                                            <span class=""font-weight-bold"">D.o.b </span>:
                                            ");
#nullable restore
#line 117 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                       Write(Html.TextBox("Dob", $"{@ViewBag.UserInfo.Dob.ToString("MM/dd/yyyy")}", new { @required = "required", @type = "date", @class = "mt-3 h5", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <i class=\"fas fa-user-astronaut fa-lg me-3 fa-fw\"></i>\r\n                                        <span class=\"font-weight-bold\">Avatar: </span> ");
#nullable restore
#line 120 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                                                                  Write(Html.TextBox("AvatarUrl", null, new { @required = "required", @readonly = "readonly", @type = "text", @id = "data", @class = "form-control text-success mb-3", @placeholder = "Avatar Url goes here" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b1bd4947536084aa531c1dc8e55ebea0930b3d16121", async() => {
                WriteLiteral(@"
                                            <input accept=""image/*"" type='file' id=""imgInp"" placeholder=""Avatar Upload"" />
                                            <input type=""submit"" value=""Upload Files"" name=""submit"">
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <div style=""display:flex;align-items:center"" class=""mt-3"">
                                            <button onclick=""cancel()"" type=""button"" class=""btn btn-outline-warning mr-3"" data-mdb-ripple-color=""dark"" style=""z-index: 1;"">
                                                Cancel
                                            </button>
                                            <button type=""submit"" class=""btn btn-info mr-3"" data-mdb-ripple-color=""dark"" style=""z-index: 1;"">
                                                Submit
                                            </button>
                                        </div>
");
#nullable restore
#line 133 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <button onclick=""dangerzone()"" type=""button"" class=""btn btn-danger mt-5"" data-mdb-ripple-color=""dark"" style=""z-index: 1;"">
                                        Change Password
                                    </button>


                                    <div class=""p-4 dangerzone mt-3 text-danger"" style=""display:none"">
                                        <p class=""font-italic mb-1"">
                                            <span class=""font-weight-bold"">Old password</span>:
                                            ");
#nullable restore
#line 142 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                       Write(Html.TextBox("oldpassword", null, new { @required = "required", @class = "form-control password", @type = "password", @placeholder = "Password", @id = "form3Example4c" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                        <p class=""font-italic mb-1"">
                                            <span class=""font-weight-bold"">New Password</span>:
                                            ");
#nullable restore
#line 146 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                       Write(Html.TextBox("newpassword", null, new { @required = "required", @class = "form-control password", @type = "password", @placeholder = "Password", @id = "form3Example4c" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                        <button onclick=""cancel2()"" type=""button"" class=""btn btn-outline-warning mt-3"" data-mdb-ripple-color=""dark"" style=""z-index: 1;"">
                                            Cancel
                                        </button>
                                    </div>
                                </div>
                                
                                    <!--End edit-->
                                    <!--Setting zone-->

                                    <!--End setting-->
                                </div>
                            
                            <div class=""d-flex justify-content-between align-items-center mb-4"">
                                <p class=""lead fw-normal mb-0 font-weight-bold"">Set Quiz</p>
                            </div>
                            <div style=""display: grid; grid-template-columns: auto auto auto;"">
");
#nullable restore
#line 164 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                 foreach (var item in ViewBag.MySet)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""card mt-3 mx-1 text-light"" style=""width: 20rem; height: 11rem; cursor: pointer; background-color: #2a78b0"">
                                        <div class=""card-body"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b1bd4947536084aa531c1dc8e55ebea0930b3d22299", async() => {
#nullable restore
#line 168 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                                                                                                                                                            Write(item.Value.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 168 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                                                                                                                                     WriteLiteral(item.Value.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 169 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                             foreach (var item2 in ViewBag.TotalQuiz)
                                            {
                                                if (item2.Key == item.Value.Id)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <h6 class=\"card-subtitle mt-2 text-warning\">");
#nullable restore
#line 173 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                                                                           Write(item2.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" terms</h6>\r\n");
#nullable restore
#line 174 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"display: flex; align-items: center;\" class=\"mt-4 mb-3\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 10912, "\"", 10937, 1);
#nullable restore
#line 177 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
WriteAttributeValue("", 10918, item.Key.AvatarUrl, 10918, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:20%;height:20%\" />\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b1bd4947536084aa531c1dc8e55ebea0930b3d27099", async() => {
#nullable restore
#line 178 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                                                                                                                                                                Write(item.Key.Username);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 178 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                                                                                                                                           WriteLiteral(item.Key.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                            </span>\r\n\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 183 "C:\Users\trath\Source\Repos\QuizletClone---ASP.Net-Core\WebApplication1\Views\Flashcard\Users.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
