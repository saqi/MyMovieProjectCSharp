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
        /// <param name="FilmYear"></param>
        public Film(string FilmId, string FilmName, string ImdbRating, string FilmYear) : base(FilmId, FilmName)
        {
            this.ImdbRating = ImdbRating;
            this.FilmYear = FilmYear;
            this.Directors = new List<Director>();
            this.Actors = new List<Actor>();
        }

        /// <summary>
        /// constructor that inherits from the base costructor
        /// </summary>
        /// <param name="FilmID"></param>
        /// <param name="FilmName"></param>
        /// <param name="ImdbRating"></param>
        /// <param name="Directors"></param>
        /// <param name="Actors"></param>
        /// <param name="FilmYear"></param>
        public Film(string FilmID, string FilmName, string ImdbRating, List<Director> Directors, List<Actor> Actors, string FilmYear) : base(FilmID, FilmName)
        {
            this.ImdbRating = ImdbRating;
            this.FilmYear = FilmYear;
            this.Directors = Directors;
            this.Actors = Actors;
        }

        /// <summary>
        /// Declaration of field members
        /// </summary>
        private string imdbRating;
        private string filmYear;


        /// <summary>
        /// Properties for private fields
        /// </summary>
        public string ImdbRating
        {
            get; set; }
        
        public string FilmYear
        {
            get; set; }

        public List<Director> Directors = new List<Director>();
        public List<Actor> Actors = new List<Actor>();

    } // end of Film class
}
