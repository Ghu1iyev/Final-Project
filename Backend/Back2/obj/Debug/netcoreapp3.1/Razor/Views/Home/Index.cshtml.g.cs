#pragma checksum "C:\Users\examone\Source\Repos\Back2\Back2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed059a2e82f017e6e218230f0f90b162038b8b72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\examone\Source\Repos\Back2\Back2\Views\_ViewImports.cshtml"
using Back2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\examone\Source\Repos\Back2\Back2\Views\_ViewImports.cshtml"
using Back2.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed059a2e82f017e6e218230f0f90b162038b8b72", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d3fe2f391471d622a5f8b1e8178b082c7be43f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\examone\Source\Repos\Back2\Back2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""ready"">
        <div class=""container"">
            <div class=""title"">
                <h2>READY TO LAUNCH</h2>
            </div>
            <div class=""icon"">
                <i class=""fa-solid fa-bomb""></i>
            </div>
            <div class=""title"">
                <h2>LOREM IPSUM DOLOR SIT AMET</h2>
            </div>
            <div class=""desc"">
                <p>
                    Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.
                    Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus
                    mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa
                    quis enim.
                </p>
            </div>
        </div>
    </section>
    <section id=""portfolio"">
        <div class=""container mb-5"">
            <div class=""title text-center mt-5"">
                <h2>OUR PORTF");
            WriteLiteral("OLIO</h2>\r\n            </div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 34 "C:\Users\examone\Source\Repos\Back2\Back2\Views\Home\Index.cshtml"
                 foreach (Portfolio portfolio in Model.portfolios)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"img col-lg-4 col-md-6 col-sm-12\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1324, "\"", 1362, 2);
            WriteAttributeValue("", 1330, "./assets/images/", 1330, 16, true);
#nullable restore
#line 37 "C:\Users\examone\Source\Repos\Back2\Back2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1346, portfolio.Image, 1346, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1363, "\"", 1369, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 39 "C:\Users\examone\Source\Repos\Back2\Back2\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>
    <section id=""about"">
        <div class=""container"">
            <div class=""title text-center pt-5"">
                <h2>ABOUT COMPANY</h2>
            </div>
            <div class=""row mt-5"">
                <div class=""contact col-lg-4 col-md-12 col-sm-12"">
                    <img src=""./assets/images/team1.png""");
            BeginWriteAttribute("alt", " alt=\"", 1803, "\"", 1809, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h2>Jhon Deo Alex</h2>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet,
                        consectetur adipiscing elit.
                    </p>
                    <div class=""icons"">
                        <ul>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2177, "\"", 2184, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-facebook-square\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2275, "\"", 2282, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-linkedin\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2366, "\"", 2373, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-google\"></i></a></li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n                <div class=\"contact col-lg-4 col-md-12  col-sm-12\">\r\n                    <img src=\"./assets/images/team2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2629, "\"", 2635, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h2>Linda Sew Lie</h2>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet,
                        consectetur adipiscing elit.
                    </p>
                    <div class=""icons"">
                        <ul>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3003, "\"", 3010, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-facebook-square\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3101, "\"", 3108, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-linkedin\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3192, "\"", 3199, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa-brands fa-google""></i></a></li>
                        </ul>
                    </div>
                </div>
                <div class=""about col-lg-4 col-md-12  col-sm-12"">
                    <ul>
                        <li>
                            <a class=""active""");
            BeginWriteAttribute("href", " href=\"", 3498, "\"", 3505, 0);
            EndWriteAttribute();
            WriteLiteral(">Vivamus sagittis egestas mauris</a>\r\n                        </li>\r\n                        <li><a class=\"btn-active\"");
            BeginWriteAttribute("href", " href=\"", 3624, "\"", 3631, 0);
            EndWriteAttribute();
            WriteLiteral(">Cras viverra ac orci ac</a></li>\r\n                        <li><a class=\"active\"");
            BeginWriteAttribute("href", " href=\"", 3712, "\"", 3719, 0);
            EndWriteAttribute();
            WriteLiteral(">Sed Diam Nonummy Euismod</a></li>\r\n                        <li><a class=\"active\"");
            BeginWriteAttribute("href", " href=\"", 3801, "\"", 3808, 0);
            EndWriteAttribute();
            WriteLiteral(">Vivamus sagittis egestas mauris</a></li>\r\n                        <li><a class=\"active\"");
            BeginWriteAttribute("href", " href=\"", 3897, "\"", 3904, 0);
            EndWriteAttribute();
            WriteLiteral(">Cras viverra ac orci ac</a></li>\r\n                        <li><a class=\"active\"");
            BeginWriteAttribute("href", " href=\"", 3985, "\"", 3992, 0);
            EndWriteAttribute();
            WriteLiteral(@">Sed Diam Nonummy Euismod</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <section id=""contact"">
        <div class=""container mb-5 col-lg-12 col-md-12 col-sm-12"">
            <div class=""title pt-5"">
                <h2>CONTACT HERE</h2>
            </div>
            <div class=""form pt-5"">
                <form");
            BeginWriteAttribute("action", " action=\"", 4383, "\"", 4392, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""name pt-3"">
                        <input placeholder=""Name"" type=""text"">
                    </div>
                    <div class=""email pt-3"">
                        <input type=""email"" placeholder=""Email address"">
                    </div>
                    <div class=""notes pt-3"">
                        <input type=""text"" placeholder=""Notes"">
                    </div>
                </form>
            </div>
            <div class=""btn pt-4 col-lg-12 col-md-12 col-12 text-center"">
                <a");
            BeginWriteAttribute("href", " href=\"", 4958, "\"", 4965, 0);
            EndWriteAttribute();
            WriteLiteral(@">SUBMIT REQUEST</a>
            </div>
        </div>
    </section>
    <address>
        Address: 230/45 , Newyork City, USA-305670
    </address>
    <section id=""maps"">
        <div id=""map"" style=""width:100%;height:400px""></div>
    </section>
    
</main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
