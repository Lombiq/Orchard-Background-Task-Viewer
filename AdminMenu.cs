using Orchard;
using Orchard.Localization;
using Orchard.Environment.Extensions;
using Orchard.UI.Navigation;

namespace Piedone.BackgroundTaskViewer
{
   // [OrchardFeature("Piedone.BackgroundTaskViewer")]
    public class AdminMenu : INavigationProvider
    {
        public string MenuName { get { return "admin"; } }
        public Localizer T { get; set; }
        public void GetNavigation(NavigationBuilder builder)
        {
            builder
                .AddImageSet("background-task-lists")
                .Add(T("Tasks"), "7", item => item
                    .Action("Index", "Admin", new { area = "Piedone.BackgroundTaskViewer" })
                 .Add(T("Background Tasks"),"0", subitem => subitem
                     .Action("BackgroundTasks", "Admin", new { area = "Piedone.BackgroundTaskViewer" })
                     .LocalNav())
                 .Add(T("Scheduled Tasks"),"1", subitem => subitem
                     .Action("ScheduledTasks", "Admin", new { area = "Piedone.BackgroundTaskViewer" })
                     .LocalNav()));
        }
    }
}