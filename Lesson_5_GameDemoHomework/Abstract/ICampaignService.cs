using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_5_GameDemoHomework.Abstract
{
    interface ICampaignService
    {
        void AddCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
    }
}