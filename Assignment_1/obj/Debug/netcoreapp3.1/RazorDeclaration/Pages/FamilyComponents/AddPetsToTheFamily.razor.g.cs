#pragma checksum "C:\University\DNP\Assignment_1\Assignment_1\Pages\FamilyComponents\AddPetsToTheFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fef6edabeeecf23f9db9dc1e21462184aeb6d80a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\University\DNP\Assignment_1\Assignment_1\Pages\FamilyComponents\AddPetsToTheFamily.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\University\DNP\Assignment_1\Assignment_1\Pages\FamilyComponents\AddPetsToTheFamily.razor"
using Assignment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\University\DNP\Assignment_1\Assignment_1\Pages\FamilyComponents\AddPetsToTheFamily.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\University\DNP\Assignment_1\Assignment_1\Pages\FamilyComponents\AddPetsToTheFamily.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class AddPetsToTheFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\University\DNP\Assignment_1\Assignment_1\Pages\FamilyComponents\AddPetsToTheFamily.razor"
       
    private FileContext _fileContext = new FileContext();
    private Pet _pet;
    private List<Pet> _pets;
    private string _confirmationMessage = "";

    private void CreatePet()
    {
        try
        {
            _pets.Add(_pet);
            Service.GetCachedFamily().Pets = _pets;
            _pet = new Pet();
            _confirmationMessage = "Family pet added, you can add more";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    protected async override Task OnInitializedAsync()
    {
        _pet = new Pet();
        _pets = new List<Pet>();
    }

    private void Save()
    {
        _fileContext.Families.Add(Service.GetCachedFamily());
        _fileContext.SaveChanges();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService Service { get; set; }
    }
}
#pragma warning restore 1591
