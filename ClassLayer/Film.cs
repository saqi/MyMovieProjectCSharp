using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLayer
{
    public class Film : SimplisticFilm
    {
        /// <summary>
        /// constructor that inherits from the base costructor
        /// </summary>
        /// <param name="FilmId"></param>
        /// <param name="FilmName"></param>
        /// <param name="imdbRating"></param>
        /// <param name="filmYear"></param>
        public Film(string FilmId, string FilmName, string imdbRating, string filmYear) : base(FilmId, FilmName)
        {
            this.ImdbRating = imdbRating;
            this.FilmYear = filmYear;
            this.Directors = new List<Director>();
            this.Actors = new List<Actor>();
        }

        /// <summary>
        /// constructor that inherits from the base costructor
        /// </summary>
        /// <param name="filmID"></param>
        /// <param name="filmName"></param>
        /// <param name="imdbRating"></param>
        /// <param name="directors"></param>
        /// <param name="actors"></param>
        /// <param name="filmYear"></param>
        public Film(string filmID, string filmName, string imdbRating, List<Director> directors, List<Actor> actors, string filmYear) : base(filmID, filmName)
        {
            this.ImdbRating = imdbRating;
            this.FilmYear = filmYear;
            this.Directors = directors;
            this.Actors = actors;
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
