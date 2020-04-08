using SEDC.eStore.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.eStore.Entities.Models
{
    public class Cart : BaseEntity
    {
        private Product[] _products;

        public int TotalPrice { get; set; }
    }
}
