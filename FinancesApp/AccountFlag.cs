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

        [StringLength(200)]
        public string NmAccountFlag { get; set; }

        public byte[] ImgAccountFlag { get; set; }
    }
}
