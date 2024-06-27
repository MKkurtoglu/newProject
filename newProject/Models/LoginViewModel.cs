using System.ComponentModel.DataAnnotations;

namespace newProject.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adı giriniz!")]
        public string userName { get; set; }
        [Required(ErrorMessage ="Lütfen şifre giriniz")]
        public string password { get; set; }
    }
}
