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
    public class AboutController : Controller
    {
        private readonly ILogger<AboutController> _logger;

        private readonly IConfiguration _config;

        public AboutController(ILogger<AboutController> logger, IConfiguration config)
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

        //public IActionResult Index()
        //{
        //    var item = GetAllPetition();
        //    return View(item);
        //}

        //public IActionResult Index2()
        //{
        //    return View();
        //}

        //public IActionResult Profile()
        //{
        //    var user = GetUser();
        //    return View(user);
        //}

        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public string About(PetitionViewModel model)
        {
            int numberForDB = new Random().Next(10000);
            using (IDbConnection db = Connection)
            {
                db.Query<Petitions>($"INSERT INTO EcologyPetitions (Number,Status,Petition,Result,FIO,AddressPetition) VALUES ({numberForDB},'Отправлено','{model.AboutPetition}', 'Принято', '{model.Name}', '{model.AddressPetition}')");
            }
            //return "Принял " + numberForDB + ' ' + model.Name + ' ' + model.Email + ' ' + model.AboutPetition + ' ' + model.AddressPetition;
            return "Ваша заявка была принята на рассмотрение, спасибо!";
        }

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

        private List<Users> GetUser()
        {
            using (IDbConnection db = Connection)
            {
                var result = db.Query<Users>($"SELECT * FROM EcologyUsers where email = 'spacex@mail.com' and password = '123456789'").ToList();

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

        }

        public class Users
        {
            public int Id { get; set; }
            public string sname { get; set; }
            public string fname { get; set; }
            public string pname { get; set; }
            public string pasport { get; set; }
            public string snils { get; set; }
            public string inn { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string homeplace { get; set; }
            public string password { get; set; }
        }
    }
}
