using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4_Ynfante.Models;

namespace HW4_Ynfante.Controllers
{
    public class HomeController : Controller
    {
        private SeasonScheduleContext context { get; set; }

        public HomeController(SeasonScheduleContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var schedule = context.Schedules.OrderBy(
                s => s.WeekId).ToList();
            return View(schedule);
        }
    }
}
