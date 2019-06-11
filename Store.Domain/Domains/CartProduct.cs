﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
	public class CartProduct {
		
		public virtual Product Product { get; set; }
		public virtual Cart Cart { get; set; }
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        [Key, Column(Order = 2)]
        public int CartId { get; set; }
        public int Quantity { get; set; }
        public DateTime AddToCartDate { get; set; }
    }
}
