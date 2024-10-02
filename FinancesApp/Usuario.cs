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

        [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do usuário deve ter no máximo 100 caracteres.")]
        public string NmUsuario { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(100, ErrorMessage = "A senha deve ter no máximo 100 caracteres.")]
        public string NmSenha { get; set; }

        [Required(ErrorMessage = "O login é obrigatório.")]
        [StringLength(100, ErrorMessage = "O login deve ter no máximo 100 caracteres.")]
        public string NmLogin { get; set; }

    }
}
