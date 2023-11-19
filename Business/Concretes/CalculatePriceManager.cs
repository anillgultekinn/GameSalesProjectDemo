using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CalculatePriceManager : ICalculatePriceService
    {
        public double CalculatePrice(Game game, Campaign campaign)
        {
            double newPrice = game.UnitPrice - (game.UnitPrice * (campaign.Discount / 100));
            Console.WriteLine("İndirim uygulandı. \nEski fiyat: " + game.UnitPrice + " \nYeni fiyat:" + newPrice);
            return newPrice;
        }
    }
}
