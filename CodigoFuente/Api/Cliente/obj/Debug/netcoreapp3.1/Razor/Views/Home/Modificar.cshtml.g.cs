#pragma checksum "C:\Users\Huriel Gómez\Documents\Prueba\CodigoFuente\Api\Cliente\Views\Home\Modificar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bf5b73aeb90e6c0ab7d2f929e6660b06ace2082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Modificar), @"mvc.1.0.view", @"/Views/Home/Modificar.cshtml")]
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
#line 1 "C:\Users\Huriel Gómez\Documents\Prueba\CodigoFuente\Api\Cliente\Views\_ViewImports.cshtml"
using Cliente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Huriel Gómez\Documents\Prueba\CodigoFuente\Api\Cliente\Views\_ViewImports.cshtml"
using Cliente.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bf5b73aeb90e6c0ab7d2f929e6660b06ace2082", @"/Views/Home/Modificar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846397c85d0ed92f080b0c5ca90fd9a40f5e6079", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Modificar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehiculoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Huriel Gómez\Documents\Prueba\CodigoFuente\Api\Cliente\Views\Home\Modificar.cshtml"
  
    ViewData["Title"] = "Modificar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Modificar Vehiculo</h1>\r\n\r\n<div id=\"login-div\">\r\n    <ul class=\"pagination justify-content-center\" style=\"margin:20px 0\">\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 11 "C:\Users\Huriel Gómez\Documents\Prueba\CodigoFuente\Api\Cliente\Views\Home\Modificar.cshtml"
             using (Html.BeginForm("updateVehiculo", "Home", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label for=\"Id\">Id:</label>\r\n                    <input type=\"number\" class=\"form-control\" name=id id=\"id\" placeholder=\"id\"");
            BeginWriteAttribute("value", " value=", 509, "", 534, 1);
#nullable restore
#line 15 "C:\Users\Huriel Gómez\Documents\Prueba\CodigoFuente\Api\Cliente\Views\Home\Modificar.cshtml"
WriteAttributeValue("", 516, Model.id_vehiculo, 516, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""form-group"">
                    <label for=""Capacidad"">Capacidad:</label>
                    <input type=""number"" class=""form-control"" name=capacidad id=""capacidad"" placeholder=""ingresar la capacidad""");
            BeginWriteAttribute("value", " value=", 793, "", 816, 1);
#nullable restore
#line 19 "C:\Users\Huriel Gómez\Documents\Prueba\CodigoFuente\Api\Cliente\Views\Home\Modificar.cshtml"
WriteAttributeValue("", 800, Model.capacidad, 800, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"Consumo\">Consumo:</label>\r\n                    <input type=\"number\" class=\"form-control\" name=consumo id=\"consumo\" placeholder=\"ingresar el consumo\"");
            BeginWriteAttribute("value", " value=", 1065, "", 1086, 1);
#nullable restore
#line 23 "C:\Users\Huriel Gómez\Documents\Prueba\CodigoFuente\Api\Cliente\Views\Home\Modificar.cshtml"
WriteAttributeValue("", 1072, Model.consumo, 1072, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""form-group"">
                    <label for=""Depreciacion"">Depreciacion:</label>
                    <input type=""number"" class=""form-control"" name=depreciacion id=""depreciacion"" placeholder=""ingresar la depreciacion""");
            BeginWriteAttribute("value", " value=", 1360, "", 1386, 1);
#nullable restore
#line 27 "C:\Users\Huriel Gómez\Documents\Prueba\CodigoFuente\Api\Cliente\Views\Home\Modificar.cshtml"
WriteAttributeValue("", 1367, Model.depreciacion, 1367, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <input id=\"btn\" name=\"btn\" type=\"submit\" value=\"Modificar\" class=\"btn btn-success\" />\r\n");
#nullable restore
#line 30 "C:\Users\Huriel Gómez\Documents\Prueba\CodigoFuente\Api\Cliente\Views\Home\Modificar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehiculoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
