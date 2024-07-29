using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string NmUsuario { get; set; }
        public string NmSenha { get; set; }
        public string NmLogin { get; set; }

    }
}
