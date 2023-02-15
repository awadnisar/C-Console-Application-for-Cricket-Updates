using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab_Project
{
    internal class Team
    {
        private string teamName, captainName, ownerName;
        public Team(string teamName, string captainName, string ownerName)
        {
            this.teamName = teamName;
            this.captainName = captainName;
            this.ownerName = ownerName;
        }
        
        public string getTeamName()
        {
            return teamName;
        }

        public string getCaptainName()
        {
            return captainName;
        }

        public string getOwnerName()
        {
            return ownerName;
        }
    }
}
