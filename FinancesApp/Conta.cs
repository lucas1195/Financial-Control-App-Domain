using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp
{
    public class Conta
    {
        [Key]
        public int IdConta { get; set; }
        public string NmAgencia { get; set; }
        public string NumConta { get; set; }
        public int IdUsuario { get; set; }
    }
}
