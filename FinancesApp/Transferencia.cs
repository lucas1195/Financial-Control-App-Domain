using System;
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

        [Required(ErrorMessage = "O ID do usuário é obrigatório.")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O valor da transferência é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor da transferência deve ser maior que zero.")]
        public decimal VlTransferencia { get; set; }

        [StringLength(300, ErrorMessage = "A descrição da transferência deve ter no máximo 300 caracteres.")]
        public string? DsTransferencia { get; set; }

        [Required(ErrorMessage = "A data da transferência é obrigatória.")]
        public DateTime DtTransferencia { get; set; }

        [Required(ErrorMessage = "A categoria é obrigatória.")]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "A conta é obrigatória.")]
        public int IdConta { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }

        [ForeignKey("IdConta")]
        public virtual Conta Conta { get; set; }

    }
}
