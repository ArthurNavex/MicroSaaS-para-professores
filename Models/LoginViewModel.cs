using System.ComponentModel.DataAnnotations;

namespace MicroSaaSProvas.Models;

public class LoginViewModel {

    [Required(ErrorMessage ="Você precisa informar um nome de login")]
    public string Username { get; set; } =string.Empty;

    [Required(ErrorMessage ="Você precisa informar uma senha")]
    [MinLength(6, ErrorMessage ="A senha deve ter no mínimo 8 caracteres")]
    public string Password { get; set; } =string.Empty;
}