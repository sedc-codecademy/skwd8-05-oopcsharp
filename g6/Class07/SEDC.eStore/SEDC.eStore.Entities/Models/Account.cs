using SEDC.eStore.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.eStore.Entities.Models
{
    public class Account : BaseEntity
    {
        public long CreditCardNumber { get; set; }
        public string Supplier { get; set; } // Visa, MasterCard ...

        public Account(long creditCardNumber, string supplier)
            : base()
        {
            CreditCardNumber = creditCardNumber;
            Supplier = supplier;
        }
    }
}
