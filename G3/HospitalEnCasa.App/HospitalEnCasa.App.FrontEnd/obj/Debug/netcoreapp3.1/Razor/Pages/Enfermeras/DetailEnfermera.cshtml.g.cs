#pragma checksum "D:\mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Enfermeras\DetailEnfermera.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445b437cd02aa1cd9b4a28e0df76621e30a665e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospitalEnCasa.App.FrontEnd.Pages.Enfermeras.Pages_Enfermeras_DetailEnfermera), @"mvc.1.0.razor-page", @"/Pages/Enfermeras/DetailEnfermera.cshtml")]
namespace HospitalEnCasa.App.FrontEnd.Pages.Enfermeras
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
#line 1 "D:\mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\_ViewImports.cshtml"
using HospitalEnCasa.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445b437cd02aa1cd9b4a28e0df76621e30a665e0", @"/Pages/Enfermeras/DetailEnfermera.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c25a7f304fab7aebbaeb1984a1516c1f0bdafad1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Enfermeras_DetailEnfermera : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle enfermera ");
#nullable restore
#line 5 "D:\mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Enfermeras\DetailEnfermera.cshtml"
                 Write(Model.enfermera.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<ul>\r\n    <li>Cedula: ");
#nullable restore
#line 7 "D:\mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Enfermeras\DetailEnfermera.cshtml"
           Write(Model.enfermera.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Nombre: ");
#nullable restore
#line 8 "D:\mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Enfermeras\DetailEnfermera.cshtml"
           Write(Model.enfermera.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Genero: ");
#nullable restore
#line 9 "D:\mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Enfermeras\DetailEnfermera.cshtml"
           Write(Model.enfermera.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Edad: ");
#nullable restore
#line 10 "D:\mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Enfermeras\DetailEnfermera.cshtml"
         Write(Model.enfermera.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Hospital: ");
#nullable restore
#line 11 "D:\mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Enfermeras\DetailEnfermera.cshtml"
             Write(Model.enfermera.hospital);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Información laboral: ");
#nullable restore
#line 12 "D:\mintic\misionticciclo3\G3\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\Enfermeras\DetailEnfermera.cshtml"
                        Write(Model.enfermera.informacion_laboral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospitalEnCasa.App.FrontEnd.Pages.DetailEnfermeraModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospitalEnCasa.App.FrontEnd.Pages.DetailEnfermeraModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospitalEnCasa.App.FrontEnd.Pages.DetailEnfermeraModel>)PageContext?.ViewData;
        public HospitalEnCasa.App.FrontEnd.Pages.DetailEnfermeraModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591