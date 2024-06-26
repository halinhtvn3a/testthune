﻿using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ReviewService
    {
        private readonly ReviewRepository ReviewRepository = null;
        public ReviewService()
        {
            if (ReviewRepository == null)
            {
                ReviewRepository = new ReviewRepository();
            }
        }
        public Review AddReview(Review Review) => ReviewRepository.AddReview(Review);
        public void DeleteReview(string id) => ReviewRepository.DeleteReview(id);
        public Review GetReview(string id) => ReviewRepository.GetReview(id);
        public List<Review> GetReviews() => ReviewRepository.GetReviews();
        public Review UpdateReview(string id, Review Review) => ReviewRepository.UpdateReview(id, Review);
    }
}
