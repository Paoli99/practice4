using System;
using System.Collections.Generic;
using System.Text;
using Git.Pracice_4.Database;
using Git.Pracice_4.Logic.Models;


namespace Git.Pracice_4.Logic.Managers
{
    public class InfoManager : IInfoManager 
    {
        private readonly IDbContext _dbContext;

        public InfoManager(IDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public List<Info> GetAllInfo()
        {
            /*string projectTitle = _config.GetSection("Project").GetSection("Title").Value;
            string dbConnection = _config.GetConnectionString("Database");

            Console.Out.WriteLine($"We are connecting to.... {dbConnection}");*/

            List<Database.Models.Info> students =  _dbContext.GetAll();
            return DTOMappers.MapStudent(students); 
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
