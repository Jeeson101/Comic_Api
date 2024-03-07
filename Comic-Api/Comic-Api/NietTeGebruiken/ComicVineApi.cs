using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Comic_Api.NietTeGebruiken
{
    public class ComicVineApi
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string _apiKey = "f48d928b4451f3591799d571b6abb87f88081c69";
        public string OneLongAssString { get; set; } = "";



        public async Task<string> GetComicsByNameAsync(string name)
        {
            var url = $"https://comicvine.gamespot.com/api/volumes/?api_key={_apiKey}&filter=name:{name}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("User-Agent", "MyComicApp1.0");

            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Failed to retrieve data. Status code: {response.StatusCode}");
            }

            return await response.Content.ReadAsStringAsync();
        }

        public async void SearchHero(string heroName)
        {
            var volumesJson = await GetComicsByNameAsync(heroName);

            var xmlResponse = XDocument.Parse(volumesJson);

            // Extract relevant information
            var volumeElements = xmlResponse.Descendants("volume");

            foreach (var volumeElement in volumeElements)
            {
                var volumeId = volumeElement.Element("id")?.Value;
                var volumeName = volumeElement.Element("name")?.Value;
                var volumeDescription = volumeElement.Element("description")?.Value;

                Console.WriteLine($"Volume ID: {volumeId}, Name: {volumeName}, Description: {volumeDescription}");
                OneLongAssString += "ID: " + volumeId + Environment.NewLine + "Volume name: " + volumeName +
                                   Environment.NewLine + "Volume Description" + volumeDescription + Environment.NewLine;
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
