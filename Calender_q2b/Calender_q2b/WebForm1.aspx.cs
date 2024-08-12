using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calender_q2b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date.ToString("dddd")=="Monday")
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
            }
            DateTime dt1=new DateTime(DateTime.Now.Year,08,21);
            DateTime dt2=new DateTime(DateTime.Now.Year,08,22);
            DateTime dt3=new DateTime(DateTime.Now.Year,08,23);
            DateTime dt4=new DateTime(DateTime.Now.Year,08,24);
            DateTime dt5=new DateTime(DateTime.Now.Year,08,25);
            DateTime dt6=new DateTime(DateTime.Now.Year,08,15);
            DateTime dt7=new DateTime(DateTime.Now.Year,08,19);

           
            if (e.Day.Date==dt1|| e.Day.Date == dt2|| e.Day.Date == dt4|| e.Day.Date == dt3|| e.Day.Date == dt5)
            {
                e.Cell.BackColor=System.Drawing.Color.Aqua;
                e.Day.IsSelectable = false;
            }

            if ( e.Day.Date == dt6|| e.Day.Date == dt7)
            {
                e.Cell.BackColor = System.Drawing.Color.GreenYellow;
                e.Cell.Text = "Holiday";
            }

        }

    }
}