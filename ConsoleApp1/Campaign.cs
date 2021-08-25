using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Campaign
    {
        public Campaign(string campaignname, int campaignvalue)
        {
            this.campaignname = campaignname;
            this.campaignvalue = campaignvalue;
        }
        public int campaignvalue { get; set; }
        public string campaignname { get; set; }
    }
}
