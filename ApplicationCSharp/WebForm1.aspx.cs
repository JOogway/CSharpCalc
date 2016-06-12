using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationCSharp
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        Calculate _Calculate;
        protected void Page_Load(object sender, EventArgs e)
        {
            _Calculate = new Calculate();
        }
        protected void clearbutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = string.Empty;
        }
        protected void zerobutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = numberdisplay.Text + "0";
        }

        protected void onebutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = numberdisplay.Text + "1";
        }

        protected void twobutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = numberdisplay.Text + "2";
        }

        protected void threebutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = numberdisplay.Text + "3";
        }

        protected void fourbutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = numberdisplay.Text + "4";
        }

        protected void fivebutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = numberdisplay.Text + "5";
        }
        protected void sixbutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = numberdisplay.Text + "6";

        }

        protected void sevenbutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = numberdisplay.Text + "7";
        }

        protected void eightbutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = numberdisplay.Text + "8";
        }

        protected void ninebutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = numberdisplay.Text + "9";
        }

        protected void dotbutton_Click(object sender, EventArgs e)
        {
            numberdisplay.Text = numberdisplay.Text + ",";
        }


        protected void plusbutton_Click(object sender, EventArgs e)
        {
            if (numberdisplay.Text == string.Empty)
            {
                Response.Write("<script>alert('Brak danych wejściowych')</script>");
            }
            else
            {
                ViewState["x1"] = numberdisplay.Text;
                ViewState["Operation"] = "Addition";
                numberdisplay.Text = string.Empty;
            }
        }

        protected void minusbutton_Click(object sender, EventArgs e)
        {
            if (numberdisplay.Text == string.Empty)
            {
                Response.Write("<script>alert('Brak danych wejściowych')</script>");
            }
            else
            {
                ViewState["x1"] = numberdisplay.Text;
                ViewState["Operation"] = "Subtraction";
                numberdisplay.Text = string.Empty;
            }
        }

        protected void crossbutton_Click(object sender, EventArgs e)
        {
            if (numberdisplay.Text == string.Empty)
            {
                Response.Write("<script>alert('Brak danych wejściowych')</script>");
            }
            else
            {
                ViewState["x1"] = numberdisplay.Text;
                ViewState["Operation"] = "Multiplication";
                numberdisplay.Text = string.Empty;
            }
        }

        protected void dividebutton_Click(object sender, EventArgs e)
        {
            if (numberdisplay.Text == string.Empty)
            {
                Response.Write("<script>alert('Brak danych wejściowych')</script>");
            }
            else
            {
                ViewState["x1"] = numberdisplay.Text;
                ViewState["Operation"] = "Division";
                numberdisplay.Text = string.Empty;
            }
        }

       

        protected void equalsbutton_Click(object sender, EventArgs e)
        {
            if (numberdisplay.Text == string.Empty)
            {
                Response.Write("<script>alert('Brak danych')</script>");
            }
            else
            {
                ViewState["x2"] = numberdisplay.Text;
                numberdisplay.Text = string.Empty;
                try
                {
                    if ((string)ViewState["Operation"] == "Addition")
                    {
                        numberdisplay.Text = _Calculate.Addition(Convert.ToInt32(ViewState["x1"]), Convert.ToInt32(ViewState["x2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Subtraction")
                    {
                        numberdisplay.Text = _Calculate.Subtraction(Convert.ToInt32(ViewState["x1"]), Convert.ToInt32(ViewState["x2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Multiplication")
                    {
                        numberdisplay.Text = _Calculate.Multiply(Convert.ToInt32(ViewState["x1"]), Convert.ToInt32(ViewState["x2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Division")
                    {
                        numberdisplay.Text = _Calculate.Division(Convert.ToInt32(ViewState["x1"]), Convert.ToInt32(ViewState["x2"])).ToString();
                    }
                    else Response.Write("<script>alert('Brak wybranej operacji')</script>");
                }
                catch (FormatException)
                {
                    Response.Write("<script>alert('Zły format danych')</script>");
                }
            }
        }
    }
}
