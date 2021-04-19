using DLS_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;
using PresentationLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DLS_Project.Controllers
{
    public class HomeController : Controller
    {
        //annex
        // правильно пользоваться не контекстом, а менеджерами!!!
        //private EFDBContext _context;
        private DataManager _dataManager;
        private ServicesManager _serviceManager;
        
        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        public HomeController(ILogger<HomeController> logger, /*EFDBContext context,*/ DataManager dataManager)
        {
            _logger = logger;

            //annex
            //_context = context;
            _dataManager = dataManager;
            _serviceManager = new ServicesManager(_dataManager);
        }

        public IActionResult Index()
        {
            //annex
            //var dirs = _context.Directories.Include(x => x.Materials).ToList();

            // нужно работать с "последним" менеджером в цепочке.
            //var dirs = _dataManager.DirRepos.GetAllDirectories(true);
            var dirs = _serviceManager.DirService.TransitDirectoriesToView();

            //return View();
            return View(dirs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
