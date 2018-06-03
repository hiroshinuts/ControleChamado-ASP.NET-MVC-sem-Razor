using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleChamadoSemRazor.Models
{
    public class Usuario
    {
        public int Id { get; set; }
         
        public String Nome { get; set; }

        public String Senha { get; set; }
    }
}