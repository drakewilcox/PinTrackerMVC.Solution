using System.Threading.Tasks;
using RestSharp;

namespace PinTrackerMVC.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("https://pinballmap.com/api/v1/");
      RestRequest request = new RestRequest("machines/", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

     public static async Task<string> GetLocationByZone(int zone)
    {
      RestClient client = new RestClient("https://pinballmap.com/api/v1/");
      RestRequest request = new RestRequest($"locations/?region=Portland&by_zone_id={ zone }", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> GetAllByName(string machineName)
    {
      RestClient client = new RestClient("https://pinballmap.com/api/v1/");
      RestRequest request = new RestRequest($"locations/?region=Portland&by_machine_name={ machineName }", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content; 
    }

    public static async Task<string> GetByLocationId(int locationId)
    {
      RestClient client = new RestClient("https://pinballmap.com/api/v1");
      RestRequest request = new RestRequest($"locations/{ locationId }/machine_details", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content; 
    }

      public static async Task<string> GetByLocationName(string locationName)
    {
      RestClient client = new RestClient("https://pinballmap.com/api/v1/");
      RestRequest request = new RestRequest($"locations/?region=Portland&by_location_name={ locationName }", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content; 
    }



  }
}