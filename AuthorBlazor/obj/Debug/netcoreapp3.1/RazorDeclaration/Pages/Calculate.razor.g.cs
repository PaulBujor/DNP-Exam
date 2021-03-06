#pragma checksum "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\Pages\Calculate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "988ddf2e5214306166ed109e79a517d6040dd4d6"
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
#line 2 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\Pages\Calculate.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calculate")]
    public partial class Calculate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Paul\Desktop\293176-Exam-A20\AuthorBlazor\Pages\Calculate.razor"
       
	private VolumeResult volume = new VolumeResult();
	private VolumeResult result;
	private bool saveResult = false;
	private string ErrorMessage = "";

	private async Task Submit()
	{
		if (volume.Type == null)
		{
			ErrorMessage = "Please choose a type!";
		}
		else
		{
			ErrorMessage = "";
			try
			{
				if (saveResult)
					result = await VolumeService.PostVolumeAsync(volume.Height, volume.Radius, volume.Type);
				else
					result = await VolumeService.GetVolumeAsync(volume.Height, volume.Radius, volume.Type);
				volume = new VolumeResult();
			} catch (Exception e)
			{
				ErrorMessage = e.Message;
			}
		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VolumeService VolumeService { get; set; }
    }
}
#pragma warning restore 1591
