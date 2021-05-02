﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WebApplication_practice4.Controllers
{
    [ApiController]
    [Route("[/api/student]")]
    public class StudentController : ControllerBase
    {
        private readonly IConfiguration _config;
        public StudentController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            string projectTitle = _config.GetSection("Project").GetSection("Title").Value;
            string dbConnection = _config.GetConnectionString("Database");

            Console.Out.WriteLine($"We are connecting to.... {dbConnection}");



            return new List<Student>()
            {
                new Student() {Name = $"Mauricio from env: {projectTitle}" },
                new Student() {Name = "Will" },
                new Student() {Name = "Alice" },
            };
        }

        [HttpPost]
        public Student CreateStudents([FromBody] string studentName)
        {
            return new Student()
            {
                Name = studentName
            };
        }

        [HttpGet]
        public Student GetInfo([FromBody] Student student)
        {
            string projectTitle = _config.GetSection("Project").GetSection("Title").Value;
            string dbConnection = _config.GetConnectionString("Database");
            Console.Out.WriteLine($"We are connecting to.... {dbConnection}");

            student.Name = "Info";
            return student;
        }

        [HttpDelete]
        public Student DeleteStudents([FromBody] Student student)
        {
            return student;
        }
    }
}
