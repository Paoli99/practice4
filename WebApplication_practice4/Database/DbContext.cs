using Git.Pracice_4.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Git.Pracice_4.Database
{
    public class DbContext
    {
        public List<Info> InfoTable { get; set; }

        public DbContext()
        {
            //
            InfoTable = new List<Info>()
            {
                // new Info() {Name = $"Mauricio from env: {projectTitle}" },
                new Info() { Name = $"Mauricio"},
                new Info() { Name = "Will" },
                new Info() { Name = "Alice" }
            };
        }

        public Info AddStudent(Info student)
        {
            InfoTable.Add(student);
            return student; 
        }

        public Info UpdateStudent(Info studentToUpdate)
        {
            Info foundStudent = InfoTable.Find(student => student.CI == studentToUpdate.CI);

            /*foreach(var student in InfoTable)
            {
                if(student.Name == studentToUpdate.Name)
                {
                    foundStudent = student;
                    break; 
                }
            }*/

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
