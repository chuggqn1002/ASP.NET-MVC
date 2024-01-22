using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationMVC.Models.Contacts
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Phai nhap {0}")]
        [Display(Name = "Ho Ten")]
        public string FullName { get; set; }
        [Required]
        [StringLength(100)]
        [EmailAddress(ErrorMessage ="Phai la dia chi email")]
        [Display(Name = "Dia chi Email")]

        public string Email { get; set; }
        public DateTime DateSent { get; set; }
        [Display(Name ="Noi dung")]
        public string Message { get; set; }
        [StringLength(50)]
        [Phone(ErrorMessage ="Phai la so dien thoai")]
        [Display(Name ="So dien thoai")]
        public string Phone {  get; set; }
    }
}
