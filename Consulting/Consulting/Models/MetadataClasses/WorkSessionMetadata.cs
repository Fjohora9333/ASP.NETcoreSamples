using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Consulting.Models
{
    [ModelMetadataType(typeof(WorkSessionMetadata))]

    public partial class WorkSession : IValidatableObject
    {
        
        ConsultingContext workSessionContext = ConsultingContext_Singleton.Context();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //ConsultingContext workSessionContext = new ConsultingContext();

            var contractId = workSessionContext.Contract
                            .Where(c => c.ContractId == ContractId)
                            .Select(c => c.ContractId)
                            .FirstOrDefault();
            if (contractId==0)
            {
                yield return new ValidationResult("contractId is not valid", new[] { nameof(ContractId) });
            }
            var consultantId = workSessionContext.Consultant
                            .Where(c => c.ConsultantId == ConsultantId)
                            .Select(c => c.ConsultantId)
                            .FirstOrDefault();

            if (consultantId == 0)
            {
                yield return new ValidationResult("consultantId is not valid", new[] { nameof(ConsultantId) });
            }


            var xcontract = workSessionContext.Contract
                            .Where(c => c.ContractId == ContractId)
                            .Select(c=>c.Closed)
                            .FirstOrDefault();

            if (DateWorked > DateTime.Now)
            {
                yield return new ValidationResult("Date can not be in future", new[] { nameof(DateWorked) });
            }
            if (xcontract==true)
            {
                yield return new ValidationResult("Contract is closed", new[] { nameof(ContractId) });

            }
            if(WorkSessionId!=0)//when the model id (worksessionid) is 0 then it is "create". otherwise it is edit.
            { 
                var hourlyRate = workSessionContext.Consultant
                            .Where(c => c.ConsultantId == ConsultantId)
                            .Select(c => c.HourlyRate)
                            .FirstOrDefault();
                if(HourlyRate==0 || HourlyRate > 1.5 * hourlyRate)
                {
                    yield return new ValidationResult("HourlyRate can not be zero or 1.5 times the base rate.", new[] { nameof(HourlyRate) });

                }
            }
            //var zTotalHoursWorked = 0.00;
            var totalHoursWorked = workSessionContext.WorkSession                               
                                .Where(c => c.ConsultantId == ConsultantId && c.DateWorked == DateWorked)
                                .Sum(c => c.HoursWorked) ;
                                
            if(HoursWorked<=0 )
            {
                yield return new ValidationResult("HoursWorked can not be zero .", new[] { nameof(HourlyRate) });

            }
            if (totalHoursWorked+ HoursWorked > 24)
            {
                yield return new ValidationResult("totalHoursWorked can not be more than 24 hours.", new[] { nameof(HourlyRate) });

            }
            yield return ValidationResult.Success;
        }
    }

    public class WorkSessionMetadata
    {
        public int WorkSessionId { get; set; }
        public int ContractId { get; set; }
        [Required]
        [Remote("CheckDateWorked","Remotes", AdditionalFields = "ContractId")]
        public DateTime DateWorked { get; set; }
        public int ConsultantId { get; set; }
        public double HoursWorked { get; set; }
        public string WorkDescription { get; set; }
        public double HourlyRate { get; set; }
        public double ProvincialTax { get; set; }
        public double TotalChargeBeforeTax { get; set; }
    }
}
