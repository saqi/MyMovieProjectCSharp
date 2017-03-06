using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mcl = ClassLayer;
using mdl = DataLayer.DataLayer;

namespace BusinessLayer
{
    public class BusinessLayer
        {

        public mcl.Films GetFilms(string csvPath)
        {
            using (mdl dl1 = new mdl())
            {
                return dl1.GetCsvData(csvPath);
            }
            //-- TODO: raise error if needed
        }





    }
}
