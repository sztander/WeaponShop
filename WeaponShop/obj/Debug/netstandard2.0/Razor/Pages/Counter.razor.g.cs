#pragma checksum "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a309c350f8ff95fe207146d537fe06089ba1c589"
// <auto-generated/>
#pragma warning disable 1591
namespace WeaponShop.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\_Imports.razor"
using WeaponShop;

#line default
#line hidden
#line 6 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\_Imports.razor"
using WeaponShop.Shared;

#line default
#line hidden
#line 7 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenComponent<BlazorStrap.BSCard>(0);
            builder.AddAttribute(1, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#line 3 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                  CardType.Deck

#line default
#line hidden
            ));
            builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(3, "\r\n");
#line 4 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
     foreach (string item in listaTest)
    {
        if (item.Contains("4"))
        {

#line default
#line hidden
                builder2.AddContent(4, "            ");
                builder2.OpenComponent<BlazorStrap.BSCard>(5);
                builder2.AddAttribute(6, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#line 8 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                           Color.Danger

#line default
#line hidden
                ));
                builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder3) => {
                    builder3.AddMarkupContent(8, "\r\n                ");
                    builder3.OpenComponent<BlazorStrap.BSCard>(9);
                    builder3.AddAttribute(10, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#line 9 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                                  CardType.Body

#line default
#line hidden
                    ));
                    builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder4) => {
                        builder4.AddMarkupContent(12, "\r\n                    ");
                        builder4.OpenComponent<BlazorStrap.BSCard>(13);
                        builder4.AddAttribute(14, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#line 10 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                                      CardType.Title

#line default
#line hidden
                        ));
                        builder4.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder5) => {
                            builder5.AddContent(16, "Nazwa w Liscie");
                        }
                        ));
                        builder4.CloseComponent();
                        builder4.AddMarkupContent(17, "\r\n                    ");
                        builder4.OpenComponent<BlazorStrap.BSCard>(18);
                        builder4.AddAttribute(19, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#line 11 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                                      CardType.Text

#line default
#line hidden
                        ));
                        builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder5) => {
                            builder5.AddContent(21, "TO: ");
                            builder5.AddContent(22, 
#line 11 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                                                          item

#line default
#line hidden
                            );
                        }
                        ));
                        builder4.CloseComponent();
                        builder4.AddMarkupContent(23, "\r\n                    ");
                        builder4.OpenComponent<BlazorStrap.BSButton>(24);
                        builder4.AddAttribute(25, "Class", "btn btn-primary");
                        builder4.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 12 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                                                                IncrementCount

#line default
#line hidden
                        ));
                        builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder5) => {
                            builder5.AddContent(28, "Click me");
                        }
                        ));
                        builder4.CloseComponent();
                        builder4.AddMarkupContent(29, "\r\n                ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(30, "\r\n            ");
                }
                ));
                builder2.CloseComponent();
                builder2.AddMarkupContent(31, "\r\n");
#line 15 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
        }

#line default
#line hidden
                builder2.AddContent(32, "        ");
                builder2.OpenComponent<BlazorStrap.BSCard>(33);
                builder2.AddAttribute(34, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#line 16 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                       Color.Dark

#line default
#line hidden
                ));
                builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder3) => {
                    builder3.AddMarkupContent(36, "\r\n            ");
                    builder3.OpenComponent<BlazorStrap.BSCard>(37);
                    builder3.AddAttribute(38, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#line 17 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                              CardType.Body

#line default
#line hidden
                    ));
                    builder3.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder4) => {
                        builder4.AddMarkupContent(40, "\r\n                ");
                        builder4.OpenComponent<BlazorStrap.BSCard>(41);
                        builder4.AddAttribute(42, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#line 18 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                                  CardType.Title

#line default
#line hidden
                        ));
                        builder4.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder5) => {
                            builder5.AddContent(44, "Nazwa w Liscie");
                        }
                        ));
                        builder4.CloseComponent();
                        builder4.AddMarkupContent(45, "\r\n                ");
                        builder4.OpenComponent<BlazorStrap.BSCard>(46);
                        builder4.AddAttribute(47, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#line 19 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                                  CardType.Text

#line default
#line hidden
                        ));
                        builder4.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder5) => {
                            builder5.AddContent(49, "TO: ");
                            builder5.AddContent(50, 
#line 19 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                                                      item

#line default
#line hidden
                            );
                        }
                        ));
                        builder4.CloseComponent();
                        builder4.AddMarkupContent(51, "\r\n                ");
                        builder4.OpenComponent<BlazorStrap.BSButton>(52);
                        builder4.AddAttribute(53, "Class", "btn btn-primary");
                        builder4.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, 
#line 20 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
                                                            IncrementCount

#line default
#line hidden
                        ));
                        builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder5) => {
                            builder5.AddContent(56, "Click me");
                        }
                        ));
                        builder4.CloseComponent();
                        builder4.AddMarkupContent(57, "\r\n            ");
                    }
                    ));
                    builder3.CloseComponent();
                    builder3.AddMarkupContent(58, "\r\n        ");
                }
                ));
                builder2.CloseComponent();
                builder2.AddMarkupContent(59, "\r\n");
#line 23 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
    }

#line default
#line hidden
            }
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 26 "C:\Users\sztander\source\repos\WeaponShopSolutions\WeaponShop\Pages\Counter.razor"
       
    int currentCount = 0;

    List<string> listaTest = new List<string>() { "jeden", "dwa", "trzy", "4", "piec", "6", "siedem", "8" };

    void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
