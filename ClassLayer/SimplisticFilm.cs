using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLayer
{
    public class SimplisticFilm
    {
        /// <summary>
        /// constructor declarations
        /// </summary>
        public SimplisticFilm() { }
        public SimplisticFilm(string FilmId, string FilmName)
        {
            this.FilmId = FilmId;
            this.FilmName = FilmName;
        }

        /// <summary>
        /// Declaration of field members
        /// </summary>
        private string filmId;
        private string filmName;

        /// <summary>
        /// Properties for private fields
        /// </summary>
        public string FilmId
        { get; set; }
        

        public string FilmName
        { get; set; }

    } // end of SimplisticFilm class

}
