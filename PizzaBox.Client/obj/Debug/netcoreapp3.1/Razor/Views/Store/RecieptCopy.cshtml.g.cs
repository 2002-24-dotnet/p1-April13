#pragma checksum "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Store/RecieptCopy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a26cfea60b2ed8a571d4e449d36f02dd5d3c540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_RecieptCopy), @"mvc.1.0.view", @"/Views/Store/RecieptCopy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a26cfea60b2ed8a571d4e449d36f02dd5d3c540", @"/Views/Store/RecieptCopy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_RecieptCopy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Domain.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Order #");
#nullable restore
#line 3 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Store/RecieptCopy.cshtml"
      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p>\n  Customer: ");
#nullable restore
#line 6 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Store/RecieptCopy.cshtml"
       Write(Model.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\n  Submitted: ");
#nullable restore
#line 7 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Store/RecieptCopy.cshtml"
        Write(Html.DisplayTextFor(o => o.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n\n<p>\n  Pizzas Ordered <br/>\n  <ul>\n");
#nullable restore
#line 13 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Store/RecieptCopy.cshtml"
     foreach (var p in @Model.Pizzas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>");
#nullable restore
#line 15 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Store/RecieptCopy.cshtml"
     Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $");
#nullable restore
#line 15 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Store/RecieptCopy.cshtml"
              Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 16 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Store/RecieptCopy.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n</p>\n<p>Total: $");
#nullable restore
#line 19 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Store/RecieptCopy.cshtml"
      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n");
#nullable restore
#line 21 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Store/RecieptCopy.cshtml"
Write(Html.ActionLink("Back to Order History", "StoreHistory", new { id = @Model.Store.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<a href=\"/account/logout\">Logout</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Domain.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
