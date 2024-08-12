using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Script.Serialization;

namespace ProductWebSite
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public class saneproducts
        {


            public int? product_code { get; set; }

            [StringLength(50)]
            public string product_name { get; set; }
            public int? quantity { get; set; }

            public double? rate { get; set; }

            public double? taxamount { get; set; }

            public double? taxpercentage { get; set; }

            public double? grosstotal { get; set; }
        }

        protected void insert(object sender, EventArgs e)
        {
            string ApiUrl = "https://localhost:44318/api/tbl_product_master_trans";

            var thayuproduct = new
            {
                product_code = txt_product_code.Text.Trim(),
                product_name = txt_product_name.Text.Trim(),
                quantity = txt_quantity.Text.Trim(),
                rate = txt_rate.Text.Trim(),
                taxpercentage = txt_percentage.Text.Trim(),
                taxamount = (
                           Convert.ToInt32(txt_quantity.Text.Trim()) *
                           Convert.ToInt32(txt_rate.Text.Trim())
                           ) / Convert.ToInt32(txt_percentage.Text.Trim()),


                grosstotal = (
                           Convert.ToInt32(txt_quantity.Text.Trim()) *
                           Convert.ToInt32(txt_rate.Text.Trim())
                               ) +

                               (
                           Convert.ToInt32(txt_quantity.Text.Trim()) *
                           Convert.ToInt32(txt_rate.Text.Trim())
                           ) / Convert.ToInt32(txt_percentage.Text.Trim()),

            };
            string inputjson = (new JavaScriptSerializer()).Serialize(thayuproduct);
            HttpClient client = new HttpClient();
            HttpContent inputcontent = new StringContent(inputjson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(ApiUrl + "/tbl_product_master_trans", inputcontent).Result;
        }
    }
}