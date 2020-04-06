using Microsoft.AspNetCore.Mvc;
using PinTrackerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PinTrackerMVC.Controllers
{
  public class MachinesController : Controller
  {
    public ActionResult Index()
    {
      
      var allMachines = Machine.GetMachine();
      // List<Machine> thisMachine = allMachines.Where(mach => mach.name == "Monster Bash").ToList();
      return View(allMachines);
    }
  }
}