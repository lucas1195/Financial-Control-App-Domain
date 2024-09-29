using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp
{
    public class Conta
    {
        [Key]
        public int IdConta { get; set; }

        [StringLength(100)]
        public string NmAgencia { get; set; }

        [StringLength(100)]
        public string NumConta { get; set; }
        public int IdUsuario { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public double Saldo { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

    }
}
