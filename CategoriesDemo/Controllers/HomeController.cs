using CategoriesDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CategoriesDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                var url = "http://www.igeniusgroup.com/people.json";
                WebClient client = new WebClient();
                string reply = client.DownloadString(url);
                List<CustDetail> custDetail = JsonConvert.DeserializeObject<List<CustDetail>>(reply);
                return View(custDetail);
            }
            catch(Exception ex)
            {
               throw ex;
            }           
        }
    }
}