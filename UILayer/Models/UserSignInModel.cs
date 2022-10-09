using System.ComponentModel.DataAnnotations;

namespace UILayer.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adı boş geçmeyin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
