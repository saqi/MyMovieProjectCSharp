using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLayer
{
    class Film : SimplisticFilm
    {
        /// <summary>
        /// constructor that inherits from the base costructor
        /// </summary>
        /// <param name="FilmId"></param>
        /// <param name="FilmName"></param>
        public Film(string FilmId, string FilmName) : base(FilmId, FilmName)
        {
        }
        
        /// <summary>
        /// Declaration of field members
        /// </summary>
        private string _imdbRating;
        private string _filmYear;


        /// <summary>
        /// Properties for private fields
        /// </summary>
        public string ImdbRating
        {
            get { return _imdbRating; }
            set { _imdbRating = value; }
        }
        
        public string FilmYear
        {
            get { return _filmYear; }
            set { _filmYear = value; }
        }

        public List<Director> Directors = new List<Director>();
        public List<Actor> Actors = new List<Actor>();

    } // end of Film class
}
