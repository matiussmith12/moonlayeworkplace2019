using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkins.Controllers
{
    public class CheckinController : Barebone.Controllers.ControllerBase
    {
        public CheckinController(IStorage storage) : base(storage)
        {
        }

        public ActionResult Index()
        {
            return View();
        } 
    }
}
