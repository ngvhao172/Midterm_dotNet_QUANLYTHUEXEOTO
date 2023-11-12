using System.ComponentModel.DataAnnotations;


namespace dotNet_GK_QUANLYTHUEXEOTO.Model.Domain
{
    public class Fuel
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public double Price { get; set; }
    }
}
