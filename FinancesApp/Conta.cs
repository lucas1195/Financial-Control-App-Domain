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

        [Required(ErrorMessage = "O nome da agência é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome da agência deve ter no máximo 100 caracteres.")]
        public string NmAgencia { get; set; }

        [Required(ErrorMessage = "O número da conta é obrigatório.")]
        [StringLength(100, ErrorMessage = "O número da conta deve ter no máximo 100 caracteres.")]
        public string NumConta { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório.")]
        public int IdUsuario { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "A bandeira da conta deve ser um valor positivo.")]
        public int? IdAccountFlag { get; set; }

        [Required(ErrorMessage = "O saldo é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O saldo deve ser maior ou igual a zero.")]
        [Column(TypeName = "decimal(18, 2)")]
        public double Saldo { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("IdAccountFlag")]
        public virtual AccountFlag AccountFlag { get; set; }
    }
}
