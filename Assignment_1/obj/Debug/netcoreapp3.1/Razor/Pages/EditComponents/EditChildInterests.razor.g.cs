#pragma checksum "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff8874b651c2f6dc3f0d67b5be0d748a2c2478dd"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>EditChildInterests</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor"
                  _childInterest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor"
                                                  EditInterest

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "label");
                __builder2.AddContent(11, " Interest ");
                __builder2.AddContent(12, 
#nullable restore
#line 12 "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor"
                      _counter

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(13, ":");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\r\n        Interest:<br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor"
                                _childInterest.InterestId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _childInterest.InterestId = __value, _childInterest.InterestId))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _childInterest.InterestId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    \r\n    ");
                __builder2.OpenElement(24, "label");
                __builder2.AddContent(25, " ");
                __builder2.AddContent(26, 
#nullable restore
#line 18 "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor"
             _confirmationMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(27, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n    ");
                __builder2.AddMarkupContent(29, "<p class=\"actions\">\r\n        <button class=\"btn btn-outline-dark\" type=\"submit\">Edit</button>\r\n    </p>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n<br>\r\n");
            __builder.OpenComponent<Assignment_1.Pages.Popup.Popup>(31);
            __builder.AddAttribute(32, "IsOpened", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\University\DNP\Assignment_1\Assignment_1\Pages\EditComponents\EditChildInterests.razor"
                  _isPopupOpened

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
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
