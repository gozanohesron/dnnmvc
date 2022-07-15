using DotNetNuke.Collections;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using NetcareIconicPages.NetcareIconicPages.Models;
using System.Web.Mvc;

namespace NetcareIconicPages.NetcareIconicPages.Controllers
{
    [DnnHandleError]
    public class ICollectiveNetcareController : DnnController
    {
        public ActionResult Index()
        {
            Settings settings = new Settings()
            {
                ProjectId = ModuleContext.Configuration.ModuleSettings.GetValueOrDefault(Constants.ProjectIdConfig, string.Empty),
                PageId = ModuleContext.Configuration.ModuleSettings.GetValueOrDefault(Constants.PageIdConfig, string.Empty)

            };

            return View(settings);
        }
    }
}