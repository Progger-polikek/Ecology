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
    public class RegistrationController : Controller
    {
        private readonly ILogger<RegistrationController> _logger;

        private readonly IConfiguration _config;

        public RegistrationController(ILogger<RegistrationController> logger, IConfiguration config)
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

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public string Registration(RegistrationViewModel model)
        {
            //просто поля эти не добавили на клиент, а в базе они есть, немного не состыковали, поэтому пока так ¯\_(ツ)_/¯
            int pasport = new Random().Next(1000000000,1999999999);
            int inn = new Random().Next(1000000000, 1999999999);
            int snils = new Random().Next(1000000000, 1999999999);
            int phone = new Random().Next(1000000000, 1999999999);
            //так бы, если реальный проект, а не учебный, то, конечно, добавили бы их нормально

            using (IDbConnection db = Connection)
            {
                db.Query($"INSERT INTO EcologyUsers (Id,sname,fname,pname,pasport,snils,inn,phone,email,homeplace,password) VALUES(6,'{model.sname}','{model.name}','{model.pname}', '{pasport}','{snils}','{inn}','8{phone}','{model.email}', '-', '{model.pass}' )");
            }
            //return "Принял " + numberForDB + ' ' + model.Name + ' ' + model.Email + ' ' + model.AboutPetition + ' ' + model.AddressPetition;
            return "Вы зарегистрировались " + model.name + ", спасибо!";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
