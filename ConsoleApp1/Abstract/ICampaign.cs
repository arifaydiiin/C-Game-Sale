using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstract
{
    interface ICampaign
    {
        void addcampaign(Campaign campaign);
        void updatecampaign(Campaign campaign,int gelendeger);
        void deletecampaign(Campaign campaign);
    }
}
