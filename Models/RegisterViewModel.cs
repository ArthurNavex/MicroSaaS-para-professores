using System.ComponentModel.DataAnnotations;

namespace MicroSaaSProvas.Models;

public class RegisterViewModel {
    [Required(ErrorMessage ="Você precisa informar um nome de login")]
    public string Username { get; set; } =string.Empty;
    [Required(ErrorMessage ="Você precisa informar um email")]
    [EmailAddress(ErrorMessage ="O formato de email informado não é válido")]
    public string Email { get; set; } =string.Empty;
    [Required(ErrorMessage ="Você precisa informar uma senha")]
    [MinLength(6, ErrorMessage ="A senha deve ter no mínimo 6 caracteres")]
    public string Password { get; set; } =string.Empty;
    [Required(ErrorMessage ="Você precisa confirmar a senha")]
    [Compare("Password", ErrorMessage ="As senhas não conferem")]
    public string ConfirmPassword { get; set; } =string.Empty;
}