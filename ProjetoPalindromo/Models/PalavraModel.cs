using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoPalindromo.Models
{
    public class PalavraModel
    {
        [Required(ErrorMessage ="Informe uma palavra.")]
        [MinLength(3,ErrorMessage = "No minimo {1} caracteres.")]
        public string Palavra { get; set; }

        public string PalavraInvertida { get; set; }

        public string Palindromo { get; set; }
    }
}
