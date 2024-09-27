using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [StringLength(200)]
        public string NmCategoria { get; set; }

    }
}
