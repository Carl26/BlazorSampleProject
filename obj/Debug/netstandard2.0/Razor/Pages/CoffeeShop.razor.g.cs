#pragma checksum "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c82bef14acaada0b34e16f51c3e5b60030fb9a1"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/_Imports.razor"
using WebApplication1;

#line default
#line hidden
#line 7 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#line 1 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
using System.Linq;

#line default
#line hidden
#line 2 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
using System.Collections.Generic;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/coffeeshop")]
    public class CoffeeShop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Coffee Shop Ordering System</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Total items: ");
            __builder.AddContent(3, 
#line 8 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
                 totalNumberOfOrders

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\nOrder Name: ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "name", "order_name");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 10 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
                                                        userInputName

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInputName = __value, userInputName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "<br>\nPrice: ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "number");
            __builder.AddAttribute(13, "name", "order_price");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 11 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
                                                      userInputPrice

#line default
#line hidden
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInputPrice = __value, userInputPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "<br>\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 12 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
                                          AddToOrders

#line default
#line hidden
            ));
            __builder.AddContent(20, "Add Order");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n\n");
#line 14 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
 if (orders == null || orders.Any() == false)
{

#line default
#line hidden
            __builder.AddContent(22, "    ");
            __builder.AddMarkupContent(23, "<p>No order yet!</p>\n");
#line 17 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
}
else 
{

#line default
#line hidden
            __builder.AddContent(24, "    ");
            __builder.OpenElement(25, "table");
            __builder.AddMarkupContent(26, "\n        ");
            __builder.AddMarkupContent(27, "<thead>\n            <tr>\n                <th>Order</th>\n                <th>Price</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(28, "tbody");
            __builder.AddMarkupContent(29, "\n");
#line 28 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
             foreach (var order in orders)
            {

#line default
#line hidden
            __builder.AddContent(30, "                ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#line 31 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
                         order.OrderName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#line 32 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
                         order.Price

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n");
#line 34 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
            }

#line default
#line hidden
            __builder.AddContent(40, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n");
#line 37 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 40 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor"
 
    int totalNumberOfOrders = 0;
    Order currentOrder { get; set; }
    List<Order> orders;
    string userInputName { get; set; }
    decimal userInputPrice { get; set; }

    void AddToOrders() 
    {
        totalNumberOfOrders++;
        currentOrder = CreateOrder(userInputName, userInputPrice);

        if (orders == null)
        {
            orders = new List<Order>();
        }

        orders.Add(currentOrder);

        ClearInputValue();

    }

    void ClearInputValue() 
    {
        userInputName = string.Empty;
        userInputPrice = 0m;
    }

    Order CreateOrder(string name, decimal price)
    {
        Console.WriteLine(name);
        return new Order 
        {
            OrderName = name,
            Price = price
        };
    }

    public class Order 
    {
        public string OrderName { get; set; }
        public decimal Price { get; set; }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
