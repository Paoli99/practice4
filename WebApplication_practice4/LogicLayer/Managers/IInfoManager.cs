using Git.Pracice_4.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Git.Pracice_4.Logic
{
    public interface IInfoManager
    {
        List<Info> GetAllInfo();

        Info CreateStudent(string studentName);

        Info UpdateStudent(Info student);

        Info DeleteStudent(Info student);
    }
}
