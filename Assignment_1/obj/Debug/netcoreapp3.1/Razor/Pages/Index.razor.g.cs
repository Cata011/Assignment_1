#pragma checksum "C:\University\DNP\Assignment_1\Assignment_1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb9da477cf139b661ba6dd46bc0ebb22454265f5"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_1.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Family Management Aplication</h1>\r\n\r\n<p></p>Please login to be able to modify information or switch between the tabs on the left.\r\n<br>\r\n<p></p>If you don\'t have an account, that means that you might only be able to view data.\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService Service { get; set; }
    }
}
#pragma warning restore 1591
