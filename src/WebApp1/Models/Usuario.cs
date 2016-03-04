//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace WebApp1.Models
//{
//    [Table("USUARIO")]
//    public class Usuario : Pessoa
//    {
//        //[Key]
//        public int PK_USUA_CD_CODIGO { get; set; }
//        //Additional information: The derived type 'Usuario' cannot have KeyAttribute on property 'PK_USUA_CD_CODIGO' since primary key can only be declared on the root type.
//        [Required]
//        [StringLength(20, ErrorMessage = "O campo {0} deve ter no mínimo {2} e no máximo {1} caracteres.", MinimumLength = 6)]
//        [Display(Name = "Usuário")]
//        public string USUA_NM_LOGIN { get; set; }

//        [Required]
//        [StringLength(12, ErrorMessage = "O campo {0} deve ter no mínimo {2} e no máximo {1} caracteres.", MinimumLength = 6)]
//        [Display(Name = "Senha")]
//        [DataType(DataType.Password)]
//        public string USUA_TX_SENHA { get; set; }

//        [Required]
//        [Display(Name = "Status")]
//        public bool USUA_ST_ATIVO { get; set; }


//    }
//}
