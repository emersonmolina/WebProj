using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp1.Models
{
    //[Table("PESSOA")]
    public class Pessoa
    {
        [Key]
        public int PK_PESS_CD_CODIGO { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no mínimo {2} e no máximo {1} caracteres.", MinimumLength = 10)]
        [Display(Name = "Nome")]
        public string PESS_NM_NOME { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "O campo {0} deve ter no mínimo {2} e no máximo {1} caracteres.", MinimumLength = 6)]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string PESS_NM_EMAIL { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.DateTime,ErrorMessage ="Data em formato inválido.")]
        public DateTime PESS_DT_DATA_NASCIMENTO { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime PESS_DT_INCLUSAO { get; set; }

        [Required]
        [StringLength(12, ErrorMessage = "O campo {0} deve ter no mínimo {2} e no máximo {1} caracteres.", MinimumLength = 6)]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string PESS_TX_SENHA { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Repetir Senha")]
        [Compare("PESS_TX_SENHA", ErrorMessage = "Você deve repetir exatamente a mesma senha.")]
        public string RepetirSenha { get; set; }

        [Required]
        [Display(Name = "Status")]
        public bool PESS_ST_ATIVO { get; set; }

    }
}
