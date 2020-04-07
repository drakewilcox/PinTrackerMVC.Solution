using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net;
using System.IO;
using System.Web;
using System;
namespace PinTrackerMVC.Models
{
  public class Machine
  {
      public int id { get; set; }
      public string name { get; set; }
      public bool? is_active { get; set; }
      public string ipdb_link { get; set; }
      public int year { get; set; }
      public string manufacturer { get; set; }
      public string opdb_id { get; set; }

    public static List<Machine> GetMachine()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Machine> machineList = JsonConvert.DeserializeObject<List<Machine>>(jsonResponse["machines"].ToString());

      return machineList;
    }

     // Incomplete code for PinTrackerAPI.Solution
    
    // public static List<Machine> SearchByName()
    // {
    //   var apiCallTask = ApiHelper.GetAll();
    //   var result = apiCallTask.Result;

    //   JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    //   List<Machine> machineList = JsonConvert.DeserializeObject<List<Machine>>(jsonResponse["machines"].ToString());

    //   return machineList;
    // }
  }
}