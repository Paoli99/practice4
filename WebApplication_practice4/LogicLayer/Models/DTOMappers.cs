using System;
using System.Collections.Generic;
using System.Text;

namespace Git.Pracice_4.Logic.Models
{
    public static class DTOMappers
    {
        public static List<Info> MapStudent(List<Database.Models.Info> groups)
        {
            List<Info> mappedGroups = new List<Info>();

            foreach (Database.Models.Info group in groups)
            {
                mappedGroups.Add(new Info()
                {
                    ID = group.ID,
                    Name = group.Name,
                    AvailableSlots = group.AvailableSlots
                });
                
            }

            return mappedGroups; 
        }
    }
}
