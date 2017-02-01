using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLayer
{
    class Films : List<Films>
    {
        public Films()
        {

        }

        public Films(List<Films> Films)
        {
            this.AddRange(Films);
        }
    }
}
