using Pertamina.LPG.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DAOs
{
    public class ConsumerReviewDao : DAO
    {
        public ConsumerReview Insert(ConsumerReview review)
        {
            _context.ConsumerReviews.Add(review);
            _context.SaveChanges();
            return review;
        }

        public List<ConsumerReview> GetReviewByDriver(int driverId)
        {
            return _context.ConsumerReviews.Where(x => x.DrvrID == driverId).ToList();            
        }
    }
}