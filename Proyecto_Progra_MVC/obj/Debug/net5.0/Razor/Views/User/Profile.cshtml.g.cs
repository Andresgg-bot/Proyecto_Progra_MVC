#pragma checksum "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38246e0996d261ea3862daa1e82dd570841d230e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
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
#line 1 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\_ViewImports.cshtml"
using Proyecto_Progra_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\_ViewImports.cshtml"
using Proyecto_Progra_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\_ViewImports.cshtml"
using Proyecto_Progra_MVC.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\_ViewImports.cshtml"
using Proyecto_Progra_MVC.Models.InputModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\_ViewImports.cshtml"
using Proyecto_Progra_MVC.Models.DataModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38246e0996d261ea3862daa1e82dd570841d230e", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eec43826e1d90a2b9acf30c6171612836c54615e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div>
    <div class=""row mb-2"">
        <div class=""col-md-10"">
            <div class=""row g-0 border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative"">
                <div class=""col p-4 d-flex flex-column position-static"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38246e0996d261ea3862daa1e82dd570841d230e4669", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 8 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\User\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <strong class=\"d-inline-block mb-2 text-primary\">");
#nullable restore
#line 9 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\User\Profile.cshtml"
                                                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38246e0996d261ea3862daa1e82dd570841d230e6679", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 11 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\User\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Age);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <strong class=\"d-inline-block mb-2 text-primary\">");
#nullable restore
#line 12 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\User\Profile.cshtml"
                                                                Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38246e0996d261ea3862daa1e82dd570841d230e8669", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 14 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\User\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.PhysicalActivity);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <strong class=\"d-inline-block mb-2 text-primary\">");
#nullable restore
#line 15 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\User\Profile.cshtml"
                                                                Write(Model.PhysicalActivity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38246e0996d261ea3862daa1e82dd570841d230e10685", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 17 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\User\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Genero);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <strong class=\"d-inline-block mb-2 text-primary\">");
#nullable restore
#line 18 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\User\Profile.cshtml"
                                                                Write(Model.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38246e0996d261ea3862daa1e82dd570841d230e12682", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 20 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\User\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Email);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <strong class=\"d-inline-block mb-2 text-primary\">");
#nullable restore
#line 21 "D:\Fidelitas\2022 - Q2\Programación Avanzada en Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\User\Profile.cshtml"
                                                                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
