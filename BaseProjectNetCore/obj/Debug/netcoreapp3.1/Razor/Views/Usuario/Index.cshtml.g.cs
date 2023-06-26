#pragma checksum "C:\netcore\BaseProjectNetCore\BaseProjectNetCore\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdb35972c750d62499e3d025a761ba0b2938fd9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
#line 1 "C:\netcore\BaseProjectNetCore\BaseProjectNetCore\Views\_ViewImports.cshtml"
using BaseProjectNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\netcore\BaseProjectNetCore\BaseProjectNetCore\Views\_ViewImports.cshtml"
using BaseProjectNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdb35972c750d62499e3d025a761ba0b2938fd9f", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"265a6a83dc12842a24614644cf249983108edf40", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\netcore\BaseProjectNetCore\BaseProjectNetCore\Views\Usuario\Index.cshtml"
   
    ViewBag.Title = "Usuario";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdb35972c750d62499e3d025a761ba0b2938fd9f3712", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h2> Agregar usuario</h2>


<div class=""form-group"" style=""display:none;"">
    <input id=""txtUsuarioId"" class=""form-control"" name=""UserId"" />

</div>


<div class=""form-group"">
    <label for=""UserCodigo"">Codigo:</label>
    <input id=""txtUsuarioCodigo"" class=""form-control"" name=""UserCodigo"" />

</div>


<div class=""form-group"">
    <label for=""UserNombre"">Nombre:</label>
    <input id=""txtUsuarioNombre"" class=""form-control"" name=""UserNombre"" />

</div>

<div class=""form-group"">
    <label for=""UserTelefono"">Telefono:</label>
    <input id=""txtUsuarioTelefono"" class=""form-control"" name=""UserTelefono"" />

</div>


<div class=""text-center panel-body"">

    
    <button id=""btnSave"" class=""btn btn-sm btn-primary"">Guardar nuevo usuario</button>
    <button id=""btnUpdate"" class=""btn btn-sm btn-success"">Modificar usuario</button>


</div>



<br />

<h2>Listado de usuarios</h2>
<table id=""tblUsers"" class=""table table-sm table-striped table-bordered m-2"">

    <thead>");
            WriteLiteral(@"
        <tr>
            <th>Id Usuario</th>
            <th>Codigo</th>
            <th>Nombre</th>
            <th>Telefono</th>
            <th>Acción</th>
        </tr>
    </thead>
    <tbody></tbody>

</table>

<script type=""text/javascript"">
    $(document).ready(function () {


    });

    function GetAllUsers() {
        $.getJSON(""/Usuario/GetAllUsers"", function (usuarios) {
            $(""#tblUsers tbody tr"").remove();
            $.map(usuarios, function (usuario) {
                $(""#tblUsers tbody"").append(""<tr>""
                    + "" <td>"" + usuario.id + ""</td>""
                    + "" <td>"" + usuario.codigo + ""</td>""
                    + "" <td>"" + usuario.nombre + ""</td>""
                    + "" <td>"" + usuario.telefono + ""</td>""
                    + "" <td>""
                    + ""      <button class='btn-success' onclick='Edit(\"""" + usuario.id + ""\"")' style='margin-right:5px;'>Editar </button>""
                    + ""      <button class='btn-danger' onclic");
            WriteLiteral(@"k= 'Delete(\"""" + usuario.id + ""\"")'> borrar </button>""
                    + "" </td> ""
                    + "" </tr>"");

            });
        });
    }


    function Edit(id) {
        if (id!= null) {
            $.getJSON(""/Usuario/GetById?userId="" + id, function (usuario) {
                $(""#txtUsuarioId"").val(usuario.id);
                $(""#txtUsuarioCodigo"").val(usuario.codigo);
                $(""#txtUsuarioNombre"").val(usuario.nombre);
                $(""#txtUsuarioTelefono"").val(usuario.telefono);
            });
        }
    }



    function Delete(id) {
        if (id != null) {
            console.log('intentando eliminar: ' + id);

            $.ajax({
                url: '/Usuario/deleteUser?userID=' + id,
                type: 'DELETE',
                dataType: 'json',
                success: function (data) {

                    GetAllUsers()
                    window.alert('Usuario Eliminado')

                },
                error: function");
            WriteLiteral(@" (ex) {
                    console.log('Error al eliminar usuario');
                }

            });
        }
    }


    $(""#btnSave"").click(function () {
        var oUser = {
            codigo: $(""#txtUsuarioCodigo"").val(),
            nombre: $(""#txtUsuarioNombre"").val(),
            telefono: $(""#txtUsuarioTelefono"").val()

        };

        $.post(""/Usuario/AddUser"", oUser)
            .done(function (data) {

                GetAllUsers()
                window.alert('Usuario agregado')


            });

    });


    $(""#btnUpdate"").click(function () {
        var oUser = {
            id: $(""#txtUsuarioId"").val(),
            codigo: $(""#txtUsuarioCodigo"").val(),
            nombre: $(""#txtUsuarioNombre"").val(),
            telefono: $(""#txtUsuarioTelefono"").val()

        };

        $.post(""/Usuario/updateUser"", oUser)
            .done(function (data) {

                GetAllUsers()
                window.alert('Usuario modificado')


        ");
            WriteLiteral("    });\r\n\r\n    });\r\n\r\n\r\n\r\n    window.onload = function () {\r\n        GetAllUsers()\r\n    };\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591