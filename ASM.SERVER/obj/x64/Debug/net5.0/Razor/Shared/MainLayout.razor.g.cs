#pragma checksum "D:\Study\NET106\ASM\ASM.SERVER\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a9f73554d3f7c5aaceceb19490f104ae44257e8"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.SERVER.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using ASM.SERVER;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using ASM.SERVER.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using ASM.SHARE.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using ASM.SERVER.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using Smart.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Study\NET106\ASM\ASM.SERVER\_Imports.razor"
using ASM.SERVER.Helper;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" b-q19p3k4x65>

<link href=""_content/Blazored.Toast/blazored-toast.min.css"" rel=""stylesheet"" b-q19p3k4x65>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.AddAttribute(3, "b-q19p3k4x65");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "sidebar");
            __builder.AddAttribute(6, "b-q19p3k4x65");
            __builder.OpenComponent<ASM.SERVER.Shared.NavMenu>(7);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "main");
            __builder.AddAttribute(11, "b-q19p3k4x65");
            __builder.AddMarkupContent(12, "<div class=\"top-row px-4\" b-q19p3k4x65><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-q19p3k4x65>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "content px-4");
            __builder.AddAttribute(15, "b-q19p3k4x65");
#nullable restore
#line 17 "D:\Study\NET106\ASM\ASM.SERVER\Shared\MainLayout.razor"
__builder.AddContent(16, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
