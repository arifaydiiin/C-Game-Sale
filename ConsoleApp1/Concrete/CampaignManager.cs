using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    class CampaignManager : ICampaign
    {
        public void addcampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.campaignname + "adli kampanya eklendi");
        }

        public void deletecampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.campaignname + "adli kampanya silindi");
        }

        public void updatecampaign(Campaign campaign,int gelendeger)
        {
            Console.WriteLine(campaign.campaignname + "adli kampanyanın "+campaign.campaignvalue+" değeri"+gelendeger+" olarak güncellendi");
            campaign.campaignvalue = gelendeger;
        }

    
    }
}
