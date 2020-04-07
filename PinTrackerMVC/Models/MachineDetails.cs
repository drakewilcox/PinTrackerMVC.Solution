using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PinTrackerMVC.Models
{
  public class MachineDetails
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public string Manufacturer { get; set; }
    public string Ipdb_Id {get; set; }
  }
}