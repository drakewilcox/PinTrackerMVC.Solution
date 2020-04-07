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

    public static async Task<string> MachineByName(string searchByMachine)
    {
      RestClient client = new RestClient("https://5000/api/");
      RestRequest request = new RestRequest($"machines/?name={searchByMachine}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}