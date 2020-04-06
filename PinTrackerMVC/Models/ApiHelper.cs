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

    public static async Task<string> GetAllByName(string machineName)
    {
      RestClient client = new RestClient("https://pinballmap.com/api/v1/");
      RestRequest request = new RestRequest($"locations/?region=Portland&by_machine_name={machineName}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content; 
    }
  }
}