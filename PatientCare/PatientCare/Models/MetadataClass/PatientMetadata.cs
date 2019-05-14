using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PatientCare.Models
{
    [ModelMetadataType(typeof(PatientMetadata))]
    public partial class Patient : IValidatableObject
    {
        private PatientCareContext _context;
        public Patient(PatientCareContext context)
        {
            _context = context;
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(FirstName))
            {
                yield return new ValidationResult("First name cannot be empty");
            }
            if (string.IsNullOrEmpty(LastName))
            {
                yield return new ValidationResult("Last Name cannot be empty", new[] { nameof(LastName) });
            }
            if (FirstName != null)
            {
                FirstName = FirstName.Trim();
            }
            if (LastName != null)
            {
                LastName = LastName.Trim();
            }
            if (Address != null)
            {
                Address = Address.Trim();
            }
            if (City != null)
            {
                City = City.Trim();
            }
            if (ProvinceCode != null)
            {
                ProvinceCode = ProvinceCode.ToUpper();
            }
            if (PostalCode != null)
            {
                PostalCode = PostalCode.ToUpper();
            }
            if (DateOfBirth != null)
            {
                if (DateOfBirth > DateTime.Now)
                {
                    yield return new ValidationResult("DateOfBirth can not be in future");
                }
                if (DateOfDeath != null)
                {
                    if (DateOfBirth > DateOfDeath)
                    {
                        yield return new ValidationResult("DateOfDeath can not be before DateOfBirth");
                    }
                    if (DateOfDeath > DateTime.Now)
                    {
                        yield return new ValidationResult("DateOfDeath can not be in future");
                    }
                    if (Deceased == false)
                    {
                        yield return new ValidationResult("Deceased must be checked ");
                    }
                }
                
            }
            if (HomePhone != null)
            {
                if (HomePhone.Length != 10)
                {
                    yield return new ValidationResult("Homephone numbe rshould be exactly 10 numbers");
                }
                else
                {
                    HomePhone = Regex.Replace(HomePhone.ToString(), "[^0-9]+", string.Empty);
                    HomePhone = HomePhone.ToString().Insert(3, "-").Insert(7, "-");
                }
            }



            yield return ValidationResult.Success;
        }
    }
    
    public class PatientMetadata : IValidatableObject
    {
        public int PatientId { get; set; }
        [Remote("CheckPatientExists", "Remotes", AdditionalFields = "LastName,DateOfBirth")]
        public string FirstName { get; set; }
        [Remote("CheckPatientExists", "Remotes", AdditionalFields = "FirstName,DateOfBirth")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Remote("CheckProvinceCode", "Remotes")]
        public string ProvinceCode { get; set; }
        [Remote("CheckPostalCode", "Remotes", AdditionalFields = "ProvinceCode")]
        public string PostalCode { get; set; }
        public string Ohip { get; set; }
        [Remote("CheckPatientExists", "Remotes", AdditionalFields = "FirstName,LastName")]
        public DateTime? DateOfBirth { get; set; }
        public bool Deceased { get; set; }
        public DateTime? DateOfDeath { get; set; }
        //[Remote("CheckPhonePattern","Remotes",AdditionalFields = "ProvinceCode")]
        public string HomePhone { get; set; }
        public string Gender { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();
            yield return ValidationResult.Success;

        }
    }
}
