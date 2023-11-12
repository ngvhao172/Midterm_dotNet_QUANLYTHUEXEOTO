﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_GK_QUANLYTHUEXEOTO.Model.Domain
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required, MaxLength(100)]
        public string CustomerEmail { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }

        [Required, MaxLength(100)]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(100)]
        public string Address { get; set; }

        [Required]
        public DateTime Dob { get; set; }
    }
}
