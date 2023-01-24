using System;
namespace Movie_Database_Lab
{
	public class Movie
	{
		//Properties
		public string Category { get; set; }
		public string Title { get; set; }
        public int Year { get; set; }


        //Constructor
        public Movie(string _title, string _category, int _year)
		{
			Category = _category;
			Title = _title;
			Year = _year;
		}
		public Movie()
		{
			Category = "Movie Categories";
			Title = "Coming soon on DVD";
			Year = 1999;

		}
		//methods
		public string GetMovie()
		{
			//details.OrderBy(m >= m.Category)
			return $"{Category}: {Title}: {Year}";
			
        }
	}


}

