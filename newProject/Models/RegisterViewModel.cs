using System.ComponentModel.DataAnnotations;

namespace newProject.Models
{
    public class RegisterViewModel
    {
        [Required (ErrorMessage ="Lütfen kullanıcı adını giriniz!")]
        public string userName {  get; set; }
        [Required(ErrorMessage ="Lütfen şifreyi giriniz!")]

        public string password { get; set; }
        [Required(ErrorMessage ="Lütfen şifreyi giriniz !")]
        [Compare("password",ErrorMessage ="Lütfen aynı şifreyi giriniz ")]
        public string passwordConfirm { get; set; }

        [Required(ErrorMessage ="Lütfen mail adresini giriniz !")]
        public string email { get; set; }
        [Required(ErrorMessage ="Lütfen şartnameyi kabul ediniz")]
        public bool Status { get; set; } = false;
    }
}
