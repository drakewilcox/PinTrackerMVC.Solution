using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PinTrackerMVC.Models
{
  public class MachineDetails
  {
    public string HighScore {get; set; }
    public string Condition { get; set; }
    public int LmxId { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public string Manufacturer { get; set; }
    public string Ipdb_Id {get; set; }


    public static List<MachineDetails> GetDetails(int locationId)
    {
      var apiCallTask = ApiHelper.GetByLocationId(locationId);
      var result = apiCallTask.Result; 

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<MachineDetails> detailsList = JsonConvert.DeserializeObject<List<MachineDetails>>(jsonResponse ["machines"].ToString());

      return detailsList; 
    }
  }
}