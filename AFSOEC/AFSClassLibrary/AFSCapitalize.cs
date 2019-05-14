using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace AFSClassLibrary
{
    public class AFSCapitalize:ValidationAttribute
    {

        protected override ValidationResult IsValid (object value, ValidationContext validationContext)
        {
            if (value == null || value.ToString() == "")
            {
                return ValidationResult.Success;
            }
            else if (value.ToString().Trim() == "")
            {
                ErrorMessage = "{0} is invalid. Empty spaces not allowed.";
                return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName));

            }
            else
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                //value.ToString().ToLower();
                //value.ToString().Trim();
                value = textInfo.ToTitleCase(value.ToString().ToLower().Trim());
                try
                {
                    validationContext
                    .ObjectType
                    .GetProperty(validationContext.MemberName)
                    .SetValue(validationContext.ObjectInstance, value, null);
                }
                catch (System.Exception)
                {
                    ErrorMessage = "{0} could not be capitalized";
                    return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName));
                }

                return ValidationResult.Success;

            }
            

        }
    }
}
