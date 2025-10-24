using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class UserVotesAttribute : ValidationAttribute
    {


        public string AgeProperty { get; set; }

        public string AllowVoteProperty { get; set; }



        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            var age_property = validationContext.ObjectType.GetProperty(this.AgeProperty);
            var vote_property = validationContext.ObjectType.GetProperty(this.AllowVoteProperty);


            var age_value = (int?)age_property.GetValue(validationContext.ObjectInstance);
            var vote_value = (string?)vote_property.GetValue(validationContext.ObjectInstance);

            if (age_value.HasValue == false || vote_property == null)
            {
                return new ValidationResult("Missing values !");


            }
            else
            {
                if (age_value.Value < 18)
                {
                    return new ValidationResult("No => age < 18");
                }
                else
                if (vote_value != "y")
                {
                    return new ValidationResult("No => vote_value != y");
                }
                else
                {
                    return ValidationResult.Success!;
                }



            }


        }
    }
}
