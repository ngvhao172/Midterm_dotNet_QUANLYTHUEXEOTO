using dotNet_GK_QUANLYTHUEXEOTO.Model.Data;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_GK_QUANLYTHUEXEOTO.Controller
{
    public class FeatureController
    {
        private BookingCarDbContext dbContext;
        public FeatureController(BookingCarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Feature> GetAllFeature()
        {
            var features = dbContext.Features.ToList();
            return features;
        }
    }
}
