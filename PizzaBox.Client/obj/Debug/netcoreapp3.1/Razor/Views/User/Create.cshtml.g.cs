#pragma checksum "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da9e2b7ae48d249d3618e83d33bebd484cc3b559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Create), @"mvc.1.0.view", @"/Views/User/Create.cshtml")]
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
#line 1 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da9e2b7ae48d249d3618e83d33bebd484cc3b559", @"/Views/User/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.PizzaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/user/postpizza"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Build your Pizza!</h1>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da9e2b7ae48d249d3618e83d33bebd484cc3b5594158", async() => {
                WriteLiteral("\n  ");
#nullable restore
#line 6 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n  ");
#nullable restore
#line 7 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
Write(Html.HiddenFor(pvm => pvm.OrderId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n  ");
#nullable restore
#line 8 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
Write(Html.HiddenFor(pvm => pvm.UserId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n  ");
#nullable restore
#line 9 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
Write(Html.HiddenFor(pvm => pvm.StoreId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n  <b>Crust</b>\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da9e2b7ae48d249d3618e83d33bebd484cc3b5595384", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 13 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
     foreach (var item in @Model.CrustList)
    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("      ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da9e2b7ae48d249d3618e83d33bebd484cc3b5595903", async() => {
#nullable restore
#line 15 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
                        Write(item.Name);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n");
#nullable restore
#line 16 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("  ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 12 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CrustId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n  <br/>\n  <b>Size</b>\n  <br/>\n");
#nullable restore
#line 21 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
   foreach (var item in @Model.SizeList)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
Write(Html.RadioButtonFor(pvm => pvm.SizeId, item.Id, new { id = item.Id.ToString() }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
Write(Html.Label(item.Id.ToString(), item.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
                                              
  }

#line default
#line hidden
#nullable disable
                WriteLiteral("  <br/>\n  <b>Toppings</b>\n  <br/>\n");
#nullable restore
#line 29 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
   foreach(var item in @Model.ToppingList)
  {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"checkbox\" name=\"ToppingsId\"");
                BeginWriteAttribute("value", " value=", 764, "", 779, 1);
#nullable restore
#line 31 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
WriteAttributeValue("", 771, item.Id, 771, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=", 779, "", 791, 1);
#nullable restore
#line 31 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
WriteAttributeValue("", 783, item.Id, 783, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n    <label");
                BeginWriteAttribute("for", " for=", 804, "", 817, 1);
#nullable restore
#line 32 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
WriteAttributeValue("", 809, item.Id, 809, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 32 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 33 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
  }

#line default
#line hidden
#nullable disable
                WriteLiteral("<br/>\n  <button type=\"submit\">Add to Cart</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 38 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/Create.cshtml"
Write(Html.ActionLink("Back", "Cart", new { user=@Model.UserId, store=@Model.StoreId, order=@Model.OrderId} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.PizzaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591