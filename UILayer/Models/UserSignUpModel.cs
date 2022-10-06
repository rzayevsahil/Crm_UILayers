using System.ComponentModel.DataAnnotations;

namespace UILayer.Models
{
    public class UserSignUpModel
    {
        [Required(ErrorMessage = "Lütfen ad değerini boş geçmeyin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyad değerini boş geçmeyin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet değerini boş geçmeyin")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen mail değerini boş geçmeyin")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı değerini boş geçmeyin")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifre değerini boş geçmeyin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
        [Compare("Password",ErrorMessage = "Şifreler uyuşmuyor lütfen kontrol edin")]
        public string ConfirmPassword { get; set; }
    }
}
