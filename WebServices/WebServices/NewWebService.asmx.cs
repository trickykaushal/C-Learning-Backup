using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for NewWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NewWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public  int AddTwo(int a ,int b)
        {
            int sum = 0;
            //foreach( int k in vs)
            //{

            //    sum = sum + k;


            //}
            sum = a + b;
            return sum;
        }

    }
}
