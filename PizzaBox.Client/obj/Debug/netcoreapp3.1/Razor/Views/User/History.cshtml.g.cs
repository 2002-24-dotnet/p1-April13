#pragma checksum "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41e62f5a8cc3f354e7c2ab3e97842f6cd8f01662"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_History), @"mvc.1.0.view", @"/Views/User/History.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41e62f5a8cc3f354e7c2ab3e97842f6cd8f01662", @"/Views/User/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_User_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.OrderHistoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Order History for ");
#nullable restore
#line 3 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
                 Write(Model.CurrentUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
#nullable restore
#line 5 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
 if (@Model.UserOrders != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <ul>\n");
#nullable restore
#line 8 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
     foreach (var order in @Model.UserOrders)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>\n        <b>Order #");
#nullable restore
#line 11 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
             Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 11 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
                        Write(order.date.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</b> <br/>\n        Ordered: ");
#nullable restore
#line 12 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
            Write(order.Pizzas.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Pizzas from ");
#nullable restore
#line 12 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
                                              Write(order.Store.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/> \n        Total: $");
#nullable restore
#line 13 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
           Write(order.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 14 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
   Write(Html.ActionLink("Details", "Reciept", new { user=@Model.CurrentUser.Id, order = order.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      </li>     \n");
#nullable restore
#line 16 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 18 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>No Orders</p>\n");
#nullable restore
#line 22 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 24 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/User/History.cshtml"
Write(Html.ActionLink("Back", "UserHome", new { id = @Model.CurrentUser.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<a href=\"/account/logout\">logout</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.OrderHistoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
