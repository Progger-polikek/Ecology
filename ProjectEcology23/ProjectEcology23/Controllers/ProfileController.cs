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
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;

        private readonly IConfiguration _config;

        public ProfileController(ILogger<ProfileController> logger, IConfiguration config)
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

        public IActionResult IndexProfile()
        {
            var user = GetUser();
            return View(user[0]);
        }

        [HttpPost]
        public IActionResult IndexProfile(RegistrationViewModel model)
        {
            var user = GetUser(model);
            return View(user[0]);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<Users> GetUser()
        {
            using (IDbConnection db = Connection)
            {
                var result = db.Query<Users>($"SELECT * FROM EcologyUsers where email = 'pochtaivana@mail.com' and password = '123456789'").ToList();

                return result;
            }
        }

        private List<Users> GetUser(RegistrationViewModel model)
        {
            using (IDbConnection db = Connection)
            {
                var result = db.Query<Users>($"SELECT * FROM EcologyUsers where email = '{model.email}' and password = '{model.pass}'").ToList();

                return result;
            }
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
