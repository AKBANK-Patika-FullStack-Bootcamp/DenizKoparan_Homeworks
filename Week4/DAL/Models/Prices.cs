using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Prices
    {
        [Key]
        public int PriceID { get; set; }
        public string Price { get; set; }
        public int BrandID { get; set; }
    }
}
