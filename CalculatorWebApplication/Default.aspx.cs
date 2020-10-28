using CalculatorLibrary;
using System;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        private bool _clear = false;
        ICalculator _calculator = new Calculate();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["_clear"] == null ) ViewState["_clear"] = false;
            _clear = (bool) ViewState["_clear"];
        }

        protected void NumButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (_clear) calc_result.Value = string.Empty;
            calc_result.Value = calc_result.Value + button.Text;
            ViewState["_clear"] = false;
        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Addition";
                ViewState["_clear"] = true;
            }
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Subtraction";
                ViewState["_clear"] = true;
            }
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Multiplication";
                ViewState["_clear"] = true;
            }
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Division";
                ViewState["_clear"] = true;
            }
        }

        protected void ButtonCE_Click(object sender, EventArgs e)
        {
            calc_result.Value = string.Empty;
            ViewState["Value1"] = null;
            ViewState["Operation"] = null;
        }

        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value2"] = calc_result.Value;
                calc_result.Value = string.Empty;

                try
                {
                    if ((string)ViewState["Operation"] == "Addition")
                    {
                        calc_result.Value = _calculator.Add(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Subtraction")
                    {
                        calc_result.Value = _calculator.Subtract(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Multiplication")
                    {
                        calc_result.Value = _calculator.Multiply(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Division")
                    {
                        calc_result.Value = _calculator.Divide(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Percentage")
                    {
                        calc_result.Value = _calculator.Percentage(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else Response.Write("<script>alert('No Operation was recorded.')</script>");
                }
                catch (FormatException)
                {
                    Response.Write("<script>alert('Bad Input Format.')</script>");
                }
            }
        }
    }
}