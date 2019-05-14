using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace AFSClassLibrary
{
    public class AFSPostalZipCodeValidation: ValidationAttribute
    {
        private readonly string _province;
        
        public AFSPostalZipCodeValidation(string province)
        {
            _province = province;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            Regex postalCodePattern = new Regex(@"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$", RegexOptions.IgnoreCase);
            //Regex zipCodePattern = new Regex(@"^{5}[0-9]?{9}[0-9]$", RegexOptions.IgnorePatternWhitespace);
            Regex zipCodePattern = new Regex(@"(^\d{5}$)|(^\d{5}-\d{4}$)", RegexOptions.IgnorePatternWhitespace);

            var provincePropertyInfo = validationContext.ObjectType.GetProperty(_province);
            //var province = validationContext.ToString();
            var provinceValue = "";
            provinceValue = (string)provincePropertyInfo.GetValue(validationContext.ObjectInstance, null);
            provinceValue = provinceValue.ToUpper();

            var country=
            if (value == null || value.ToString() == "")
            {
                return ValidationResult.Success;
            }
            else if (value.ToString().Trim() == "")
            {
                ErrorMessage = "{0} is invalid. Empty spaces not allowed.";
                return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName));

            }
            else if (postalCodePattern.IsMatch(value.ToString()))// || )
            {
                if(provinceValue == "AB"
                    || provinceValue == "BC"
                    || provinceValue == "MB"
                    || provinceValue == "NB"
                    || provinceValue == "NL"
                    || provinceValue == "NS"
                    || provinceValue == "NT"
                    || provinceValue == "NU"
                    || provinceValue == "ON"
                    || provinceValue == "PI"
                    || provinceValue == "QC"
                    || provinceValue == "SK"
                    || provinceValue == "YT")
                {
                    value = value.ToString().Insert(3, " ").ToUpper();
                    try
                    {
                        validationContext
                        .ObjectType
                        .GetProperty(validationContext.MemberName)
                        .SetValue(validationContext.ObjectInstance, value, null);
                        return ValidationResult.Success;

                    }
                    catch (System.Exception)
                    {
                        ErrorMessage = "{0} format is wrong.";
                        return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName));
                    }
                }
                else
                {
                    ErrorMessage = "{0} is an unknown province.";

                    return new ValidationResult(string.Format(ErrorMessage, provinceValue));

                }
                
            }
            else if (zipCodePattern.IsMatch(value.ToString()))
            {
                if (provinceValue != "AB"
                    && provinceValue != "BC"
                    && provinceValue != "MB"
                    && provinceValue != "NB"
                    && provinceValue != "NL"
                    && provinceValue != "NS"
                    && provinceValue != "NT"
                    && provinceValue != "NU"
                    && provinceValue != "ON"
                    && provinceValue != "PI"
                    && provinceValue != "QC"
                    && provinceValue != "SK"
                    && provinceValue != "YT")
                {
                    value = value.ToString().Insert(5, "-").ToUpper();
                    try
                    {
                        validationContext
                        .ObjectType
                        .GetProperty(validationContext.MemberName)
                        .SetValue(validationContext.ObjectInstance, value, null);
                        return ValidationResult.Success;

                    }
                    catch (System.Exception)
                    {
                        ErrorMessage = "{0} format is wrong.";
                        return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName));
                    }
                }
                else
                {

                    ErrorMessage = "{0} is an unknown state.";

                    return new ValidationResult(string.Format(ErrorMessage, provinceValue));
                }
                 
            }
            else
            {
                ErrorMessage = "{0} is unknown format";
                return new ValidationResult(string.Format(ErrorMessage, validationContext.DisplayName));
            }



            //return base.IsValid(value, validationContext);
        }
    }
}
