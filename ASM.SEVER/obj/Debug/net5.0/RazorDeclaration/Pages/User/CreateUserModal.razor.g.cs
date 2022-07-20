// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ASM.SEVER.Pages.User
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
#line 1 "D:\Study\NET106\ASM\ASM.SEVER\Pages\User\CreateUserModal.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\NET106\ASM\ASM.SEVER\Pages\User\CreateUserModal.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\NET106\ASM\ASM.SEVER\Pages\User\CreateUserModal.razor"
using ASM.SEVER.HttpInterfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\NET106\ASM\ASM.SEVER\Pages\User\CreateUserModal.razor"
using ASM.SHARE.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Study\NET106\ASM\ASM.SEVER\Pages\User\CreateUserModal.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class CreateUserModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "D:\Study\NET106\ASM\ASM.SEVER\Pages\User\CreateUserModal.razor"
       



    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private User user = new();
    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    private async Task ModalOk()
    {
        UserDto userDto = new()
            {
                UserName = user.UserName,
                FullName = user.FullName,
                Address = user.Address , 
                Password = user.Password, 
                Email = user.Email , 
                IsAdmin = user.IsAdmin 
            };
        var result = await userHttpRepo.CreateAsync(userDto);
        if(result.IsSuccess)
        {
            toastService.ShowSuccess(result.Message);
        }
        else
            toastService.ShowError(result.Message);
            
        await OnClose.InvokeAsync(true);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserHttp userHttpRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591