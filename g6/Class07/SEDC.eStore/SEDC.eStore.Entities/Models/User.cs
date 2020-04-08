using SEDC.eStore.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.eStore.Entities.Models
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public Account Account { get; set; }
        public Cart Cart { get; set; }
    }
}
