#pragma checksum "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45754c9272c3f8339bd1cd504c236eebd1238e32"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.SEVER.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using ASM.SEVER;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using ASM.SEVER.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using ASM.SHARE.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using ASM.SEVER.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Study\NET106\ASM\ASM.SEVER\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    public partial class DetailModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show ");
            __builder.AddAttribute(2, "id", "myModal");
            __builder.AddAttribute(3, "style", "display:block; background-color: rgba(10,10,10,.8); ");
            __builder.AddAttribute(4, "aria-modal", "true");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog modal-dialog-centered ");
            __builder.AddAttribute(8, "style", "min-width:50%");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-content");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-header  bg-dark ");
            __builder.OpenElement(13, "h5");
            __builder.AddAttribute(14, "class", "modal-title text-light");
            __builder.AddAttribute(15, "id", "exampleModalLabel");
#nullable restore
#line 10 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
__builder.AddContent(16, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "btn-close btn-danger text-light fs-3");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
                                                                                      ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "data-bs-dismiss", "modal");
            __builder.AddAttribute(23, "aria-label", "Close");
            __builder.AddContent(24, "X");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n      ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "modal-body");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "row");
#nullable restore
#line 17 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
             foreach(var item in fields)
            {

               var displayName = GetDisplayName(item);
               if(displayName != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-6");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-sm-12  fw-bold fs-5");
#nullable restore
#line 25 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
__builder.AddContent(34, displayName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-sm-10 font-monospace");
#nullable restore
#line 29 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
                                      
                                        var value = item.GetValue(Model) ?? "Không có dữ liệu";
                                    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "span");
            __builder.AddAttribute(39, "style", " white-space: nowrap; \r\n  overflow: hidden;\r\n  text-overflow: ellipsis; /* text-overflow: clip; */");
#nullable restore
#line 34 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
__builder.AddContent(40, value);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                                    <hr>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
                        }

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n      ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "modal-footer");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-secondary");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
                                                                    ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "data-bs-dismiss", "modal");
            __builder.AddContent(50, "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
                                                                  ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "Chỉnh sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "D:\Study\NET106\ASM\ASM.SEVER\Components\DetailModal.razor"
       

    [Parameter]
    public object Model { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private PropertyInfo[] fields;
    protected override Task OnInitializedAsync()
    {
        fields = Model.GetType().GetProperties();

        return base.OnInitializedAsync();
    }

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    private Task ModalOk()
    {
        return OnClose.InvokeAsync(true);
    }

    private string GetDisplayName( PropertyInfo propInfo)
    {
        var attribute = propInfo.GetCustomAttributes(typeof(DisplayNameAttribute), true)
      .Cast<DisplayNameAttribute>().SingleOrDefault();
        if (attribute == null)
            return null;

        return attribute.DisplayName;
        
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
