#pragma checksum "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c34aee04d93cdfbcbf453420947fc74b4de3348e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment.Pages
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
#line 2 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\Pages\AddAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\Pages\AddAdult.razor"
using Assignment.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\Pages\AddAdult.razor"
      
    private Adult newAdult = new Adult();

    public async Task addNewAdult(){
        List<Adult> adults = await GetFamilies.allAdultsAsync();
        int index = adults.FindIndex(item => item.Id == newAdult.Id);
        if (index >= 0) 
        {
            await GetFamilies.UpdateAdultAsync(newAdult);
        }
        else{
            await GetFamilies.addNewAdultAsync(newAdult);
        }
        navigationManager.NavigateTo("/showadult");
    }
    protected override async Task OnInitializedAsync(){
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetFamilies GetFamilies { get; set; }
    }
}
#pragma warning restore 1591
