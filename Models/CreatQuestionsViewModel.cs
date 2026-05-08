using System.ComponentModel.DataAnnotations;

namespace MicroSaaSProvas.Models;

public class CreatQuestionsViewModel {

    [Required(ErrorMessage = "Preencha o Enunciado")]
    public string Enunciado {get; set;} = string.Empty;

    [Required(ErrorMessage = "Escolha uma Diciplina")]
    public string Disciplina {get; set;} = string.Empty;

    [Required(ErrorMessage = "Escolha a Dificuldade")]
    public int Dificuldade {get; set;}

    [Required(ErrorMessage = "Preencha o Gabarito")]
    public string Gabarito {get; set;} = string.Empty;
}