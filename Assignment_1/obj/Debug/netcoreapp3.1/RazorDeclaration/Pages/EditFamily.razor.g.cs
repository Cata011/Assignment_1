#pragma checksum "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f6d7bf204cdbad6162b8a4f8a54b2abd320367d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace edit
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\University\DNP\Assignment_1\Assignment_1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\University\DNP\Assignment_1\Assignment_1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\University\DNP\Assignment_1\Assignment_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\University\DNP\Assignment_1\Assignment_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\University\DNP\Assignment_1\Assignment_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\University\DNP\Assignment_1\Assignment_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\University\DNP\Assignment_1\Assignment_1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\University\DNP\Assignment_1\Assignment_1\_Imports.razor"
using Assignment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\University\DNP\Assignment_1\Assignment_1\_Imports.razor"
using Assignment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\University\DNP\Assignment_1\Assignment_1\_Imports.razor"
using Assignment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\University\DNP\Assignment_1\Assignment_1\_Imports.razor"
using family;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditFamily/{FamilyToEdit}")]
    public partial class EditFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditFamily.razor"
       
    
    [Parameter] public string FamilyToEdit { get; set; }

    private void MoveToEditAdultsPage()
    {
        NavigationManager.NavigateTo("/EditAdults/" + FamilyToEdit);
    }
    
    private void MoveToEditChildrenPage()
    {
        NavigationManager.NavigateTo("/EditChildren/" + FamilyToEdit);
    }
    
    private void MoveToEditPetsPage()
    {
        NavigationManager.NavigateTo("/EditPets/" + FamilyToEdit);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService Service { get; set; }
    }
}
#pragma warning restore 1591
