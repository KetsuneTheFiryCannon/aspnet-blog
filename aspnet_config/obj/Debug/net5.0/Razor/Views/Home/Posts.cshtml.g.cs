#pragma checksum "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97fa11bff613e222a55a9abe20110f497bd350ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Posts), @"mvc.1.0.view", @"/Views/Home/Posts.cshtml")]
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
#line 1 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\_ViewImports.cshtml"
using aspnet_config;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\_ViewImports.cshtml"
using aspnet_config.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97fa11bff613e222a55a9abe20110f497bd350ba", @"/Views/Home/Posts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8342ace16116a9179898e9d51fa53a8f01b8a2fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Posts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<aspnet_config.Models.UserPost>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
  
    ViewBag.Title = "Posts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
     foreach (var item in Model.Posts)
    {
        foreach (var item2 in Model.Users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 13 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
                 if (TestClass.TestInt == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 15 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
                   Write(item.Id_Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 16 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 396, "\"", 431, 1);
#nullable restore
#line 18 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
WriteAttributeValue("", 402, Url.Content(item.Photo_post), 402, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" alt=\"blogphoto\" />\r\n\r\n                </td>\r\n                <td>Post name: ");
#nullable restore
#line 21 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
                          Write(item.Name_Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>Post text: ");
#nullable restore
#line 22 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
                          Write(item.Text_Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 23 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
                 if(item2.Id_User==item.Owner_Post)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Post author: ");
#nullable restore
#line 25 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
                        Write(item2.Login_User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n");
#nullable restore
#line 26 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\sasha\source\repos\aspnet_config\aspnet_config\Views\Home\Posts.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<aspnet_config.Models.UserPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
