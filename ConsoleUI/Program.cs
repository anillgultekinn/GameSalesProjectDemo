using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Id = 1,
                TcNo = "12345678910",
                FirstName = "Anıl",
                LastName = "Gültekin",
                BirthYear = 1997,
                Email = "anil@anil.com"
            };

            UserManager userManager = new UserManager(new AdoNetUserDal(), new GoogleValidationManager());
            userManager.Add(user);
            userManager.Update(user);

            Campaign campaign = new Campaign()
            {
                Id = 1,
                Description = "2024 e kadar geçerli",
                Discount = 25,
                Name = "MUHTEŞEM CUMA"
            };
            CampaingManager campaingManager = new CampaingManager(new EfCampaignDal());
            campaingManager.Add(campaign);

            Game game = new Game()
            {
                Id = 1,
                Name = "GTA 6 ",
                Description = "Tarihin en iyi oyunu",
                UnitInStock = 10000,
                UnitPrice = 4000
            };
            GameManager gameManager = new GameManager(new EfGameDal());
            gameManager.Add(game);

            CalculatePriceManager calculatePriceManager = new CalculatePriceManager();


            Order order = new Order
            {
                Id = 1,
                OrderDate = DateTime.Now,
                CampaingId = 1,
                GameId = 1,
                TotalPrice = calculatePriceManager.CalculatePrice(game, campaign),
                UserId = 1
            };



            OrderManager orderManager = new OrderManager(new EfOrderDal());
            orderManager.Add(order);

        }
    }
}