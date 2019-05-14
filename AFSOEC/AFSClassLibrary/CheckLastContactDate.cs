using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace AFSClassLibrary
{
    public class CheckLastContactDate: ValidationAttribute
    {
        private readonly string _otherProperty;

        public CheckLastContactDate(string otherProperty)
        {
            _otherProperty = otherProperty;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var otherPropertyInfo = validationContext.ObjectType.GetProperty(_otherProperty);
            if (otherPropertyInfo == null)
            {
                return new ValidationResult(string.Format(
                    CultureInfo.CurrentCulture,
                    "Unknown property {0}",
                    new[] { _otherProperty }
                ));
            }
            var otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);

            if (otherPropertyValue != null && value != null)
            {
                if (DateTime.Parse(otherPropertyValue.ToString()) > DateTime.Parse(value.ToString()))
                {
                    ErrorMessage = "{1} must be before {0}";
                    return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName, _otherProperty));
                }

            }

            else if (value != null && otherPropertyValue == null)
            {

                ErrorMessage = "{0} must be null if  {1} is null";
                return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName, _otherProperty));


            }
            return null;

           
        }
    }
}
