﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MoM.Module.Dtos;
using MoM.Module.Interfaces;
using MoM.Module.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MoM.Web.Controllers.Api
{
    [Route("api/[controller]")]
    public class ModulesController : Controller
    {
        private readonly IModuleService Service;

        public ModulesController()
        {
            Service = new ModulesService();
        }

        [HttpGet]
        [Route("getinstalledmodules")]
        public IEnumerable<ExtensionInfoDto> GetInstalledModules()
        {
            return Service.GetInstalledModules();
        }
    }
}
