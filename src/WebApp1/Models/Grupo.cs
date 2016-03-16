using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public class Grupo
    {
        [Key]
        public int PK_GRUP_CD_CODIGO { get; set; }
        public string GRUP_NM_NOME { get; set; }
        public int GRUP_CD_USUARIO_ADMINISTRADOR { get; set; }
        public int GRUP_CD_USUARIO_TESOUREIRO { get; set; }
        public DateTime GRUP_DT_INCLUSAO { get; set; }
        public int FK_TIGR_GRUP_CODIGO { get; set; }
    }

}


//PK_GRUP_CD_CODIGO
//GRUP_NM_NOME
//FK_TIGR_GRUP_CODIGO
//GRUP_DT_INCLUSAO
//GRUP_CD_USUARIO_ADMINISTRADOR
//GRUP_CD_USUARIO_TESOUREIRO
