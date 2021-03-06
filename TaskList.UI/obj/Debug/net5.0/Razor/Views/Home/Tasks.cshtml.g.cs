#pragma checksum "C:\Projects\TaskList\TaskList.UI\Views\Home\Tasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b6c8663455712afe826df8859cd160304ae51ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tasks), @"mvc.1.0.view", @"/Views/Home/Tasks.cshtml")]
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
#line 1 "C:\Projects\TaskList\TaskList.UI\Views\_ViewImports.cshtml"
using TaskList.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\TaskList\TaskList.UI\Views\_ViewImports.cshtml"
using TaskList.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\TaskList\TaskList.UI\Views\_ViewImports.cshtml"
using TaskList.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\TaskList\TaskList.UI\Views\_ViewImports.cshtml"
using TaskList.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b6c8663455712afe826df8859cd160304ae51ba", @"/Views/Home/Tasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97c75986326c66952a248f1fe44fa944bf02a440", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\TaskList\TaskList.UI\Views\Home\Tasks.cshtml"
  
    ViewData["Title"] = "Tasks";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Tasks</h1>

<div class=""row"">
    <div class=""col-lg-12"">
        <table class=""table table-responsive table-bordered"">
            <thead>
                <tr>
                    <td>Task Name</td>
                    <td>Is Task Completed?</td>
                    <td>Task Created</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 19 "C:\Projects\TaskList\TaskList.UI\Views\Home\Tasks.cshtml"
                 if (Model.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Projects\TaskList\TaskList.UI\Views\Home\Tasks.cshtml"
                     foreach (var task in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 24 "C:\Projects\TaskList\TaskList.UI\Views\Home\Tasks.cshtml"
                           Write(task.TaskName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Projects\TaskList\TaskList.UI\Views\Home\Tasks.cshtml"
                           Write(task.IsCompleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Projects\TaskList\TaskList.UI\Views\Home\Tasks.cshtml"
                           Write(task.DateCreated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 28 "C:\Projects\TaskList\TaskList.UI\Views\Home\Tasks.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Projects\TaskList\TaskList.UI\Views\Home\Tasks.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"3\" class=\"text-center\">\r\n                            No Records Found.\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 37 "C:\Projects\TaskList\TaskList.UI\Views\Home\Tasks.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
