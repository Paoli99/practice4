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
                new Info() { ID= "001", Name = $"Group", AvailableSlots = 2},
                new Info() { ID= "002", Name = "Group", AvailableSlots = 2},
                new Info() { ID= "003", Name = "Group", AvailableSlots = 2}
        };


            
        }

        public Info AddGroup(Info group)
        {
            InfoTable.Add(group);
            return group; 
        }

        public Info UpdateGroup(Info groupToUpdate)
        {
            Info foundGroup = InfoTable.Find(group => group.ID == groupToUpdate.ID);

            foundGroup.Name = groupToUpdate.Name;
            return foundGroup; 
        }

        public Info DeleteGroup(Info groupToDelete)
        { 

            InfoTable.Remove(groupToDelete);
            return groupToDelete; 

        }

        public List<Info> GetAll()
        {
            
            return InfoTable;
        }


    }
}
