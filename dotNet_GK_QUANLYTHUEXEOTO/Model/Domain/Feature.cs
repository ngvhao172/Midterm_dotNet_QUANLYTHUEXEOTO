using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotNet_GK_QUANLYTHUEXEOTO.Model.Domain
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public double Price { get; set; }

        public ICollection<Booking> bookings { get; set; }
    }
}
