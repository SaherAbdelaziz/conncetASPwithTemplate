using System.ComponentModel.DataAnnotations;

namespace conncetASPwithTemplate.ViewModels
{
    public class ProfileViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Adress2 { get; set; }

    }
}