using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CampaingManager : ICampaignService
    {

        ICampaignDal _campaingDal;

        public CampaingManager(ICampaignDal campaignDal)
        {
            _campaingDal = campaignDal;
        }


        public void Add(Campaign campaign)
        {
            _campaingDal.Add(campaign);
        }

        public void Delete(Campaign campaign)
        {
            _campaingDal.Delete(campaign);
        }

        public void Update(Campaign campaign)
        {
            _campaingDal.Update(campaign);
        }
    }
}
