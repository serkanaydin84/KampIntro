using System;
using Lesson_5_GameDemoHomework.Abstract;
using Lesson_5_GameDemoHomework.Concrete;

namespace Lesson_5_GameDemoHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { 
                Id = 1, 
                FirstName = "Serkan", 
                LastName = "Aydın", 
                TcNo = "2316532156", 
                DateOfBirth = new DateTime(1984, 11, 3) };

            Game game = new Game() { Id = 1, GameName = "CS GO" };

            Campaign campaign = new Campaign() { Id = 1, CampaignName = "Gençlere İndirim", DiscountRate = 15.5 };

            ICustomerCheckService customerCheck = new CustomerCheckManager();
            customerCheck.EDevletValidation(customer1);

            ICustomerService customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);

            IGameService gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Sale(game);
            gameManager.Delete(game);

            ICampaignService campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign);
            campaignManager.UpdateCampaign(campaign);
            campaignManager.DeleteCampaign(campaign);

        }
    }
}
