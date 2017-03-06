using System;
using mbl = BusinessLayer.BusinessLayer;
using mcl = ClassLayer;


namespace MyNovusProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mbl bl1 = new mbl();
            mcl.Films films = bl1.GetFilms(@"C:\Users\C855-1G_\Documents\Visual Studio 2015\Projects\MyNovusProject\MyNovusProject\TestData.csv");

            bl1 = null;
        }
    }
}