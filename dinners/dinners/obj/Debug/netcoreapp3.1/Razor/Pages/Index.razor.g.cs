#pragma checksum "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37b72a2e3025e5714bde83002ce4a8b9e2798186"
// <auto-generated/>
#pragma warning disable 1591
namespace dinners.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\repos\personal\dinners\dinners\dinners\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repos\personal\dinners\dinners\dinners\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\repos\personal\dinners\dinners\dinners\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\repos\personal\dinners\dinners\dinners\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\repos\personal\dinners\dinners\dinners\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\repos\personal\dinners\dinners\dinners\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\repos\personal\dinners\dinners\dinners\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\repos\personal\dinners\dinners\dinners\_Imports.razor"
using dinners;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\repos\personal\dinners\dinners\dinners\_Imports.razor"
using dinners.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\repos\personal\dinners\dinners\dinners\_Imports.razor"
using dinners.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row m-5");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row bg-light");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-bordered");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<thead class=\"thead-dark\">\r\n                    <tr>\r\n                        <th>what ingredient do you want to use up?</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 16 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                     if (Ingredients.Any())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                         foreach (var ingredient in Ingredients)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                            ");
            __builder.OpenElement(16, "tr");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                                          (() => SetIngredientsForUpdate(ingredient))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "\r\n                                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 21 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                                     ingredient.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 23 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                        ");
            __builder.AddMarkupContent(24, "<tr><td colspan=\"6\"><strong>No ingredients available</strong></td></tr>\r\n");
#nullable restore
#line 28 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row bg-light");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "class", "table table-bordered");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.AddMarkupContent(35, "<thead class=\"thead-dark\">\r\n                    <tr>\r\n                        <th>Title</th>\r\n                        <th>Servings</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(36, "tbody");
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 43 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                     if (Recipes.Any())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                         foreach (var recipe in Recipes)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                            ");
            __builder.OpenElement(39, "tr");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                                          (() => SetRecipesForUpdate(recipe))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "\r\n                                ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 48 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                                     recipe.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 49 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                                     recipe.Servings

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 51 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                        ");
            __builder.AddMarkupContent(50, "<tr><td colspan=\"6\"><strong>No recipes available</strong></td></tr>\r\n");
#nullable restore
#line 56 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\repos\personal\dinners\dinners\dinners\Pages\Index.razor"
       

    List<Ingredients> Ingredients = new List<Ingredients>();
    protected override async Task OnInitializedAsync()
    {
        await RefreshIngredients();
    }

    private async Task RefreshIngredients()
    {
        Ingredients = await service.GetIngredientsAsync();
    }

    Ingredients UpdateIngredients = new Ingredients();
    private void SetIngredientsForUpdate(Ingredients ingredients)
    {
        UpdateIngredients = ingredients;
    }

    List<Recipes> Recipes = new List<Recipes>();

    private async Task RefreshRecipes()
    {
        Recipes = await service.GetRecipesAsync();
    }

    Recipes UpdateRecipes = new Recipes();
    private void SetRecipesForUpdate(Recipes recipes)
    {
        UpdateRecipes = recipes;
    }

    private async Task UpdateRecipesData()
    {
        await service.UpdateRecipesAsync(UpdateRecipes);
        await RefreshRecipes();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductServices service { get; set; }
    }
}
#pragma warning restore 1591
