#pragma checksum "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9080d788d39972591fdfc12305310ff2e38c076f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RDs_RDCalculator), @"mvc.1.0.view", @"/Views/RDs/RDCalculator.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9080d788d39972591fdfc12305310ff2e38c076f", @"/Views/RDs/RDCalculator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d99cad54a5d81f7efa1558f538fd97f1ee9397", @"/Views/_ViewImports.cshtml")]
    public class Views_RDs_RDCalculator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
  
    ViewData["Title"] = "RDCalculator";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9080d788d39972591fdfc12305310ff2e38c076f3443", async() => {
                WriteLiteral(@"
    <title>Recurring Deposit Calculator</title>
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
          ");
                WriteLiteral(@"  border-color: #e0b0ff;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9080d788d39972591fdfc12305310ff2e38c076f6075", async() => {
                WriteLiteral(@"
    <!-- Container (Portfolio Section) -->
    <div class=""container-fluid text-center bg-grey"">
        <div id=""myCarousel"" class=""carousel slide text-center"" data-ride=""carousel"">
            <!-- Indicators -->
            <ol class=""carousel-indicators"">
                <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                <li data-target=""#myCarousel"" data-slide-to=""2""></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class=""carousel-inner"" role=""listbox"">
                <div class=""item active"">
                    <h4>Recurring Deposit </h4>
                    <p");
                BeginWriteAttribute("class", " class=\"", 2439, "\"", 2447, 0);
                EndWriteAttribute();
                WriteLiteral(@">This RD Calculator helps you calculate the maturity amount and interest earned for any <em>Recurring Deposit</em> account.</p>
                </div>
                <div class=""item"">
                    <h4>
                        Your RD Invest amount is Rs.");
#nullable restore
#line 78 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
                                               Write(ViewBag.PrincipleAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                        Maturity Amount will be Rs. ");
#nullable restore
#line 79 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
                                               Write(ViewBag.MaturityAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                        After ");
#nullable restore
#line 80 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
                         Write(ViewBag.RateOfInterest);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Months On ");
#nullable restore
#line 80 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
                                                           Write(ViewBag.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                        Interest will be RS. ");
#nullable restore
#line 81 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
                                        Write(ViewBag.InterestAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        at rate of interest ");
#nullable restore
#line 82 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
                                       Write(ViewBag.RateOfInterest);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" (%)
                    </h4>
                </div>
                <div class=""item"">
                    <h4>
                        <div class=""row text-center"">
                            <div class=""col-md-9"" id=""results-wrapper"">
                                <table class=""table table-striped"">
                                    <thead>
                                        <tr>
                                            <th>Months</th>
                                            <th> Monthly Deposit(&#8377;)</th>
                                            <th>Interest Earned (&#8377;)</th>
                                            <th>Closing Balance (&#8377;)</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td> ");
#nullable restore
#line 100 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
                                            Write(ViewBag.time);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                            <td> ");
#nullable restore
#line 101 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
                                            Write(ViewBag.PrincipleAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                            <td> ");
#nullable restore
#line 102 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
                                            Write(ViewBag.InterestAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                            <td> ");
#nullable restore
#line 103 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
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
    <div>
        <br />
        <div id=""chartContainer""></div>
        <script type=""text/javascript"">
            window.onload = functio");
                WriteLiteral(@"n () {
                var chart = new CanvasJS.Chart(""chartContainer"", {
                    title: {
                        text: ""Recurring Deposit""
                    },
                    subtitles: [{
                        text: ""Calculator""
                    }],
                    animationEnabled: true,
                    legend: {
                        verticalAlign: ""center"",
                        horizontalAlign: ""left"",
                        fontSize: 20,
                        fontFamily: ""Helvetica""
                    },
                    theme: ""light2"",
                    data: [
                        {
                            type: ""pie"",
                            indexLabelFontFamily: ""Garamond"",
                            indexLabelFontSize: 20,
                            indexLabel: ""{label} Rs. {y}"",
                            startAngle: -20,
                            showInLegend: true,
                            toolTipContent: ");
                WriteLiteral("\"{legendText} {y}%\",\r\n                            dataPoints: [\r\n                                { y: ");
#nullable restore
#line 154 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
                                Write(ViewBag.Finalamount);

#line default
#line hidden
#nullable disable
                WriteLiteral(", legendText: \"Principle Amount\", label: \"Principle Amount\" },\r\n                                { y: ");
#nullable restore
#line 155 "C:\Users\912236\source\repos\CDBBank\CDBBank\Views\RDs\RDCalculator.cshtml"
                                Write(ViewBag.InterestAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@", legendText: ""Interest Amount"", label: ""Interest Amount"" }
                            ]
                        }
                    ]
                });
                chart.render();
            };
        </script>
        <canvas id=""myChart"" width=""487"" height=""487"" style=""display: block; height: 325px; width: 325px;"" class=""chartjs-render-monitor"">
        </canvas>
        <div>
            <br />
            <br />
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
    </div>");
                WriteLiteral("\r\n");
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