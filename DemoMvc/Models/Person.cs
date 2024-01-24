using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models{
    [Table("Persons")]
    public class Person{
        [Key]
        [Display(Name = "PersonID")]
        public int PersonID { get; set; }
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime NgaySinh { get; set; }
    }
}