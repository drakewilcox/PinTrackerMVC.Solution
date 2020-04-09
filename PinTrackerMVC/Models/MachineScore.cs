using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PinTrackerMVC.Models 
{
  public class MachineScore
  {
    public int id { get; set; }
    public int location_machine_xref_id { get; set; }
    public int score { get; set; }


    public static List<MachineScore> ScoreById(string LmxId)
    {
      var apiCallTask = ApiHelper.GetScoreByID(LmxId);
      var result = apiCallTask.Result; 

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<MachineScore> detailsList = JsonConvert.DeserializeObject<List<MachineScore>>(jsonResponse ["machine_scores"].ToString());

      return detailsList; 
    }
  } 
}
