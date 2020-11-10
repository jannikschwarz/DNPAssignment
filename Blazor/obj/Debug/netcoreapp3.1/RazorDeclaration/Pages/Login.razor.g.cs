#pragma checksum "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1507d1de5b2d2f98ba530caa7715fd6d66d18bb1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\_Imports.razor"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\_Imports.razor"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\Pages\Login.razor"
using Assignment.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin() {
        errorMessage = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
        } catch (Exception e) {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout() {
        errorMessage = "";
        username = "";
        password = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        } catch (Exception e) { }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
