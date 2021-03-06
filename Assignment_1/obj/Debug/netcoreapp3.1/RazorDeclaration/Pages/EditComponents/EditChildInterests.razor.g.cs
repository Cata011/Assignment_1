#pragma checksum "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff8874b651c2f6dc3f0d67b5be0d748a2c2478dd"
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
#nullable restore
#line 2 "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor"
using Assignment_1.Pages.Popup;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditChildInterests/{FamilyToEdit}")]
    public partial class EditChildInterests : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor"
       
    [Parameter]
    public string FamilyToEdit { get; set; }

    FileContext _fileContext = new FileContext();
    private List<ChildInterest> _childInterests = new List<ChildInterest>();
    private ChildInterest _childInterest = new ChildInterest();
    private Child _child = new Child();
    private Family _family = new Family();
    private int _counter = 0;
    private string _confirmationMessage = "";

    private bool _isPopupOpened;

    protected async override Task OnInitializedAsync()
    {
        Refresh();
    }

    private void EditInterest()
    {
        _childInterests[_counter].Update(_childInterest);
        _counter++;
        if(_counter < _childInterests.Count)
        {
            Refresh();
        }
        else if (_child.ChildInterests.Count == 0)
        {
            Refresh();
        }
        else
        {
            _family = _fileContext.Families.First(dummy => dummy.HouseNumber == _family.HouseNumber && dummy.StreetName.Equals(_family.StreetName));
            _child.ChildInterests = _childInterests;
            _fileContext.SaveChanges();
            NavigationManager.NavigateTo("/ViewFamily");
        }
    }

    private void Refresh()
    {
        _family = Service.GetAllFamilies().FirstOrDefault(f => (f.StreetName + f.HouseNumber).Equals(FamilyToEdit));
        _child = _family.Children.First(f => f.Id == 2);    //TODO: this is design flaw. Instead of 2 it should be childId from Child Interest but can't do that.
        _childInterests = _child.ChildInterests;
        _isPopupOpened = false;
        if (_child.ChildInterests.Count == 0)
        {
            _confirmationMessage = "No data is present to edit";
            _isPopupOpened = true;
        }
        else
        {
            _childInterest = _childInterests[_counter];
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService Service { get; set; }
    }
}
#pragma warning restore 1591
