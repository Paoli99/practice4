using Git.Pracice_4.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Git.Pracice_4.Logic
{
    public interface IInfoManager
    {
        List<Info> GetAllInfo();

        Info CreateGroup(string groupID, string groupName, int groupSlots);

        Info UpdateGroup(Info group);

        Info DeleteGroup(Info group);
        
    }
}
