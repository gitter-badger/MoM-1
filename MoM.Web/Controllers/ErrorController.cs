﻿using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;
using MoM.Module.Config;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MoM.Web.Controllers
{
    public class ErrorController : Controller
    {
        IOptions<SiteSettings> SiteSettings;

        public ErrorController(IOptions<SiteSettings> siteSettings)
        {
            SiteSettings = siteSettings;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var theme = SiteSettings.Value.Theme;
            ViewData["CssPath"] = "css/" + theme.Module + "/" + theme.Selected + "/";
            return View();
        }
    }
}
