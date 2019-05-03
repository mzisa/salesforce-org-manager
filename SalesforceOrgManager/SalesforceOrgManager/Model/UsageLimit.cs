using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesforceOrgManager.Model
{
    class UsageLimit
    {
        string limitName;
        int limitRemaining;
        int limitMax;

        public string LimitName { get => limitName; set => limitName = value; }
        public int LimitRemaining { get => limitRemaining; set => limitRemaining = value; }
        public int LimitMax { get => limitMax; set => limitMax = value; }

        public UsageLimit(string limitName, int limitRemaining, int limitMax)
        {
            this.limitName = limitName;
            this.limitRemaining = limitRemaining;
            this.limitMax = limitMax;
        }
    }
}
