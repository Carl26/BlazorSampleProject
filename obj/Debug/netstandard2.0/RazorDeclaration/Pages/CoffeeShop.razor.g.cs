#pragma checksum "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/CoffeeShop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c82bef14acaada0b34e16f51c3e5b60030fb9a1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
