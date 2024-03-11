using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Comic_Api.Models
{
    public class ComicVineApi
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string _apiKey = "f48d928b4451f3591799d571b6abb87f88081c69";
        public string OneLongAssString { get; set; } = "";

        public async Task<string> GetComicsByNameAsync(string name)
        {
			//var url = $"https://comicvine.gamespot.com/api/volumes/?api_key={_apiKey}&filter=name:{name}";
			var url = "https://comicvine.gamespot.com/api/volumes/?api_key=f48d928b4451f3591799d571b6abb87f88081c69&filter=name:batman&limit=1";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("User-Agent", "MyComicApp1.0");

            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to retrieve data. Status code: {response.StatusCode}");
            }

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> SearchHero(string heroName)
        {
	        try
	        {
		        var result = await GetComicsByNameAsync(heroName);
		        Console.WriteLine(result); // Print the JSON result
		        return result;
	        }
	        catch (Exception ex)
	        {
		        Console.WriteLine($"An error occurred: {ex.Message}");
		        return null;
	        }
        }



        //static async Task Main(string[] args)
        //{
        //    var client = new ComicVineApi();

        //    try
        //    {
        //        await client.SearchHero("Spiderman");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"An error occurred: {ex.Message}");
        //    }
        //}
    }
}
