using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DnDMobile.Classes
{
    class ThisDevice
    {



        public async Task<bool> StoragePermissionEnabled()
        {
            PermissionStatus status = await CrossPermissions.Current.CheckPermissionStatusAsync(Plugin.Permissions.Abstractions.Permission.Storage);
            return false;
        }
    }
}
