using Circle;
using Movie_Database_Lab;

List<Movie> details = new List<Movie>()
{
    new Movie("Hot Rod", "Comedy", 2005),
    new Movie("Scooby-Doo", "Cartoon", 1999),
    new Movie("Halloween", "Horror", 2000),
    new Movie("Magic Mike", "Romantic Comedy", 2015),
    new Movie("Moana", "Cartoon", 2016),
    new Movie("Pearl Harbor", "War", 2008),
    new Movie("Saw", "Horror", 1990),
    new Movie("Unbroken", "War", 2016),
    new Movie("Cadet Kelly", "Romantic Comedy", 2003),
    new Movie("Smile", "Horror", 2023),
};

//intro
Console.WriteLine("Welcome to the Movie List Application!");

//begining loop
bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("There are 10 Movies in the list. What option are you interested in?");
    Console.WriteLine("1. View All Movie Details");
    Console.WriteLine("2. View by Category");
    Console.WriteLine("3. View by Movie");
    Console.WriteLine("4. View by Year Released");

    //Option Choice
    int movieChoice = int.Parse(Console.ReadLine());

    //View All
    if (movieChoice == 1)
    {
        foreach (Movie m in details)
        {
            Console.WriteLine(m.GetMovie());
                //.OrderBy(d => d.Category));
        }
    }
    //View Department
    else if (movieChoice == 2)
    {
        Console.WriteLine("Which Category would you like to view? Cartoon, Horror, War, Comedy, or Romantic Comedy?");
        string category = Console.ReadLine().ToLower().Trim();
        foreach (Movie m in details.Where(d => d.Category.ToLower().Trim() == category))
        {
            Console.WriteLine(m.GetMovie());
        }

    }
    else if (movieChoice == 3)
    {
        Console.WriteLine("Which Movie would you like more information on?");
        string title = Console.ReadLine().ToLower().Trim();
        foreach (Movie m in details.Where(d => d.Title.ToLower().Trim() == title))
        {
            Console.WriteLine(m.GetMovie());
        }

    }
    else if (movieChoice == 4)
    {
        Console.WriteLine("What Year Realease Date would you like to see?");
        int year = int.Parse(Console.ReadLine().Trim());
        foreach (Movie m in details.Where(d => d.Year == year))
        {
            Console.WriteLine(m.GetMovie());
        }
    }

    runProgram = Validator.GetContinue();

}