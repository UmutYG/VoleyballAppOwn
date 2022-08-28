#pragma checksum "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47e925448d3974d571d4d25367e420ca414e6f54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Squad), @"mvc.1.0.view", @"/Views/Main/Squad.cshtml")]
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
#line 2 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\_ViewImports.cshtml"
using voleyballapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\_ViewImports.cshtml"
using voleyballapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\_ViewImports.cshtml"
using voleyballapp.webui.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e925448d3974d571d4d25367e420ca414e6f54", @"/Views/Main/Squad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26454c4649f216b0e802978a5ae23999e9c8dcfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Squad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamPlayersModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral(@"
    <style>
    .container-squad
    {
      width: 100% !important;
      height: 1000px;
      background: url(/images/Squad/court.jpg);
      background-repeat: no-repeat;
      background-size: cover;
      background-position: center;
      display: flex;
      flex-direction: column;
      justify-content: flex-end;
     
    }

    .mid-row {
      width: 60%;
      margin: 0 auto;
      display: flex;
      justify-content: space-between;
      text-align: center;
    
    }
    .bot-row
    {
      text-align: center;
      width: 60%;
      margin-left: auto;
      margin-right: auto;
      margin-bottom: 150px;
      margin-top: 10px;
      display: flex;
      justify-content: space-between;
      
    }

    .img-fluid
    {
        border-radius: 50%;
    }
    </style>
");
            }
            );
            WriteLiteral(@"<style>
    .container-squad
    {
      width: 100% !important;
      height: 1000px;
      background: url(/images/Squad/court.jpg);
      background-repeat: no-repeat;
      background-size: cover;
      background-position: center;
      display: flex;
      flex-direction: column;
      justify-content: flex-end;
     
    }

    .mid-row {
      width: 60%;
      margin: 0 auto;
      display: flex;
      justify-content: space-between;
      text-align: center;
    
    }
    .bot-row
    {
      text-align: center;
      width: 60%;
      margin-left: auto;
      margin-right: auto;
      margin-bottom: 150px;
      margin-top: 10px;
      display: flex;
      justify-content: space-between;
      
    }

    .img-fluid
    {
        border-radius: 50%;
    }
    </style>
<div class=""container"" style=""max-width: 2000px;"">
    <div class=""row"">
        <div class=""col-xl-8"">
            <div class=""card"">
                <div class=""card-body"">
            ");
            WriteLiteral("        <h5 class=\"header-title pb-3 mt-0\">");
#nullable restore
#line 93 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                                  Write(ViewBag.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    <div class=""table-responsive"">
                        <table class=""table table-hover mb-0"">
                            <thead>
                                <tr class=""align-self-center"">
                                    <th style=""width: 200px;"">Player Name</th>
                                    <th>Nation</th>
                                    <th>Position</th>
                                    <th>Height</th>
                                    <th>Weight</th>
                                    <th>Number</th>
                                    <th>Spike</th>
                                    <th>Block</th>
                                    <th>Reception</th>
                                    <th>Attack</th>
                                    <th>Serve</th>
                                    <th>Price</th>
                                </tr>
                            </thead>
                            <tbody>
                      ");
            WriteLiteral("          \r\n");
#nullable restore
#line 114 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                     foreach (var player in @Model.TeamPlayers)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                    <td><img");
            BeginWriteAttribute("src", " src=\"", 3210, "\"", 3230, 1);
#nullable restore
#line 117 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
WriteAttributeValue("", 3216, player.imgUrl, 3216, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\"");
            BeginWriteAttribute("alt", " alt=\"", 3242, "\"", 3248, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"thumb-sm rounded-circle mr-2\"> ");
#nullable restore
#line 117 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                                                                                                     Write(player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                         ");
#nullable restore
#line 119 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                    Write(player.Nation.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 121 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                   Write(player.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 122 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                   Write(player.PlayerStats.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 123 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                   Write(player.PlayerStats.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 124 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                   Write(player.PlayerStats.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 125 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                   Write(player.PlayerStats.Spike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 126 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                   Write(player.PlayerStats.Block);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 127 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                   Write(player.PlayerStats.Reception);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 128 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                   Write(player.PlayerStats.Attack);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 129 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                   Write(player.PlayerStats.Serve);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 130 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                   Write(player.PlayerStats.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 133 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                
                            </tbody>
                        </table>
                    </div>
                    <!--end table-responsive-->
                    <div class=""pt-3 border-top text-right""><a href=""#"" class=""text-primary"">View all <i class=""mdi mdi-arrow-right""></i></a></div>
                </div>
            </div>
        </div>
        <div class=""col-xl-4"">
            <div class=""container-squad my-5"" >
                <div class=""mid-row"">
");
#nullable restore
#line 146 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                     for (int i = 0; i < 3; i++)
                    {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\r\n                        <img class=\"img-fluid\" width=\"60\"");
            BeginWriteAttribute("src", " src=\"", 5063, "\"", 5097, 1);
#nullable restore
#line 149 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
WriteAttributeValue("", 5069, Model.TeamPlayers[i].imgUrl, 5069, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5098, "\"", 5104, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 151 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"bot-row\">\r\n");
#nullable restore
#line 154 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                     for (int i = 3; i < 6; i++)
                    {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\r\n                        <img class=\"img-fluid\" width=\"60\"");
            BeginWriteAttribute("src", " src=\"", 5400, "\"", 5434, 1);
#nullable restore
#line 157 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
WriteAttributeValue("", 5406, Model.TeamPlayers[i].imgUrl, 5406, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5435, "\"", 5441, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 159 "C:\Users\umut_\Desktop\VoleyballAppOwn\voleyballapp.webui\Views\Main\Squad.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamPlayersModel> Html { get; private set; }
    }
}
#pragma warning restore 1591