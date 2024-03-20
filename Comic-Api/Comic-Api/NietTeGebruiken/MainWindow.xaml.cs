//using System.Net;
//using System.Net.Http;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;
//using System.Xml.Linq;

//namespace test
//{
//	/// <summary>
//	/// Interaction logic for MainWindow.xaml
//	/// </summary>
//	public partial class MainWindow : Window
//	{
//		private readonly ComicVineApiClient _client;

//		public MainWindow()
//		{
//			InitializeComponent();
//			_client = new ComicVineApiClient("f48d928b4451f3591799d571b6abb87f88081c69");
//		}

//		private async void SearchButton_Click(object sender, RoutedEventArgs e)
//		{
			
//				var naam = volumeNameTextBox.Text;
//				var volumesJson = await _client.GetVolumesByNameAsync(naam);

//				var xmlResponse = XDocument.Parse(volumesJson);

//				// Extract relevant information
//				var volumeElements = xmlResponse.Descendants("volume");

//				foreach (var volumeElement in volumeElements)
//				{
//					var volumeId = volumeElement.Element("id")?.Value;
//					var volumeName = volumeElement.Element("name")?.Value;
//					var volumeDescription = volumeElement.Element("description")?.Value;

//					resultTextBlock.Text += volumeName + Environment.NewLine;
//				}
//		}



//		public class ComicVineApiClient
//		{
//			private readonly HttpClient _httpClient;
//			private readonly string _apiKey;

//			public ComicVineApiClient(string apiKey)
//			{
//				_httpClient = new HttpClient();
//				_apiKey = apiKey;
//			}

//			public async Task<string> GetVolumesByNameAsync(string name)
//			{

//					var url = $"https://comicvine.gamespot.com/api/volumes/?api_key={_apiKey}&filter=name:{name}";

//					var request = new HttpRequestMessage(HttpMethod.Get, url);
//					request.Headers.Add("User-Agent", "MyComicApp1.0");

//					var response = await _httpClient.SendAsync(request);


//					return await response.Content.ReadAsStringAsync();
//			}
//		}


//		class Program
//		{
//			static async Task Main(string[] args)
//			{
//				var apiKey = "f48d928b4451f3591799d571b6abb87f88081c69";
//				var client = new ComicVineApiClient(apiKey);

//				try
//				{
//					var volumesJson = await client.GetVolumesByNameAsync("Spiderman");
//					Console.WriteLine(volumesJson);
//				}
//				catch (Exception ex)
//				{
//					Console.WriteLine($"An error occurred: {ex.Message}");
//				}
//			}
//		}
//}
//}