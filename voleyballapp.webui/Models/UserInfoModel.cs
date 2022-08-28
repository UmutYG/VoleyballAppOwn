using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voleyballapp.entity;

namespace voleyballapp.webui.Models
{
    public class UserInfoModel
    {
        public Team TeamInfo { get; set; }
        public List<Team> FixtureTeams { get; set; }
       
    }
}