using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UczeSB
{
    internal class Movie
    {
        public string title;
        public string director;
        public int score;
        public static int moviesCount = 0;

        public Movie(string aTitle, string aDirector, int aScore)
        {
            title = aTitle;
            director = aDirector;  
            score = aScore;
            moviesCount++; 
        }
        public int getMoviesCount()
        {
            return moviesCount;
        }
        
    }
}
