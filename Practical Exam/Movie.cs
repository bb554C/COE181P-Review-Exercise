using static System.Console;
using System;
class Movie
{
    static void Main()
    {
        int movieTime;
        string movieName;
        movieName = ReadLine();
        movieTime =  Convert.ToInt32(ReadLine());
        DisplayMovie(movieName, movieTime);
    }
    public static void DisplayMovie(string movie, int time = 90)
    {
        WriteLine("The movie " + movie + " has a running time of " + time.ToString() + " minutes.");
    }
}

