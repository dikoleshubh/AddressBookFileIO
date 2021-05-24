using System;
using System.Collections.Generic;

namespace Product_Review_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome To Product Review Management********");
            //UC1
            //Creating a List of ProductReview and Adding values into List.
            List<ProductReview> productReviewlist = new List<ProductReview>()
            {
                new ProductReview(){ ProductID = 13, UserID = 13, Rating = 4, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 14, UserID = 14, Rating = 2, Review = "Not Good", isLike = false},
                new ProductReview(){ ProductID = 15, UserID = 15, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 16, UserID = 16, Rating = 2.5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 17, UserID = 17, Rating = 9, Review = "Nice", isLike = true},
                new ProductReview(){ ProductID = 18, UserID = 18, Rating = 7, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 19, UserID = 19, Rating = 10, Review = "Nice", isLike = true},
            };
            foreach (var list in productReviewlist)
            {
                Console.WriteLine("Product Id :" + list.ProductID + "\t" + "User Id :" + list.UserID + "\t" + "Rating :" + list.Rating + "\t" + "Review :" + list.Review + "\t" + "Is Like :" + list.isLike);
            }
            Console.ReadLine();
        }
    }
}
