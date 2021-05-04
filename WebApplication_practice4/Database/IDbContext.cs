using Git.Pracice_4.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Git.Pracice_4.Database
{
    public interface IDbContext
    {
        Info AddGroup(Info group);
        Info UpdateGroup(Info groupToUpdate);


        Info DeleteGroup(Info groupToDelete);

        List<Info> GetAll();
    }
}
