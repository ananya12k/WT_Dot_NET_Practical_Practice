using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculatorit006
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(Number1.Text);
            int b = Convert.ToInt16(Number2.Text);
            Response.Write("Addition of a and b is "+(a + b));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(Number1.Text);
            int b = Convert.ToInt16(Number2.Text);
            Response.Write("Subtraction of a and b is " + (a-b));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(Number1.Text);
            int b = Convert.ToInt16(Number2.Text);
            Response.Write("Multiplication of a and b is " + (a * b));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(Number1.Text);
            int b = Convert.ToInt16(Number2.Text);

            Response.Write("Divison of a and b is " + (a / b));
        }

        protected void Number2_TextChanged(object sender, EventArgs e)
        {
            int b = Convert.ToInt16(Number2.Text);
            if (b == 0)
            {

                Button4.Visible = false;
                Number2.BorderColor =System.Drawing.Color.Red;

            }
            else

            {

                Button4.Visible = true;
                Number2.BorderColor = System.Drawing.Color.Black;

            }
        }
    }
}