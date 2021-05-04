using Git.Pracice_4.Database;
using Git.Pracice_4.Logic.Models;
using System.Collections.Generic;


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

            List<Database.Models.Info> groups =  _dbContext.GetAll();
            return DTOMappers.MapStudent(groups); 
        }

        public Info CreateGroup(string groupID, string groupName, int groupSlots)
        {
            return new Info()
            {
                Name = groupName,
                ID = groupID,
                AvailableSlots = groupSlots

            };
        }

        public Info UpdateGroup(Info group)
        {
            group.Name = "updated";
            return group; 
        }

        public Info DeleteGroup(Info group)
        {
            group.Name = "deleted";
            return group;
        }

        
    }
}
