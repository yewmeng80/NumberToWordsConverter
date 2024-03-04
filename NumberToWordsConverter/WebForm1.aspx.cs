using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumberToWordsConverter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            divMessage.Visible = false;
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = NumberToWordsConverter.Convert(Convert.ToDouble(txtInput.Text));
            }
            catch (Exception ex)
            {
                divMessage.Visible = true;
                divMessage.Attributes.Add("class", "alert alert-danger");
                divMessage.InnerText = ex.ToString();
            }
           
        }
    }
}