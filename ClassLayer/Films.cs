using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLayer
{
    public class Films : List<Film>
    {
        public Films()
        {

        }

        public Films(List<Film> Films)
        {
            this.AddRange(Films);
        }
    }
}
