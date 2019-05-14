using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace AFSClassLibrary
{
    public class AFSPhoneValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Regex pattern = new Regex(@"^\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$");
            
            if(value == null || value.ToString() == "")
            {
                return ValidationResult.Success;
            }
            else if (value.ToString().Length != 10)
            {
                ErrorMessage = "{0} is invalid phone number. Must contain exactly 10 numbers.";
                return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName));
            }
            else
            {
                try
                {
                    value = Regex.Replace(value.ToString(), "[^0-9]+", string.Empty);
                    value = value.ToString().Insert(3, "-").Insert(7, "-");
                    validationContext
                        .ObjectType
                        .GetProperty(validationContext.MemberName)
                        .SetValue(validationContext.ObjectInstance, value, null);
                }
                catch(System.Exception)
                {
                    ErrorMessage = "{0} is not a valid phone Number.";
                    return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName));
                }
            }
            return ValidationResult.Success;
        }
    }
}
