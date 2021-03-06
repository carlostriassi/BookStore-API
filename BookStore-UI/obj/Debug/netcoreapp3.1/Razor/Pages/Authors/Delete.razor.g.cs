#pragma checksum "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04638e10a833ede84355fa687f58ccec61ecf992"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
           [Authorize(Roles = "Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/delete/{Id}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Are you sure you want to Delete this Record? </h3>\r\n<br>\r\n<hr>\r\n<br>\r\n\r\n\r\n");
#nullable restore
#line 14 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
 if (isFailed)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BookStore_UI.Shared.ErrorMessage>(2);
            __builder.AddAttribute(3, "Message", "Something went wrong with operation");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 17 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 19 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "alert alert-dismissible alert-secondary");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenComponent<BookStore_UI.Shared.LoadingMessage>(10);
            __builder.AddAttribute(11, "Message", "Loading Author Details");
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, ";\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 24 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col col-md-4");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table table-responsive");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<td>First Name</td>\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 31 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
                     Model.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.AddMarkupContent(30, "<td>Last Name</td>\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 35 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
                     Model.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "tr");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.AddMarkupContent(37, "<td>Biography</td>\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 39 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
                     Model.Bio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            <br>\r\n");
#nullable restore
#line 42 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
             if (Model.Books == null || Model.Books.Count == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                ");
            __builder.AddMarkupContent(43, "<div class=\"alert alert-dismissible alert-secondary\">\r\n                    No Books for this author\r\n                </div>\r\n");
#nullable restore
#line 47 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
            }
            else
            {


#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "card");
            __builder.AddAttribute(47, "style", "width: 18rem;");
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.AddMarkupContent(49, "<div class=\"card-header\">\r\n                        <h4>Author\'s Books</h4>\r\n                    </div>\r\n                    ");
            __builder.OpenElement(50, "ul");
            __builder.AddAttribute(51, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 56 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
                         foreach (var book in Model.Books)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "                            ");
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "list-group-item");
            __builder.AddContent(56, 
#nullable restore
#line 58 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
                                                         book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " - ");
            __builder.AddContent(58, 
#nullable restore
#line 58 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
                                                                       book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 59 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 62 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 66 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "<br>\r\n\r\n");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
                  DeleteAuthor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "class", "btn btn-danger");
            __builder.AddMarkupContent(70, "\r\n    <span class=\"oi oi-delete\"></span>\r\n    Delete Author\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
                  BackToList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "class", "btn btn-outline-secondary");
            __builder.AddMarkupContent(75, "\r\n    <span class=\"oi oi-media-skip-backward\"></span>\r\n    Back To List\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\CTriassi\source\repos\BookStore-API\BookStore-UI\Pages\Authors\Delete.razor"
       
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

    private async Task DeleteAuthor()
    {
        bool isSuccess = await _repo.Delete(Endpoints.AuthorsEndpoint, int.Parse(Id));
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
