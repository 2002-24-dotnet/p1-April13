#pragma checksum "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "092c1baa82fb752964e5d8a737a7d4e9c645dcc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Order), @"mvc.1.0.view", @"/Views/Shared/Order.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"092c1baa82fb752964e5d8a737a7d4e9c645dcc2", @"/Views/Shared/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Ordering from ");
#nullable restore
#line 3 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
             Write(Model.Order.Store.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
#nullable restore
#line 5 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
 if (@Model.Order.Pizzas != null)
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
   if(@Model.Order.Pizzas.Any())
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
     foreach (var p in @Model.Order.Pizzas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 11 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
      Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  $");
#nullable restore
#line 11 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
                Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
                         Write(Html.ActionLink("Remove", "Remove", new { user=@Model.UserId, store=@Model.StoreId, order=@Model.OrderId, pizza=@p.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 12 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Total: $");
#nullable restore
#line 14 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
          Write(Model.Order.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 16 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
Write(Html.ActionLink("Place Order", "Order", new { user=@Model.UserId, store=@Model.StoreId, order=@Model.OrderId }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                                                                                    
  } 
  else
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No Pizzas in Cart.</p>\n");
#nullable restore
#line 21 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
   
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>No Pizzas in Cart.</p>\n");
#nullable restore
#line 26 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 33 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
Write(Html.ActionLink("Add Pizza", "AddPizza", new { user=@Model.UserId, store=@Model.StoreId, order=@Model.OrderId } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 34 "/Users/April/revature_projects/p1/p1-April13/PizzaBox.Client/Views/Shared/Order.cshtml"
Write(Html.ActionLink("Cancel Order", "Delete", new { user=@Model.UserId, store=@Model.StoreId, order=@Model.OrderId } ));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
