using System;
using System.Collections.Generic;
using System.Text;
using Git.Pracice_4.Logic.Models;

namespace Git.Pracice_4.Logic.Managers
{
    public class InfoManager
    {
        public List<Info> GetAllInfo()
        {
            /*string projectTitle = _config.GetSection("Project").GetSection("Title").Value;
            string dbConnection = _config.GetConnectionString("Database");

            Console.Out.WriteLine($"We are connecting to.... {dbConnection}");*/



            return new List<Info>()
            {
                // new Info() {Name = $"Mauricio from env: {projectTitle}" },
                new Info() {Name = $"Mauricio from env: " },
                new Info() {Name = "Will" },
                new Info() {Name = "Alice" },
            };
        }

        public Info CreateStudent(string studentName)
        {
            return new Info()
            {
                Name = studentName
            }; 
        }

        public Info UpdateStudent(Info student)
        {
            student.Name = "updated";
            return student; 
        }

        public Info DeleteStudent(Info student)
        {
            student.Name = "deleted";
            return student;
        }


    }
}
