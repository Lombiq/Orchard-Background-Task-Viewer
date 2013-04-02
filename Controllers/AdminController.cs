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
using Piedone.BackgroundTaskViewer.Models;
using System.Collections.Generic;

namespace Piedone.BackgroundTaskViewer.Controllers
{
    [Admin]
    public class AdminController : Controller
    {
        private readonly IOrchardServices _orchardServices;
        private readonly IAuthorizer _authorizer;
        private readonly IContentManager _contentManager;
        private readonly ITransactionManager _transactionManager;

        public Localizer T { get; set; }

        public AdminController(IOrchardServices orchardServices, ITransactionManager transactionManager)
        {
            _orchardServices = orchardServices;
            _authorizer = orchardServices.Authorizer; // If we use a service multiple times it's convenient to store its reference individually
            _contentManager = orchardServices.ContentManager;

            _transactionManager = transactionManager;

            T = NullLocalizer.Instance;
        }
        public ActionResult Index() 
        {
            return View();
        }

        public ActionResult BckgrndTasks()
        {
            var lista = new List<BckgrndTask> 
            { 
                new BckgrndTask { BackgroundTask = "egy" },
                new BckgrndTask { BackgroundTask = "kettő" }
            };
            return View(lista);
        }

        public ActionResult ScdldTasks()
        {
            var lista = new List<ScdldTasks>
            {
                new ScdldTasks{ SceduledTaskList = "három"},
                new ScdldTasks{ SceduledTaskList = "négy"}
            };
            return View(lista);
        }

    }
}