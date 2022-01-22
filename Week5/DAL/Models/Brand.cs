using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
        public string GlassName { get; set; }
        public string GlassColor { get; set; }
        public string  GlassType { get; set; }
        public string GlassModel { get; set; }

    }
}
