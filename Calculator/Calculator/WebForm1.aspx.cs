using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int a, b,c;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
           
        }

        protected void Sub_Click(object sender, EventArgs e)
        {

        }

        protected void num1_TextChanged(object sender, EventArgs e)
        {
            a= Convert.ToInt32(num1.Text);
        }


        protected void num2_TextChanged(object sender, EventArgs e)
        {
            b= Convert.ToInt32(num2.Text);
        }

        protected void Mul_Click(object sender, EventArgs e)
        {

        }

        protected void Div_Click(object sender, EventArgs e)
        {

        }
    }
}