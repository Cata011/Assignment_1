#pragma checksum "C:\University\DNP\Assignment_1\Assignment_1\Pages\AddFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c6fe517526b6a8d7d76ca9a2b9512d817ab4025"
// <auto-generated/>
#pragma warning disable 1591
namespace family
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddFamily")]
    public partial class AddFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create a new family to add</h3>\r\n\r\n");
#nullable restore
#line 8 "C:\University\DNP\Assignment_1\Assignment_1\Pages\AddFamily.razor"
 switch (_step)
{
    case 0:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<family.AddAdressToFamily>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\University\DNP\Assignment_1\Assignment_1\Pages\AddFamily.razor"
                          () => nextStep()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, " Next step ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 12 "C:\University\DNP\Assignment_1\Assignment_1\Pages\AddFamily.razor"
        break;

    case 1:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<family.AddAdultsToFamily>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\University\DNP\Assignment_1\Assignment_1\Pages\AddFamily.razor"
                          () => nextStep()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, " Next step ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 16 "C:\University\DNP\Assignment_1\Assignment_1\Pages\AddFamily.razor"
        break;

    case 2:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<family.AddChildrenToFamily>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "style", "display: block; float: right; margin-right: 10%; clear: left;");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\University\DNP\Assignment_1\Assignment_1\Pages\AddFamily.razor"
                                                                                                () => nextStep()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, " Next step ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 20 "C:\University\DNP\Assignment_1\Assignment_1\Pages\AddFamily.razor"
        break;

    case 3:

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, " ");
            __builder.OpenComponent<family.AddPetsToTheFamily>(21);
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\University\DNP\Assignment_1\Assignment_1\Pages\AddFamily.razor"
                          () => nextStep()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, " Next step ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 24 "C:\University\DNP\Assignment_1\Assignment_1\Pages\AddFamily.razor"
        break;

        case 4: NavigationManager.NavigateTo("/");
            break;
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\University\DNP\Assignment_1\Assignment_1\Pages\AddFamily.razor"
       
    private int _step = 0;

    private void nextStep()
    {
        _step++;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService Service { get; set; }
    }
}
#pragma warning restore 1591
