using System;
using System.Web.UI;
using DataLayer;

namespace AspNetAdoNetDemo
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connString = DB.ConnectionString;
        }
    }
}