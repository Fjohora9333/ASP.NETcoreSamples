using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace AFSClassLibrary
{
    public class RequiredIfOtherFieldIsNullAttribute : ValidationAttribute
    {
        private readonly string _otherProperty;
        public RequiredIfOtherFieldIsNullAttribute(string otherProperty)
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

            if (otherPropertyValue == null || otherPropertyValue as string == string.Empty)
            {
                if (value == null || value as string == string.Empty)
                {
                    
                    ErrorMessage = "{0} and {1} can not be null or empty at the same time.";
                    return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName, _otherProperty));
                }
            }

            return null;
        }
    }
}
