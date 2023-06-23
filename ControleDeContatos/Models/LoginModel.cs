using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite seu login para acesar o sistema")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite sua senha para acesar o sistema")]
        public string Senha { get; set; }
    }
}