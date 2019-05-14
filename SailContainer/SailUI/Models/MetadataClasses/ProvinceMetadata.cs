using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SailUI.Models
{
    [ModelMetadataType(typeof(ProvinceMetadata))]

    public partial class Province : IValidatableObject
    {
        SailContext _context = SailContext_Singleton.Context();
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Check if the provinceCode already exists int the database
            var checkProvinceCode = _context.Province
                            .Where(p => p.ProvinceCode == ProvinceCode)
                            .Select(p => p.ProvinceCode)
                            .SingleOrDefault();
            if (ProvinceCode != null)
            {
                if (checkProvinceCode != null)
                {
                    yield return new ValidationResult("Province already exists in the database", new[] { nameof(ProvinceCode) });
                }
                else
                {
                    if (ProvinceCode.Length != 2)
                    {
                        yield return new ValidationResult("Province should be exactly 2 letters ", new[] { nameof(ProvinceCode) });
                    }
                    else
                    {
                        ProvinceCode = ProvinceCode.Trim().ToUpper();
                    }
                }
            }
            //check ProvinceNmae already exists in the database
            var checkProvinceNmae = _context.Province
                            .Where(p => p.Name == Name)
                            .Select(p => p.Name)
                            .SingleOrDefault();
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            if (Name==null || Name.Trim()=="" || Name == "")
            {
                yield return new ValidationResult("Name can not be empty ", new[] { nameof(Name) });

            }
            else
            {
                if (checkProvinceNmae != null)
                {
                    yield return new ValidationResult("Province name already exists in the database", new[] { nameof(Name) });

                }
                else
                {
                    Name = textInfo.ToTitleCase(Name.ToLower().Trim());
                }
            }
            //check if CountryCode exists in the database
            var checkCountryCode = _context.Country
                                   .Where(c => c.CountryCode == CountryCode)
                                   .Select(c => c.CountryCode)
                                   .SingleOrDefault();
            if (CountryCode == null)
            {
                yield return new ValidationResult("CountryCode can not be empty", new[] { nameof(Name) });

            }
            else
            {
                if (checkCountryCode == null)
                {
                    yield return new ValidationResult("CountryCode does not exist in the Country table", new[] { nameof(Name) });

                }
                else
                {
                    CountryCode = CountryCode.ToUpper();
                }
            }
            if (TaxCode!=null)
            {
                TaxCode = TaxCode.ToUpper();
            }



            yield return ValidationResult.Success;
        }
    }

    public class ProvinceMetadata
    {
        [Required]
        public string ProvinceCode { get; set; }
        public string Name { get; set; }
        [Required]
        public string CountryCode { get; set; }
        public string TaxCode { get; set; }
        public double TaxRate { get; set; }
        [Remote("CheckCapitalName", "Remotes", AdditionalFields= "ProvinceCode")]
        public string Capital { get; set; }
        public bool IncludesFerderalTax { get; set; }
    }
}
