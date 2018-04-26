using System;
using System.ComponentModel.DataAnnotations;

namespace RESTauranter.Models
{
    public class Review : BaseEntity {
        public int Id { get; set; }

        [Display(Name = "Reviewer Name")]
        public string ReviewerName { get; set; }

        [Display(Name = "RestaurantName")]
        public string RestaurantName {get; set; }

        [Display(Name = "Review")]
        public string ReviewText { get; set; }

        [Display(Name = "Stars")]
        public int Stars { get; set; }

        [Display(Name = "Date of Visit")]
        public DateTime DateOfVisit { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }


    }
}