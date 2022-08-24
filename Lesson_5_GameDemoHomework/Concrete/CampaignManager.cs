using System;
using System.Collections.Generic;
using System.Text;
using Lesson_5_GameDemoHomework.Abstract;

namespace Lesson_5_GameDemoHomework.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası " + campaign.DiscountRate + " oranıyla eklendi");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası silindi");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası " + campaign.DiscountRate + " oranıyla güncellendi");
        }
    }
}
