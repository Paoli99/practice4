using System;
using System.Collections.Generic;
using System.Text;

namespace Git.Pracice_4.Logic.Models
{
    public static class DTOMappers
    {
        public static List<Info> MapStudent(List<Database.Models.Info> students)
        {
            List<Info> mappedStudents = new List<Info>();

            foreach (Database.Models.Info student in students)
            {
                mappedStudents.Add(new Info()
                {
                    CI = student.CI,
                    Name = student.Name
                });
                
            }

            return mappedStudents; 
        }
    }
}
