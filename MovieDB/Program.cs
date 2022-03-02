// See https://aka.ms/new-console-template for more information
using MovieDB;

//PopulateMovies();


Console.WriteLine("Welcome to the movie Database");
DisplayMovies();

Console.WriteLine("How would you like to select your movie? Enter a [Title] or [Genre]:");
string userChoice = Console.ReadLine().ToLower().Trim();

if(userChoice == "title")
{
    SearchMovieTitle();
}
else if(userChoice == "genre")
{
    GetMovieGenre();    

}


static void PopulateMovies()
{
    using (MovieDBContext context = new MovieDBContext())
    {
        List<Movie> movies = new List<Movie>();
        movies.Add(new Movie()
        {
            Title = "Seven Samurai",
            Genre = "Classic",
            RunTime = 307
        });
        movies.Add(new Movie()
        {
            Title = "Face Off",
            Genre = "Action",
            RunTime = 138
        });
        movies.Add (new Movie()
        {
            Title = "National Treasure",
            Genre = "Action",
            RunTime = 131
        });
        movies.Add(new Movie()
        {
            Title = "Con Air",
            Genre = "Action",
            RunTime = 123
        });
        movies.Add(new Movie()
        {
            Title = "Ghost Rider",
            Genre = "Action",
            RunTime = 110
        });
        movies.Add(new Movie()
        {
            Title = "Lord of War",
            Genre = "Drama",
            RunTime = 123
        });
        movies.Add(new Movie()
        {
            Title = "Knowing",
            Genre = "Thriller",
            RunTime = 121
        });
        movies.Add(new Movie()
        {
            Title = "City of Angels",
            Genre = "Drama",
            RunTime = 114
        });
        movies.Add(new Movie()
        {
            Title = "Vampire Kiss",
            Genre = "Drama",
            RunTime = 103
        });
        movies.Add(new Movie()
        {
            Title = "The Rock",
            Genre = "Action",
            RunTime = 129
        });
        context.AddRange(movies);
    }

}

static List<Movie> GetMovieGenre()
{
    using (MovieDBContext context = new MovieDBContext())
    {
        Console.WriteLine("Enter the genre that you would like to search.");
        string selectedGenre = Console.ReadLine();
        List<Movie> moviesG = context.Movies.Where(x => x.Genre == selectedGenre).ToList();
        return moviesG;
    }
}

static List<Movie> SearchMovieTitle()
{
    using (MovieDBContext context = new MovieDBContext())
    {
        Console.WriteLine("Enter the Title of a movie.");
        string selectedTitle = Console.ReadLine();
        List<Movie>movieTitles = context.Movies.Where(x => x.Title == selectedTitle).ToList();
        return movieTitles;
    }
}

static void DisplayMovies()
{
    using (MovieDBContext context = new MovieDBContext())
    {
        foreach (Movie m in context.Movies)
        {
            Console.WriteLine($"{m.Title}\t Genre: {m.Genre}\t Runtime:{m.RunTime}");
        }
    }
}