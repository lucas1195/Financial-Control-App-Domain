﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp
{
    public class Transferencia 
    {
        [Key]
        public int IdTransferencia { get; set; }

        public int IdUsuario { get; set; }

        public decimal VlTransferencia { get; set; }

        [StringLength(300)]
        public string? DsTransferencia { get; set; }

        public DateTime DtTransferencia { get; set; }

        public int IdCategoria { get; set; }

        public int IdConta { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }

        [ForeignKey("IdConta")]
        public virtual Conta Conta { get; set; }

    }
}
