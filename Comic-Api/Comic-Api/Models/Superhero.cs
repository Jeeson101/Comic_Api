namespace Comic_Api.Models
{
	public class Superhero
	{
		public SuperHeroMovies Movies { get; set; }
		public SuperheroComics Comics { get; set; }

		public Superhero(SuperHeroMovies m , SuperheroComics c)
		{
			Movies = m;
			Comics = c;
		}
	}
}
