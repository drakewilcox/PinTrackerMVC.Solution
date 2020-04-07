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
    public ActionResult Search(string searchBy, string search)
    {
      if (searchBy == "Search by machine")
      {
        var searchLocation = Location.GetLocation(search);
      
        foreach (Location location in searchLocation)
        { 
        location.MachineDetails = MachineDetails.GetDetails(location.id);
        }

        return View(searchLocation);
      }
      if (searchBy == "Search by location")
      {
        var searchLocation = Location.LocationByName(search);
        foreach (Location location in searchLocation)
        {
          location.MachineDetails = MachineDetails.GetDetails
          (location.id);
        }
        return View(searchLocation);
      }
      else 
      return View();
    }
  }
}