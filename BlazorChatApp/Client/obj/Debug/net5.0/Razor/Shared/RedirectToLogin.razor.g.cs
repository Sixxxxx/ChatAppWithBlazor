#pragma checksum "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\Shared\RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "722220ce8cb5b7211e4f43fa59d829d2cb616cfa"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorChatApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using BlazorChatApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using BlazorChatApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\_Imports.razor"
using BlazorChatApp.Client.Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\Shared\RedirectToLogin.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\jcuud\Documents\Dev\BlazorChatApp\BlazorChatApp\Client\Shared\RedirectToLogin.razor"
       
    protected override void OnInitialized()
    {
        Navigation.NavigateTo($"authentication/login?returnUrl={Uri.EscapeDataString(Navigation.Uri)}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChatManager _chatManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _stateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
