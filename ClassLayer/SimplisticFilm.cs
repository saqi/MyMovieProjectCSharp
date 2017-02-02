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
        public SimplisticFilm(string FilmId, string FilmName)
        {
            this.FilmId = FilmId;
            this.FilmName = FilmName;
        }

        /// <summary>
        /// Declaration of field members
        /// </summary>
        private string _filmId;
        private string _filmName;

        /// <summary>
        /// Properties for private fields
        /// </summary>
        public string FilmId
        {
            get { return _filmId; }
            set { _filmId = value; }
        }

        public string FilmName
        {
            get { return _filmName; }
            set { _filmName = value; }
        }

    } // end of SimplisticFilm class

}
