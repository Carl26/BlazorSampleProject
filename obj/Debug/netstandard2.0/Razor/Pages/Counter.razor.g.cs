#pragma checksum "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "675e4577b475fc5cff2e740ac6d2896dc793bcc5"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#line 5 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/Counter.razor"
                   currentCount

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 7 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/Counter.razor"
                                          IncrementCount

#line default
#line hidden
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "/Users/giemecs/Desktop/Workspace/BlazorSample/WebApplication1/Pages/Counter.razor"
       
    int currentCount = 0;

    [Parameter]
    public int IncrementAmount {get;set;} = 1;

    void IncrementCount()
    {
        currentCount += IncrementAmount;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
