using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_GK_QUANLYTHUEXEOTO.Model.Domain
{
    public class Account
    {
        [Key, MaxLength(100)]
        [Required(ErrorMessage = "Please input email")]
        [EmailAddress(ErrorMessage = "Invalid Email.")]
        public string EmployeeEmail { get; set; }
        [MaxLength(100), Required(ErrorMessage = "Please input password")]
        public string Password { get; set; }

        [Required]
        public bool Enable { get; set; } = true;

        [Required, ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
