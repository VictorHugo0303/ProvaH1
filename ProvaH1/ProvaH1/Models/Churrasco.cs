using System.ComponentModel.DataAnnotations;
using ProvaH1.Validations;

namespace ProvaH1.Models
{
    public class Churrasco
    {
        [Required(ErrorMessage = "Obrigatório")]
        [MinLength(3, ErrorMessage = "Minimo 3 letras")]
        [MaxLength(255, ErrorMessage = "Maximo 255 letras")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatorio")]
        public string DescCarne { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [IdadeValidation(ErrorMessage = "tem que ser maior que 18 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        public string DescBebidas { get; set; }
    }
}
