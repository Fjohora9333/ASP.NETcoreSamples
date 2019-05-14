using AFSClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace AFSOEC.Models
{
    [ModelMetadataType(typeof(FarmMetadata))]
    
    public partial class Farm : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield return ValidationResult.Success;

        }
    }


    public partial class FarmMetadata : IValidatableObject
    {
        
        public int FarmId { get; set; }
        [DisplayName("Farm Name")]
        [Required]
        [AFSCapitalize]
        public string Name { get; set; }
        [AFSCapitalize]
        [RequiredIfOtherFieldIsNull("Email")]
        public string Address { get; set; }
        [AFSCapitalize]
        [RequiredIfOtherFieldIsNull("County")]
        public string Town { get; set; }
        [AFSCapitalize]
        [RequiredIfOtherFieldIsNull("Town")]
        public string County { get; set; }
        [DisplayName("Province Code")]
        [Required]
        [Remote("ChecProvinceCode", "Remotes")]
        public string ProvinceCode { get; set; }
        [DisplayName("Postal Code")]
        [RequiredIfOtherFieldIsNull("Email")]
        [AFSPostalZipCodeValidation("ProvinceCode")]
        public string PostalCode { get; set; }
        [DisplayName("Home Phone")]
        [AFSPhoneValidation]
        public string HomePhone { get; set; }
        [DisplayName("Cell Phone")]
        [AFSPhoneValidation]
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Directions { get; set; }
        [DisplayName("Date Joined")]
        [DisplayFormat(DataFormatString ="{0:dd MMM yyyy}")]
        [DateCanntBeInFuture]
        public DateTime? DateJoined { get; set; }
        [DisplayName("Last Contact")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [CheckLastContactDate("DateJoined")]
        [DateCanntBeInFuture]
        public DateTime? LastContactDate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield return ValidationResult.Success;
        }
    }
}
