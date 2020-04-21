using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            DataTable dt;
            dt = BaseHelper.ejecutarConsulta("SELECT * FROM VIDEO", CommandType.Text);
            ViewData["tablaVideo"] = dt.Rows.Count;
            return View();
        }

    }
}
