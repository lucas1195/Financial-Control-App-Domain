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

        [StringLength(100)]
        public string NmUsuario { get; set; }
        
        [StringLength(100)]
        public string NmSenha { get; set; }
        
        [StringLength(100)]
        public string NmLogin { get; set; }

    }
}
