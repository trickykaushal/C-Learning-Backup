using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Btnadd1_Click(object sender, EventArgs e)
        {
           
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            WebApplication2.ServiceReference1.NewWebServiceSoapClient service1 = new WebApplication2.ServiceReference1.NewWebServiceSoapClient();

            int val1 = Convert.ToInt32(Val1.Text);
            int val2 = Convert.ToInt32(Val2.Text);
            int sum = service1.AddTwo(val1, val2);
            result.Text = Convert.ToString(sum);


        }
    }
}