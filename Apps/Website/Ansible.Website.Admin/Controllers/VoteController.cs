using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ansible.Website.Admin.Controllers
{
    public class VoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}