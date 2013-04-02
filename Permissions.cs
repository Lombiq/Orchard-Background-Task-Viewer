using System.Collections.Generic;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.Security.Permissions;

namespace Piedone.BackgroundTaskViewer
{
    /*
     * This is a provider as well.
     */
    [OrchardFeature("Piedone.BackgroundTaskViewer.Contents")]
    public class Permissions : IPermissionProvider
    {
        // Everything's pretty self-explanatory
        public static readonly Permission EditBackgroundTasksList = new Permission { Description = "Edit the Background Tasks List", Name = "EditBackgroundTasksList" };
        // ImpliedBy means that everybody who has the EditPersonList permission also automatically possesses the AccessPersonListDashboard permission
        // as well. Be aware that because of this AccessPersonListDashboard should be written after EditPersonList.
        public static readonly Permission AccessBackgroundTasksList = new Permission { Description = "Access the Background Tasks List", Name = "AccessBackgroundTasksList", ImpliedBy = new[] { EditBackgroundTasksList } };

        public virtual Feature Feature { get; set; }

        public IEnumerable<Permission> GetPermissions()
        {
            return new[]
            {
                EditBackgroundTasksList,
                AccessBackgroundTasksList
            };
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            // Giving some defaults: which user groups should possess which permissions
            return new[]
            {
                new PermissionStereotype
                {
                    // Administrators will have all the permissions by default.
                    Name = "Administrator",
                    // Since AccessPersonListDashboard is implied by EditPersonList we don't have to list the former here.
                    Permissions = new[] { EditBackgroundTasksList }
                },
                new PermissionStereotype
                {
                    Name = "Editor",
                    Permissions = new[] { AccessBackgroundTasksList }
                }
            };
        }
    }

    // NEXT STATION: Let's head back to Controllers/ContentsAdminController!
}