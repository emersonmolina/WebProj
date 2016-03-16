using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.ViewModels.Grupo
{
    public class NovoGrupoViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Digite no minimo {0} e no máximo {2} caracteres.", MinimumLength = 20)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }
    }
}
