using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tescrudmvc.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName ="nvarchar(25)")]
        [DisplayName("First Name")]
        [Required(ErrorMessage ="*Field Ini Wajib Diisi")]
        public string first_name { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "*Field Ini Wajib Diisi")]
        public string last_name { get; set; }

        [DisplayName("Score")]
        [Required(ErrorMessage = "*Field Ini Wajib Diisi")]
        public int score { get; set; }

        [DisplayName("Grade")]
        [Required(ErrorMessage = "*Field Ini Wajib Diisi")]
        public int grade { get; set; }
    }
}
