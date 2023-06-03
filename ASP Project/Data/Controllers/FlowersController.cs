using ASP_Project.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Controllers
{
    public class FlowersController : Controller
    {
        private readonly IFlower iflowers;
        private readonly ICategory icategory;

        public FlowersController(IFlower iflowers, ICategory icategory)
        {
            this.iflowers = iflowers;
            this.icategory = icategory;
        }

        public IActionResult Index()
        {
            var flowers = iflowers.GetFlowers();
            return View(flowers);
        }

        [HttpGet] 
        public IActionResult GetAll()
        {
            return Index();
        }
    }
}
