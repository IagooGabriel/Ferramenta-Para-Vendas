#pragma checksum "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\VendaParcelas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dba662d77397f2d5b048a045b08f1d69a839441"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VendaParcelas_Details), @"mvc.1.0.view", @"/Views/VendaParcelas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/VendaParcelas/Details.cshtml", typeof(AspNetCore.Views_VendaParcelas_Details))]
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
#line 1 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#line 2 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dba662d77397f2d5b048a045b08f1d69a839441", @"/Views/VendaParcelas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cd403b176af46e85ea812cbc8b3a7a1a86d4d8", @"/Views/_ViewImports.cshtml")]
    public class Views_VendaParcelas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProject.Models.Entity.VendaParcela>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\VendaParcelas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 135, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>VendaParcela</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(229, 44, false);
#line 14 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\VendaParcelas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.parcelas));

#line default
#line hidden
            EndContext();
            BeginContext(273, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(337, 40, false);
#line 17 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\VendaParcelas\Details.cshtml"
       Write(Html.DisplayFor(model => model.parcelas));

#line default
#line hidden
            EndContext();
            BeginContext(377, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(440, 49, false);
#line 20 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\VendaParcelas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.dt_vencimento));

#line default
#line hidden
            EndContext();
            BeginContext(489, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(553, 45, false);
#line 23 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\VendaParcelas\Details.cshtml"
       Write(Html.DisplayFor(model => model.dt_vencimento));

#line default
#line hidden
            EndContext();
            BeginContext(598, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(661, 48, false);
#line 26 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\VendaParcelas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.dt_pagamento));

#line default
#line hidden
            EndContext();
            BeginContext(709, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(773, 44, false);
#line 29 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\VendaParcelas\Details.cshtml"
       Write(Html.DisplayFor(model => model.dt_pagamento));

#line default
#line hidden
            EndContext();
            BeginContext(817, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(880, 41, false);
#line 32 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\VendaParcelas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.valor));

#line default
#line hidden
            EndContext();
            BeginContext(921, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(985, 37, false);
#line 35 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\VendaParcelas\Details.cshtml"
       Write(Html.DisplayFor(model => model.valor));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1069, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dba662d77397f2d5b048a045b08f1d69a8394418298", async() => {
                BeginContext(1120, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Iago Gabriel\Documents\_FACULDADE\4º Periodo\C_Sharp\2_Bimestre\FinalProject\FinalProject\Views\VendaParcelas\Details.cshtml"
                           WriteLiteral(Model.id_parc);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1128, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1136, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dba662d77397f2d5b048a045b08f1d69a83944110678", async() => {
                BeginContext(1158, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1174, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject.Models.Entity.VendaParcela> Html { get; private set; }
    }
}
#pragma warning restore 1591