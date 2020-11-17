using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        private bool _clear = false;
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

        protected async void ButtonEquals_Click(object sender, EventArgs e)
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
                        using (var client = new HttpClient())
                        {
                            var num1 = Convert.ToInt32(ViewState["Value1"]);
                            var num2 = Convert.ToInt32(ViewState["Value2"]);
                            var response = await client.GetAsync("http://localhost/CalculatorAPI/addition{" + num1 + "}/{" + num2 + "}/");

                            if(response.IsSuccessStatusCode)
                            {
                                var result = await response.Content.ReadAsStringAsync();
                                dynamic returnObject = JsonConvert.DeserializeObject(result);
                                calc_result.Value = Convert.ToString(returnObject.result);
                            }
                        }
                        //calc_result.Value = _calculator.Add(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Subtraction")
                    {
                        using (var client = new HttpClient())
                        {
                            var num1 = Convert.ToInt32(ViewState["Value1"]);
                            var num2 = Convert.ToInt32(ViewState["Value2"]);
                            var response = await client.GetAsync("http://localhost/CalculatorAPI/subtraction{" + num1 + "}/{" + num2 + "}/");

                            if (response.IsSuccessStatusCode)
                            {
                                var result = await response.Content.ReadAsStringAsync();
                                dynamic returnObject = JsonConvert.DeserializeObject(result);
                                calc_result.Value = Convert.ToString(returnObject.result);
                            }
                        }
                    }
                    else if ((string)ViewState["Operation"] == "Multiplication")
                    {
                        using (var client = new HttpClient())
                        {
                            var num1 = Convert.ToInt32(ViewState["Value1"]);
                            var num2 = Convert.ToInt32(ViewState["Value2"]);
                            var response = await client.GetAsync("http://localhost/CalculatorAPI/multiplication{" + num1 + "}/{" + num2 + "}/");

                            if (response.IsSuccessStatusCode)
                            {
                                var result = await response.Content.ReadAsStringAsync();
                                dynamic returnObject = JsonConvert.DeserializeObject(result);
                                calc_result.Value = Convert.ToString(returnObject.result);
                            }
                        }
                    }
                    else if ((string)ViewState["Operation"] == "Division")
                    {
                        using (var client = new HttpClient())
                        {
                            var num1 = Convert.ToInt32(ViewState["Value1"]);
                            var num2 = Convert.ToInt32(ViewState["Value2"]);
                            var response = await client.GetAsync("http://localhost/CalculatorAPI/division{" + num1 + "}/{" + num2 + "}/");

                            if (response.IsSuccessStatusCode)
                            {
                                var result = await response.Content.ReadAsStringAsync();
                                dynamic returnObject = JsonConvert.DeserializeObject(result);
                                calc_result.Value = Convert.ToString(returnObject.result);
                            }
                        }
                    }
                    else if ((string)ViewState["Operation"] == "Percentage")
                    {
                        using (var client = new HttpClient())
                        {
                            var num1 = Convert.ToInt32(ViewState["Value1"]);
                            var num2 = Convert.ToInt32(ViewState["Value2"]);
                            var response = await client.GetAsync("http://localhost/CalculatorAPI/percentage{" + num1 + "}/{" + num2 + "}/");

                            if (response.IsSuccessStatusCode)
                            {
                                var result = await response.Content.ReadAsStringAsync();
                                dynamic returnObject = JsonConvert.DeserializeObject(result);
                                calc_result.Value = Convert.ToString(returnObject.result);
                            }
                        }
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