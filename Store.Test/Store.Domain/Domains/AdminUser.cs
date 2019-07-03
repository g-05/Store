﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains
{
    [Table("AdminUsers")]
    public class AdminUser : InternalUser
    {
        [Key]
        public int ID { get; set; }

    }
}