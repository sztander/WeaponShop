#pragma checksum "C:\Users\sztander\source\repos\WeaponShop\Pages\FetchData - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7f1888e23ad515f949a9fa6464a67f6dfd8b4a4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WeaponShop.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\sztander\source\repos\WeaponShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\sztander\source\repos\WeaponShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\sztander\source\repos\WeaponShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\sztander\source\repos\WeaponShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "C:\Users\sztander\source\repos\WeaponShop\_Imports.razor"
using WeaponShop;

#line default
#line hidden
#line 6 "C:\Users\sztander\source\repos\WeaponShop\_Imports.razor"
using WeaponShop.Shared;

#line default
#line hidden
#line 7 "C:\Users\sztander\source\repos\WeaponShop\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 37 "C:\Users\sztander\source\repos\WeaponShop\Pages\FetchData - Copy.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string Summary { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
