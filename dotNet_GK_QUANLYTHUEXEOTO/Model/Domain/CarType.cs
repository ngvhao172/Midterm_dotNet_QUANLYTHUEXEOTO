using System.ComponentModel.DataAnnotations;

namespace dotNet_GK_QUANLYTHUEXEOTO.Model.Domain
{
    public class CarType
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)] 
        public string Name { get; set; }

        [Required]
        public double RentPrice { get; set; }

        [Required]
        public byte[] CarImage { get; set; }
    }
}
