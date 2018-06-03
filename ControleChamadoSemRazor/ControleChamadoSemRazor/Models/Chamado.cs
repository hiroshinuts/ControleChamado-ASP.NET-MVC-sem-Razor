using ControleChamadoSemRazor.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleChamadoSemRazor.Models
{
    public class Chamado
    {
        public int Id { get; set; }

        public String NomeDoSistema { get; set; }

        public String ModuloDoSistema { get; set; }

        public String DescricaoDoSistema { get; set; }

        public Criticidade Criticidade { get; set; }

        public Status Status { get; set; }

        public int UsuarioId { get; set; }

        //Para utilizar chave estrangeira no Razor, deve-se utilizar o atributo virtual
        public virtual Usuario Usuario { get; set; }
    }
}