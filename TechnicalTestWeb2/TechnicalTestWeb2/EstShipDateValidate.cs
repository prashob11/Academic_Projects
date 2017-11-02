using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using TechnicalTestWeb2.Models;

namespace TechnicalTestWeb2
{
    class EstShipDateValidate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
                            ValidationContext validationContext)
        {
            Shipment shipment = (Shipment)validationContext.ObjectInstance;

            DateTime estShipDate = (DateTime)value;
            DateTime orderPlacedDate = (DateTime)shipment.DateOrderPlaced;
             

            int result = DateTime.Compare(estShipDate, orderPlacedDate.AddHours(24) );

            if (result < 0)
            {
                return new ValidationResult("The estimated ship date must be at least 24 hours after the Date Ordered");
            }
            
            


            return ValidationResult.Success;
        }
    }
}
