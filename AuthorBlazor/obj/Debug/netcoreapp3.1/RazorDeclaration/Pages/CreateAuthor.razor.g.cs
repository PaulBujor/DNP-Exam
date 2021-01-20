#pragma checksum "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\Pages\CreateAuthor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "743b8d3bdd7825e8d320a23bf40843547feaa347"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AuthorBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\_Imports.razor"
using AuthorBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\_Imports.razor"
using AuthorBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\Pages\CreateAuthor.razor"
using AuthorBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\Pages\CreateAuthor.razor"
using AuthorBlazor.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/author")]
    public partial class CreateAuthor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\Pages\CreateAuthor.razor"
       
	private Author author = new Author();
	private string ErrorMessage = "";

	private async Task Submit()
	{
		ErrorMessage = "";
		try
		{
			await AuthorService.AddAuthorAsync(author);
			author = new Author();
		}
		catch (Exception e)
		{
			ErrorMessage = e.Message;
		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthorService AuthorService { get; set; }
    }
}
#pragma warning restore 1591
