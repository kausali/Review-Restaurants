using System;
using System.ComponentModel.DataAnnotations;


namespace RESTauranter.Models
{
    public class Review
    {
        public int id { get; set; }

        [Required(ErrorMessage="Name cannot be less than 2 characters!")]
        [MinLength(2)]
        public string name { get; set; }

        [Required(ErrorMessage="Restaurant Name cannot be less than 2 characters!")]
        [MinLength(2)]
        public string rest_name { get; set; }


        [Required(ErrorMessage="Review cannot be less than 10 characters!")]
        [MinLength(10)]
        public string review { get; set; }


        [Required(ErrorMessage="Please select the rating from the drop down menu!")] 
        public int stars { get; set; }


        [Required(ErrorMessage="Please select the date from the past!")] 
        public string date { get; set; }
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}
    }
}

//all the name here should match the database table/column names!!