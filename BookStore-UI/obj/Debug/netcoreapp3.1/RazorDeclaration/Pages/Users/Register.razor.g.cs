#pragma checksum "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Users\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34f6d0a092aa6eff6ed6fced02e27b34e2d588b0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookStore_UI.Pages.Users
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
#line 2 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Users\Register.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Users\Register.razor"
using Contracts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Users\Register.razor"
       

    private RegistrationModel Model= new RegistrationModel();
    bool response  = true;
    private async Task HandleRegistration()
    {
        response = await _authRepo.Register(Model);

        if (response)
        {
            _navMan.NavigateTo("/login");
        }
       
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationRepository _authRepo { get; set; }
    }
}
#pragma warning restore 1591
