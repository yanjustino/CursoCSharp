using SCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCP.Controllers
{
    public class ProtocoloController : Controller
    {
        //
        // GET: /Protocolo/
        //Install-Package Microsoft.AspNet.Mvc.pt-br -Version 4.0.30506

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
          var protocolo = new Protocolo();
          return View(protocolo);
        }

        [HttpGet]
        public ActionResult Detail(Protocolo protocolo)
        {
          return View(protocolo);
        }

        [HttpPost]
        public ActionResult Create(Protocolo protocolo)
        {
          if (ModelState.IsValid)
          {
            //TODO Persitência
            return RedirectToAction("Detail", protocolo);
          }
          return View(protocolo);
        }
    }
}
