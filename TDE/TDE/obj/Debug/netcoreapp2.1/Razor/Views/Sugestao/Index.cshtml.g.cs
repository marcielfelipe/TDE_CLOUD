#pragma checksum "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b65b2de6d734ca02af7a4de76e4dde36973a642"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sugestao_Index), @"mvc.1.0.view", @"/Views/Sugestao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sugestao/Index.cshtml", typeof(AspNetCore.Views_Sugestao_Index))]
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
#line 1 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\_ViewImports.cshtml"
using TDE;

#line default
#line hidden
#line 2 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\_ViewImports.cshtml"
using TDE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b65b2de6d734ca02af7a4de76e4dde36973a642", @"/Views/Sugestao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3cca81782e8dff989601503d5b71d729f2a50bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Sugestao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TDE.Models.Sugestao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(113, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7c8b9e3e1f646058a57f375f6b02df2", async() => {
                BeginContext(136, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(150, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(243, 46, false);
#line 16 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.idSugestao));

#line default
#line hidden
            EndContext();
            BeginContext(289, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(345, 45, false);
#line 19 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.idUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(390, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(446, 45, false);
#line 22 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(491, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(547, 50, false);
#line 25 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.custoEnvolvido));

#line default
#line hidden
            EndContext();
            BeginContext(597, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(715, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(764, 45, false);
#line 34 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.idSugestao));

#line default
#line hidden
            EndContext();
            BeginContext(809, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(865, 44, false);
#line 37 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.idUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(909, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(965, 44, false);
#line 40 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1065, 49, false);
#line 43 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.custoEnvolvido));

#line default
#line hidden
            EndContext();
            BeginContext(1114, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1170, 65, false);
#line 46 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1235, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1256, 71, false);
#line 47 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1348, 69, false);
#line 48 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Sugestao\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1456, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TDE.Models.Sugestao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
