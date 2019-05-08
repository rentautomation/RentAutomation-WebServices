using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Rent.Model.Concretes;
using Rent.Business.Concretes;

namespace RentAutomation.WebServices
{
    /// <summary>
    /// CustomerWebService için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class CustomerWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Merhaba Dünya:: Deneme 2";
        }

        [WebMethod]
        public Customer CustomerInsert(Customer customer)
        {
            Customer current = null;
            try
            {
                CustomerBusiness cb = new CustomerBusiness();
                current = cb.SignUp(customer);
            }
            catch (Exception ex)
            {

                throw new Exception("WebServices::CustomerWebService::CustomerInsert: Error Occured. ", ex);
            }
            return current;
        }
    }
}
