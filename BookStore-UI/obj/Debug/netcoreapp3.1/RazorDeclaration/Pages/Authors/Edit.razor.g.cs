#pragma checksum "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8cc48020226aff51c721ce3e3a8fe2b2c2b55b8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookStore_UI.Pages.Authors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using BookStore_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using BookStore_UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using BookStore_UI.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using BookStore_UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\_Imports.razor"
using BookStore_UI.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Edit.razor"
           [Authorize(Roles = "Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/edit/{Id}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Edit.razor"
       
    [Parameter]
    public string Id { get; set; }

    private Author Model = new Author();
    private bool isFailed = false;


    protected override async Task OnInitializedAsync()
    {
        Model = await _repo.Get(Endpoints.AuthorsEndpoint, int.Parse(Id));


    }

    private void BackToList()
    {
        _navManager.NavigateTo("/authors/");
    }

    private async Task EditAuthor()
    {
        bool isSuccess = await _repo.Update(Endpoints.AuthorsEndpoint, Model, int.Parse(Id));
        if (isSuccess)
        {
            BackToList();
        }
        else
        {
            isFailed = true;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository _repo { get; set; }
    }
}
#pragma warning restore 1591