using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ProjectEcology23.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEcology23.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;

            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public IActionResult Index()
        {
            var item = GetAllPetition();
            return View(item);
        }

        //public IActionResult Index2()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<Petitions> GetAllPetition()
        {
            using (IDbConnection db = Connection)
            {
                var result = db.Query<Petitions>("SELECT * FROM EcologyPetitions").ToList();

                return result;
            }
        }

        public class Petitions
        {
            public int Number { get; set; }
            public int Id { get; set; }
            public string Status { get; set; }
            public DateTime Date { get; set; }
            public string Petition { get; set; }
            public string Result { get; set; }
            public string FIO { get; set; }
            public string AddressPetition { get; set; }
        }
    }
}
