using Core.ViewModel;

namespace Comic_Api.Models
{
	public class HeroListsViewModel : vmBase
	{
		private List<Hero> _heroesList1;
		public List<Hero> HeroesList1
		{
			get { return _heroesList1; }
			set
			{
				_heroesList1 = value;
				OnPropertyChange(nameof(HeroesList1));
			}
		}

		private List<Hero> _heroesList2;
		public List<Hero> HeroesList2
		{
			get { return _heroesList2; }
			set
			{
				_heroesList2 = value;
				OnPropertyChange(nameof(HeroesList2));
			}
		}
	}
}
