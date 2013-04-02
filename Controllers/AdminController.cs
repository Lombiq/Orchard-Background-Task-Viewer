/*
 * In this controller we'll dive a bit deeper into the built-in services of Orchard as well as learn how to create and edit content items.
 * This controller is an admin controller: the user will be able to only access it with sufficient privilages to access the dashboard.
 */

using System.Linq;
using System.Web.Mvc;
using Orchard;
using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Data;
using Orchard.Environment.Extensions;
using Orchard.Localization;
using Orchard.Mvc;
using Orchard.Security;
using Orchard.UI.Admin;
using Orchard.UI.Notify;
using Orchard.Tasks;
using Piedone.BackgroundTaskViewer.ViewModels;
using System.Collections.Generic;
using Orchard.Tasks.Scheduling;

namespace Piedone.BackgroundTaskViewer.Controllers
{
    [Admin]
    public class AdminController : Controller
    {
        private readonly IEnumerable<IScheduledTask> _scheduledtask;
        private readonly IEnumerable<IBackgroundTask> _backgroundtask;

        public Localizer T { get; set; }

        public AdminController(IEnumerable<IScheduledTask> scheduledtask, IEnumerable<IBackgroundTask> backgroundtask)
        {
            _scheduledtask = scheduledtask;
            _backgroundtask = backgroundtask;
            T = NullLocalizer.Instance;
        }
        public ActionResult Index() 
        {
            return View();
        }

        public ActionResult BackgroundTasks()
        {
            var lista = new List<BackgroundTaskViewModel>();

            foreach (var OneBakcgroundTask in _backgroundtask)
	        {
                lista.Add(new BackgroundTaskViewModel { BackgroundTaskName = OneBakcgroundTask.GetType().Name.ToString() });
	        };
            return View(lista);
        }

        public ActionResult ScheduledTasks()
        {
            var lista = new List<ScheduledTaskViewModel>();
            foreach (var OneScheduledTask in _scheduledtask)
	        {
                lista.Add(new ScheduledTaskViewModel { ScheduledTaskName = OneScheduledTask.GetType().Name.ToString() });
	        };
            return View(lista);
        }

    }
}