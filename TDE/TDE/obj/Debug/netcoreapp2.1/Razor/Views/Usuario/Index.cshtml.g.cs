#pragma checksum "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffdaddf9bc5937957c31c4311cef48d83e8cd41a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffdaddf9bc5937957c31c4311cef48d83e8cd41a", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3cca81782e8dff989601503d5b71d729f2a50bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TDE.Models.Usuario>>
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(83, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(112, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe2f377ce3d74a019d2baed160f5088d", async() => {
                BeginContext(135, 10, true);
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
            BeginContext(149, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(242, 45, false);
#line 16 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.idUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(287, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(343, 41, false);
#line 19 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.login));

#line default
#line hidden
            EndContext();
            BeginContext(384, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(440, 41, false);
#line 22 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.senha));

#line default
#line hidden
            EndContext();
            BeginContext(481, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(537, 40, false);
#line 25 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(577, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(633, 39, false);
#line 28 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cpf));

#line default
#line hidden
            EndContext();
            BeginContext(672, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(790, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(839, 44, false);
#line 37 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.idUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(883, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(939, 40, false);
#line 40 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.login));

#line default
#line hidden
            EndContext();
            BeginContext(979, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1035, 40, false);
#line 43 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.senha));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1131, 39, false);
#line 46 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1226, 38, false);
#line 49 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cpf));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1320, 65, false);
#line 52 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1406, 71, false);
#line 53 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1498, 69, false);
#line 54 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\marci\Documents\4º\CLOUD\TDE\TDE\Views\Usuario\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1606, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TDE.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591