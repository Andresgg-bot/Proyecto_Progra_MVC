#pragma checksum "C:\Users\andre\OneDrive\Desktop\Progra Avanzada Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\Home\Alimentos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "205b0cf7d3c1b417b052b147dda4b63789a59e62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Alimentos), @"mvc.1.0.view", @"/Views/Home/Alimentos.cshtml")]
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
#line 1 "C:\Users\andre\OneDrive\Desktop\Progra Avanzada Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\_ViewImports.cshtml"
using Proyecto_Progra_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\OneDrive\Desktop\Progra Avanzada Web\Proyecto\Proyecto_Progra_MVC\Proyecto_Progra_MVC\Views\_ViewImports.cshtml"
using Proyecto_Progra_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"205b0cf7d3c1b417b052b147dda4b63789a59e62", @"/Views/Home/Alimentos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cf957f320e3abdb2d8e23292f342af0d7a53912", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Alimentos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
.fatsecret_container {
  margin: 70px;
  border: 1px solid #4CAF50;
}
</style>

<div class=""text-center"">
    <h1 class=""display-4"">Integración con FatSecret</h1>
    <p>Aquí puedes conectar tu cuenta de FatSecret y llevar el control de tus alimentos! </p>
    <div id=""my_container"" class=""fatsecret_container""></div>

</div>

<script>
fatsecret.setContainer(""my_container"");
fatsecret.setCanvas(""home"");
</script>


<script src=""https://platform.fatsecret.com/js?key=5e419d008b6e41cfa327e731b0d3405c&auto_load=true&theme=green""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
