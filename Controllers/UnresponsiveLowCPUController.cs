﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BuggyDemoCode.Controllers
{
    public class UnresponsiveLowCPUController : BaseController
    {
        public IActionResult Index()
        {
            return Ok();
        }

        public IActionResult SyncOverAsync()
        {
            var text = ReadTextAsync(string.Format(@"{0}\test.txt", Environment.CurrentDirectory)).Result;

            return Ok(text?.Remove(30));
        }
    }
}