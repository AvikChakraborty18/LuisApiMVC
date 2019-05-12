using ADBot.Models;
using ADBot.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace ADBot.Controllers
{
    public class AddUtteranceController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> GetExampleData(string jsonText)
        {
            Utterance utterance = JsonConvert.DeserializeObject<Utterance>(jsonText);
            ViewBag.SyncOrAsync = "Asynchronous";
            return Json(await AddUtterances.ApiCall(jsonText), JsonRequestBehavior.AllowGet);
        }
    }
} 