using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Git.Pracice_4.Logic.Managers;
using Git.Pracice_4.Logic.Models;
using Git.Pracice_4.Logic;

namespace WebApplication_practice4.Controllers
{
    [ApiController]
    [Route("/api/info")]
    public class InfoController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IInfoManager _infoManager; 
        public InfoController(IConfiguration config, IInfoManager infoManager)
        {
            _config = config;
            _infoManager = infoManager;
        }

        [HttpGet]
        public List<Info> GetInfo()
        {
            return _infoManager.GetAllInfo(); 
        }

        [HttpPost]
        public Info CreateStudents([FromBody] string studentName)
        {
            return _infoManager.CreateStudent(studentName);
        }

        [HttpPut]

        public Info UpdateStudent([FromBody] Info student)
        {
            return _infoManager.UpdateStudent(student);
        }

        [HttpDelete]
        public Info DeleteStudents([FromBody] Info student)
        {
            return _infoManager.DeleteStudent(student);
        }
    }
}
