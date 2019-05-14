using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AFSClassLibrary
{
    public class DateCanntBeInFuture: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(DateTime.Parse(value.ToString())> DateTime.Now)
            {
                ErrorMessage = "{0} is invalid. This date should not be in future.";
                return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName));
            }
            else
            {
                try
                {
                    validationContext
                        .ObjectType
                        .GetProperty(validationContext.MemberName)
                        .SetValue(validationContext.ObjectInstance, value, null);
                }
                catch(System.Exception)
                {
                    ErrorMessage = "{0} is not a valid date.";
                    return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName));

                }
            }
            return ValidationResult.Success;
        }

    }
}
