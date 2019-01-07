using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public string Start()
        {
            return "Hello from <strong>Sample Controller</strong>";
        }
    }
}