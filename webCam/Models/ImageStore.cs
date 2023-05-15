using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webCamExample_Florian_Naef.Models
{
    [Table("ImageStore")]
    public class ImageStore
    {
        [Key]
        public int ImageID { get; set; }

        public string? ImageBase64String { get; set; }
     
        public DateTime? CreateDate { get; set; }
    }
}
