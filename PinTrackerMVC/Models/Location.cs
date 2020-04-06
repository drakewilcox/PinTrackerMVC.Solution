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
public class LocationMachineXref
{
    public int id { get; set; }
    public int location_id { get; set; }
    public int machine_id { get; set; }
    public string condition { get; set; }
    public string ip { get; set; }
    public int? machine_score_xrefs_count { get; set; }
    public List<object> machine_conditions { get; set; }
}

public class Location
{
    public int id { get; set; }
    public string name { get; set; }
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zip { get; set; }
    public string phone { get; set; }
    public string lat { get; set; }
    public string lon { get; set; }
    public string website { get; set; }
    public int? zone_id { get; set; }
    public int region_id { get; set; }
    public int? location_type_id { get; set; }
    public string description { get; set; }
    public int? operator_id { get; set; }
    public string date_last_updated { get; set; }
    public int? last_updated_by_user_id { get; set; }
    public bool? is_stern_army { get; set; }
    public string country { get; set; }
    public string last_updated_by_username { get; set; }
    public int num_machines { get; set; }
    public List<LocationMachineXref> location_machine_xrefs { get; set; }

    public static List<Location> GetLocation(string machineName)
    {
      var apiCallTask = ApiHelper.GetAllByName(machineName);
      var result = apiCallTask.Result; 

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Location> locationList = JsonConvert.DeserializeObject<List<Location>>(jsonResponse["machines"].ToString());

      return locationList; 
    }
}

  public class RootObject
  {
      public List<Location> locations { get; set; }
  }
}
