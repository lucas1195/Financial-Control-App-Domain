using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp
{
    public class AccountFlag
    {
        [Key]
        public int IdAccountFlag { get; set; }

        [Required(ErrorMessage = "O nome da bandeira da conta é obrigatório.")]
        [StringLength(200, ErrorMessage = "O nome da bandeira da conta deve ter no máximo 200 caracteres.")]
        public string NmAccountFlag { get; set; }

        [Required(ErrorMessage = "A imagem da bandeira da conta é obrigatória.")]
        public byte[] ImgAccountFlag { get; set; }
    }
}
