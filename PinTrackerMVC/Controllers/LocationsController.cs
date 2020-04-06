using Microsoft.AspNetCore.Mvc;
using PinTrackerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PinTrackerMVC.Controllers
{
  public class LocationsController : Controller 
  {
    [HttpPost]
    public ActionResult Search(string search)
    {
      var searchLocation = Location.GetLocation(search);
      return View(searchLocation);
    }
  }
}