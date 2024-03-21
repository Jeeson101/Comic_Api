namespace Comic_Api.Models
{
	public class AlignmentListModel
	{
		public List<Hero> GoodHeroList { get; set; }
		public List<Hero> BadHeroList { get; set; }
		public List<Hero> NeutralHeroList { get; set; }
		public List<string> Publishers { get; set; }
	}
}
