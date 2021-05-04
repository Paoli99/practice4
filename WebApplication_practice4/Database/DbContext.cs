using Git.Pracice_4.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Git.Pracice_4.Database
{
    public class DbContext : IDbContext
    {
        public List<Info> InfoTable { get; set; }

        public DbContext()
        {
            //
            InfoTable = new List<Info>()
            {
                // new Info() {Name = $"Mauricio from env: {projectTitle}" },
                new Info() { ID= "Group-001", Name = $"Mauricio", AvailableSlots = 2},
                new Info() { ID= "Group-002", Name = "Will", AvailableSlots = 2},
                new Info() { ID= "Group-003", Name = "Alice", AvailableSlots = 2}
        };


            
        }

        public Info AddStudent(Info student)
        {
            InfoTable.Add(student);
            return student; 
        }

        public Info UpdateStudent(Info studentToUpdate)
        {
            Info foundStudent = InfoTable.Find(student => student.ID == studentToUpdate.ID);

            foundStudent.Name = studentToUpdate.Name;
            return foundStudent; 
        }

        public Info DeleteStudent(Info studentToDelete)
        { 

            InfoTable.Remove(studentToDelete);
            return studentToDelete; 

        }

        public List<Info> GetAll()
        {
            
            return InfoTable;
        }


    }
}
