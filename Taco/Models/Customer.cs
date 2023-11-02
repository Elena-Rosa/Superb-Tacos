using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taco.Models

    public class Customer
    {
        public int CustomerId { get; set; }

        public int OrderId { get; set; }

        public string Name {get; set;}

        public string LastName {get; set;}

        public virtual List<CustomerOrder> JoinEntities { get; set; }
    }
