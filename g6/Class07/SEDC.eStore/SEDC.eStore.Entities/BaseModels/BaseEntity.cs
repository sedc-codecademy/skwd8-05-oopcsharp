using SEDC.eStore.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.eStore.Entities.BaseModels
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        public BaseEntity()
        {
            Id = IdGenerator.GenerateId();
            CreatedOn = DateTime.Now;
        }
    }
}
