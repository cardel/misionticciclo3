#pragma checksum "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fc5e6c92dccfb1d6d5e77f20f2fd416e3ad50f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospitalEnCasa.App.FrontEnd.Pages.GestorPacientes.Pages_GestorPacientes_ListPaciente), @"mvc.1.0.razor-page", @"/Pages/GestorPacientes/ListPaciente.cshtml")]
namespace HospitalEnCasa.App.FrontEnd.Pages.GestorPacientes
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
#line 1 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\_ViewImports.cshtml"
using HospitalEnCasa.App.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
using HospitalEnCasa.app.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fc5e6c92dccfb1d6d5e77f20f2fd416e3ad50f8", @"/Pages/GestorPacientes/ListPaciente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c25a7f304fab7aebbaeb1984a1516c1f0bdafad1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GestorPacientes_ListPaciente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddPaciente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Gestionar pacientes</h1>\r\n<p>En está pagina podrás gestionar los pacientes</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fc5e6c92dccfb1d6d5e77f20f2fd416e3ad50f84096", async() => {
                WriteLiteral("Agregar pacientes");
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
<table class=""table"">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">Cedula</th>
      <th scope=""col"">Nombre</th>
      <th scope=""col"">Edad</th>
      <th scope=""col"">Genero</th>
      <th scope=""col"">Dirección</th>
      <th scope=""col"">Longitud</th>
      <th scope=""col"">Latitud</th>
      <th scope=""col"">Familiar</th>
      <th scope=""col"">Médico</th>
      <th scope=""col"">Enfermera</th>   
    </tr>
  </thead>
");
#nullable restore
#line 25 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
 foreach(var paciente in Model.pacientes){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 27 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
       Write(paciente.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
       Write(paciente.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
       Write(paciente.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
       Write(paciente.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
       Write(paciente.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
       Write(paciente.longitud);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
       Write(paciente.latitud);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
       Write(paciente.familiar.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
                                 Write(paciente.familiar.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
       Write(paciente.medico.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
                               Write(paciente.medico.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
       Write(paciente.enfermera.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 36 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
                                  Write(paciente.enfermera.hospital);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>       \r\n    </tr>\r\n");
#nullable restore
#line 38 "D:\Mintic\misionticciclo3\G53\HospitalEnCasa.App\HospitalEnCasa.App.FrontEnd\Pages\GestorPacientes\ListPaciente.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospitalEnCasa.App.FrontEnd.Pages.ListPacienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospitalEnCasa.App.FrontEnd.Pages.ListPacienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospitalEnCasa.App.FrontEnd.Pages.ListPacienteModel>)PageContext?.ViewData;
        public HospitalEnCasa.App.FrontEnd.Pages.ListPacienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591