using Git.Pracice_4.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Git.Pracice_4.Database
{
    public interface IDbContext
    {
        Info AddStudent(Info student);
        Info UpdateStudent(Info studentToUpdate);


        Info DeleteStudent(Info studentToDelete);

        List<Info> GetAll();
    }
}
