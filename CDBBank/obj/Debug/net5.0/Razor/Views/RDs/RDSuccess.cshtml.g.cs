#pragma checksum "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cea2be77df939d385bc3133b1d8975503fe97da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RDs_RDSuccess), @"mvc.1.0.view", @"/Views/RDs/RDSuccess.cshtml")]
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
#line 1 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\_ViewImports.cshtml"
using CDBBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\_ViewImports.cshtml"
using CDBBank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cea2be77df939d385bc3133b1d8975503fe97da", @"/Views/RDs/RDSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d99cad54a5d81f7efa1558f538fd97f1ee9397", @"/Views/_ViewImports.cshtml")]
    public class Views_RDs_RDSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml"
  
    ViewData["Title"] = "RDSuccess";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cea2be77df939d385bc3133b1d8975503fe97da3422", async() => {
                WriteLiteral(@"
    <title>Recurring Deposit</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>

    <!--Google Icons-->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">

    <style>
        .jumbotron {
            background-color: #e0b0ff; /*Mauve*/
            color: #ffffff;
        }

        .bg-grey {
            background-color: #f6f6f6;
        }

        .container-fluid {
            padding: 60px 50px;
        }

        .carousel-control.right, .carousel-control.left {
            background-image: none;
            color: #e0b0ff;
        }

        .carousel-indicators li {
            borde");
                WriteLiteral(@"r-color: #e0b0ff;
        }

            .carousel-indicators li.active {
                background-color: #e0b0ff;
            }

        .item h4 {
            font-size: 19px;
            line-height: 1.375em;
            font-weight: 400;
            font-style: italic;
            margin: 70px 0;
        }

        .item span {
            font-style: normal;
        }

        .panel {
            border: 1px solid #e0b0ff;
            border-radius: 0 !important;
            transition: box-shadow 0.5s;
        }

            .panel:hover {
                box-shadow: 5px 0px 40px rgba(0,0,0, .2);
            }

        .panel-footer .btn:hover {
            border: 1px solid #f4511e;
            background-color: #fff !important;
            color: #f4511e;
        }

        .panel-heading {
            color: #fff !important;
            background-color: #dda0dd !important;
            padding: 25px;
            border-bottom: 1px solid transparent;
        ");
                WriteLiteral(@"    border-top-left-radius: 0px;
            border-top-right-radius: 0px;
            border-bottom-left-radius: 0px;
            border-bottom-right-radius: 0px;
        }
    </style>

    <meta name=""viewport"" content=""width=device-width"" />
    <script type=""text/javascript"" src=""https://canvasjs.com/assets/script/canvasjs.min.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cea2be77df939d385bc3133b1d8975503fe97da6890", async() => {
                WriteLiteral(@"
    <!-- Container (Portfolio Section) -->
    <div class=""container-fluid text-center bg-grey"">
        <div id=""myCarousel"" class=""carousel slide text-center"" data-ride=""carousel"">
            <!-- Indicators -->
            <ol class=""carousel-indicators"">
                <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class=""carousel-inner"" role=""listbox"">
                <div class=""item active"">
                    <h4><strong>Congrats!!!</strong><br /> Recurring Deposit has been created  </h4>
                </div>
                <div class=""item"">
                    <h4>
                        <strong>Congrats!!!</strong>
                        Your RD Invest amount is Rs.");
#nullable restore
#line 106 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml"
                                               Write(ViewBag.PrincipleAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                        Maturity Amount will be Rs. ");
#nullable restore
#line 107 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml"
                                               Write(ViewBag.MaturityAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                        After ");
#nullable restore
#line 108 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml"
                         Write(ViewBag.RateOfInterest);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Months On ");
#nullable restore
#line 108 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml"
                                                           Write(ViewBag.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                        Interest will be RS. ");
#nullable restore
#line 109 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml"
                                        Write(ViewBag.InterestAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        at rate of interest ");
#nullable restore
#line 110 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml"
                                       Write(ViewBag.RateOfInterest);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" (%)
                    </h4>
                </div>

            </div>

            <!-- Left and right controls -->
            <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
    <hr />
    <div class=""row text-center"">
        <div class=""col-md-9"" id=""results-wrapper"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Months</th>
                        <th> Monthly Deposit(&#8377;)</th>
                        <th>Interest Earned (&");
                WriteLiteral("#8377;)</th>\r\n                        <th>Closing Balance (&#8377;)</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n                    <tr>\r\n                        <td> ");
#nullable restore
#line 141 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml"
                        Write(ViewBag.time);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 142 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml"
                        Write(ViewBag.PrincipleAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 143 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml"
                        Write(ViewBag.InterestAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 144 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDSuccess.cshtml"
                        Write(ViewBag.MaturityAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <div class=""col-sm-12"">
        <div class=""social-share-buttons"">
            <i class=""material-icons"" style=""font-size:14px;color:blue;"">share</i>
            <span class=""social-btn share-text""><strong>Share on</strong></span>
            <span class=""social-btn facebook-btn"">
                <i class=""material-icons"" style=""font-size:14px;color:blue;"">facebook</i>
                <a href=""http://www.facebook.com/sharer.php?u=https://fd-calculator.in"" target=""_blank"">Facebook</a>
            </span>
        </div>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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