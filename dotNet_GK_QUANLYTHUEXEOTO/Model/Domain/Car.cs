using dotNet_GK_QUANLYTHUEXEOTO.Model.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotNet_GK_QUANLYTHUEXEOTO.Model.Domain
{
    public class Car
    {
        [Key]
        public string Id { get; set; }

        [Required, MaxLength(100)]
        public string Model { get; set; }

        [Required, ForeignKey("CarType")]
        public int CarTypeId { get; set; }

        [Required, MaxLength(100)]
        public string Manufacturer { get; set; }

        [Required]
        public CarStatus Status { get; set; }

        public CarType CarType { get; set; }
    }
}
