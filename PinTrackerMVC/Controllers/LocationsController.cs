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
    public ActionResult Index()
    {
      ViewBag.Beaverton = Location.LocationByZone(8);
      ViewBag.Clackamas = Location.LocationByZone(38);
      ViewBag.Downtown = Location.LocationByZone(4);
      ViewBag.Gresham = Location.LocationByZone(10);
      ViewBag.Hillsboro = Location.LocationByZone(5);
      ViewBag.Milwaukie = Location.LocationByZone(434);
      ViewBag.North = Location.LocationByZone(3);
      ViewBag.Northeast = Location.LocationByZone(2);
      ViewBag.Northwest = Location.LocationByZone(6);
      ViewBag.Southeast = Location.LocationByZone(1);
      ViewBag.Southwest = Location.LocationByZone(7);
      ViewBag.Tigard = Location.LocationByZone(9);
      ViewBag.Vancouver = Location.LocationByZone(11);
      ViewBag.Wilsonville = Location.LocationByZone(108);
      
      return View();
    }
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