#pragma checksum "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\Pages\ShowAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe234174070ea4153247ab6937c5c36318a472a6"
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
#line 2 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\Pages\ShowAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\Pages\ShowAdults.razor"
using Assignment.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/showadult")]
    public partial class ShowAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "c:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\Blazor\Pages\ShowAdults.razor"
      
    private IList<Adult> adults;
    private IList<Adult> adultsToShow;

    private void Filter(ChangeEventArgs changeEventArgs){
        int? filterByID = null;
        try{
            filterByID = int.Parse(changeEventArgs.Value.ToString());
        }
        catch(Exception e){ }
        if(filterByID!= null){
            adultsToShow = adults.Where(t => t.Id == filterByID).ToList();
        }
        else{
            adultsToShow = adults;
        }
    }

    protected override async Task OnInitializedAsync(){
        adults = await GetFamilies.allAdultsAsync();
        adultsToShow = adults;
    }

    private async Task RemoveAdult(int id) {
        Adult adultToRemove = adultsToShow.First(t => t.Id == id);
        await GetFamilies.RemoveAdultAsync(id);
        adultsToShow.Remove(adultToRemove);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetFamilies GetFamilies { get; set; }
    }
}
#pragma warning restore 1591
