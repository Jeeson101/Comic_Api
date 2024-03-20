using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Comic_Api.Models.SuperHeroMovies;
using static System.Net.WebRequestMethods;

namespace Comic_Api.Models
{
    public class ComicVineApi
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string _apiKey = "f48d928b4451f3591799d571b6abb87f88081c69";
        //public string OneLongAssString { get; set; } = "";

   //     public async Task<string> GetComicsByNameAsync(string name)
   //     {
			////var url = $"https://comicvine.gamespot.com/api/volumes/?api_key={_apiKey}&filter=name:{name}";
			//var url = "https://comicvine.gamespot.com/api/volumes/?api_key=f48d928b4451f3591799d571b6abb87f88081c69&filter=name:batman&limit=1";

   //         var request = new HttpRequestMessage(HttpMethod.Get, url);
   //         request.Headers.Add("User-Agent", "MyComicApp1.0");

   //         var response = await _httpClient.SendAsync(request);

   //         if (!response.IsSuccessStatusCode)
   //         {
   //             throw new HttpRequestException($"Failed to retrieve data. Status code: {response.StatusCode}");
   //         }

   //         return await response.Content.ReadAsStringAsync();
   //     }
   public async Task<SuperheroComics> GetComicsByNameAsync(string name)
   {
	   var url = $"https://comicvine.gamespot.com/api/volumes/?api_key={_apiKey}&filter=name:{name}&limit=100";

	   var request = new HttpRequestMessage(HttpMethod.Get, url);
	   request.Headers.Add("User-Agent", "MyComicApp1.0");

	   var response = await _httpClient.SendAsync(request);

	   if (!response.IsSuccessStatusCode)
	   {
		   throw new HttpRequestException($"Failed to retrieve data. Status code: {response.StatusCode}");
	   }

	   var xmlContent = await response.Content.ReadAsStringAsync();
	   var doc = XDocument.Parse(xmlContent);
	   var results = doc.Root.Element("results");

	   SuperheroComics.responseVolume[] volumes = results.Elements("volume").Select(v =>
		   new SuperheroComics.responseVolume
		   {
			   name = v.Element("name")?.Value,
			   api_detail_url = v.Element("api_detail_url")?.Value,
			   count_of_issues = ushort.Parse(v.Element("count_of_issues")?.Value),
			   date_added = DateTime.Parse(v.Element("date_added")?.Value) .ToString(),
			   date_last_updated = DateTime.Parse(v.Element("date_last_updated")?.Value).ToString(),
			   deck = v.Element("deck")?.Value,
			   description = v.Element("description")?.Value
		   }).ToArray();

	   SuperheroComics.response responseObj = new SuperheroComics.response
	   {
		   error = doc.Root.Element("error")?.Value,
		   limit = byte.Parse(doc.Root.Element("limit")?.Value),
		   offset = byte.Parse(doc.Root.Element("offset")?.Value),
		   number_of_page_results = byte.Parse(doc.Root.Element("number_of_page_results")?.Value),
		   number_of_total_results = uint.Parse(doc.Root.Element("number_of_total_results")?.Value),
		   status_code = byte.Parse(doc.Root.Element("status_code")?.Value),
		   results = volumes,
		   version = decimal.Parse(doc.Root.Element("version")?.Value)
	   };
	   SuperheroComics comics = new SuperheroComics();
	   comics._response = responseObj;
	   comics._responseVolume = volumes;

	   return comics;
   }

        public async Task<SuperheroComics> SearchHero(string heroName)
        {
	        try
	        {
		        SuperheroComics result = await GetComicsByNameAsync(heroName);
		        Console.WriteLine(result); // Print the JSON result
		        return result;
	        }
	        catch (Exception ex)
	        {
		        Console.WriteLine($"An error occurred: {ex.Message}");
		        return null;
	        }
        }

       public async Task<SuperHeroMovies> GetMovie(string name)
    {
        var url = $"https://comicvine.gamespot.com/api/movies/?api_key={_apiKey}&filter=name:{name}";

        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("User-Agent", "MyComicApp1.0");

        var response = await _httpClient.SendAsync(request);

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Failed to retrieve data. Status code: {response.StatusCode}");
        }

        var xmlContent = await response.Content.ReadAsStringAsync();
        var doc = XDocument.Parse(xmlContent);
        var resultsElement = doc.Root.Element("results");

        if (resultsElement == null)
        {
            throw new InvalidOperationException("Invalid XML response: 'results' element not found.");
        }

        // Assuming only one movie is returned
        var movieElement = resultsElement.Element("movie");

        if (movieElement == null)
        {
           // throw new InvalidOperationException("Invalid XML response: 'movie' element not found within 'results'.");
           var Movie = new SuperHeroMovies
           {
	           _response = new SuperHeroMovies.response
	           { 
		           error = "NotFound"
	           }
           };
           return Movie;
        }

        // Deserialize movie data into SuperHeroMovies object
        var superHeroMovie = new SuperHeroMovies
        {
            _response = new SuperHeroMovies.response
            {
                results = new SuperHeroMovies.responseResults
                {
                    movie = new SuperHeroMovies.responseResultsMovie
                    {
                        name = movieElement.Element("name")?.Value,
                        description = movieElement.Element("deck")?.Value,
                        rating = movieElement.Element("rating")?.Value,
                        release_date = movieElement.Element("release_date")?.Value,
                        runtime = byte.Parse(movieElement.Element("runtime")?.Value ?? "0"),
                        image = new SuperHeroMovies.responseResultsMovieImage
                        {
                            medium_url = movieElement.Element("image")?.Element("medium_url")?.Value
                        }
					}
				}
            }
        };

        return superHeroMovie;
    }
    }
}
