#pragma checksum "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeb9d910fdc181dc833c43ede08ef342c6b8d83f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospitalEnCasa.App.FrontEnd.Pages.Familiar.Pages_Familiar_ListFamiliar), @"mvc.1.0.razor-page", @"/Pages/Familiar/ListFamiliar.cshtml")]
namespace HospitalEnCasa.App.FrontEnd.Pages.Familiar
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
#line 1 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\_ViewImports.cshtml"
using HospitalEnCasa.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb9d910fdc181dc833c43ede08ef342c6b8d83f", @"/Pages/Familiar/ListFamiliar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c25a7f304fab7aebbaeb1984a1516c1f0bdafad1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Familiar_ListFamiliar : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddFamiliar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Gestionar Familiares</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eeb9d910fdc181dc833c43ede08ef342c6b8d83f3754", async() => {
                WriteLiteral("Agregar familiar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""table table-striped"">
<tr>
    <th scope=""col"">Cedula</th>
    <th scope=""col"">Nombre</th>
    <th scope=""col"">Genero</th>
    <th scope=""col"">Edad</th>
    <th scope=""col"">Dirección</th>
    <th scope=""col"">Longitud</th>
    <th scope=""col"">Latitud</th>
    <!--<th scope=""col"">Acciones</th>-->
</tr>
");
#nullable restore
#line 18 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
 foreach(var familiar in Model.familiares){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 20 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
       Write(familiar.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
       Write(familiar.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
       Write(familiar.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
       Write(familiar.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
       Write(familiar.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
       Write(familiar.latitud);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
       Write(familiar.longitud);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <!--<td><a class=\"btn btn-primary table-btn\" asp-page=\"./DetailEnfermera\" asp-route-cedula=\"");
#nullable restore
#line 27 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
                                                                                               Write(familiar.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Detalles</a>\r\n        <a class=\"btn btn-primary table-btn\" asp-page=\"./EditEnfermera\" asp-route-cedula=\"");
#nullable restore
#line 28 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
                                                                                     Write(familiar.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Editar</a>\r\n        <a class=\"btn btn-primary table-btn\" asp-page=\"./RemoveEnfermera\" asp-route-cedula=\"");
#nullable restore
#line 29 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
                                                                                       Write(familiar.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Eliminar</a>\r\n        </td>-->\r\n    </tr>\r\n");
#nullable restore
#line 32 "D:\Mintic\misionticciclo3\G45\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Familiar\ListFamiliar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospitalEnCasa.App.FrontEnd.ListFamiliarModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospitalEnCasa.App.FrontEnd.ListFamiliarModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospitalEnCasa.App.FrontEnd.ListFamiliarModel>)PageContext?.ViewData;
        public HospitalEnCasa.App.FrontEnd.ListFamiliarModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
