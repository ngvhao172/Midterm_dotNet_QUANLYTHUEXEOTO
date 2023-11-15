using dotNet_GK_QUANLYTHUEXEOTO.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_GK_QUANLYTHUEXEOTO.Model.Domain
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public string CarId { get; set; }

        [Required]
        public int FuelId { get; set; }
        [Required]
        public DateTime FromDate { get; set; }
        [Required]
        public DateTime ToDate { get; set; }

        [Required]
        public double TotalPrice { get; set; }

        [Required]
        public BookingStatus Status { get; set; }

        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public List<Feature> Features { get; set; }
        public Fuel Fuel { get; set; }
    }
}
