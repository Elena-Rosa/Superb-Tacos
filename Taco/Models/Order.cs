using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    
using System;

namespace Taco.Models

    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public string TacoName {get; set;}

        public string TacoType {get; set;}

        public string Description {get; set;}

        public virtual List<CustomerOrder> JoinEntities { get; set; }
    }
}
