#pragma checksum "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\Components\Components.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634c4f81535f399c2b44a81a6141808ecec35d88"
// <auto-generated/>
#pragma warning disable 1591
namespace WEB_VOITESHONOK_953501.Blazor.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using WEB_VOITESHONOK_953501.Blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using WEB_VOITESHONOK_953501.Blazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using WEB_VOITESHONOK_953501.Blazor.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class Components : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Components</h3>");
#nullable restore
#line 3 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\Components\Components.razor"
 if (Dish != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "img");
            __builder.AddAttribute(2, "src", 
#nullable restore
#line 5 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\Components\Components.razor"
               imageSrc

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "class", "img-thumbnail");
            __builder.AddAttribute(4, "width", "150");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, 
#nullable restore
#line 7 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\Components\Components.razor"
            Dish.DishName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " - ");
            __builder.AddContent(10, 
#nullable restore
#line 7 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\Components\Components.razor"
                             Dish.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "badge badge-info ");
            __builder.AddContent(14, 
#nullable restore
#line 9 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\Components\Components.razor"
             Dish.Calories

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n        калорий\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\Components\Components.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\GitHub\5_term_IGI\WEB_VOITESHONOK_953501\WEB_VOITESHONOK_953501.Blazor\Client\Components\Components.razor"
       
    [Parameter]
    public DetailsViewModel Dish { get; set; }
    [Parameter]
    public EventCallback<DetailsViewModel> DishChanged { get; set; }
    string imageSrc
    {
        get
        {
            return $"images/{Dish.Image}";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
