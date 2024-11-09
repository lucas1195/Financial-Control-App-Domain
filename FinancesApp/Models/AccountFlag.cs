using SolidarityBlood.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp.Models
{
    public class AccountFlag : BaseEntity
    {
        [Key]
        public int AccountFlagId { get; set; }

        [Required(ErrorMessage = "The account flag name is required.")]
        [StringLength(200, ErrorMessage = "The account flag name must have a maximum of 200 characters.")]
        public string AccountFlagName { get; set; }

        [Required(ErrorMessage = "The account flag image is required.")]
        public byte[] AccountFlagImage { get; set; }

    }
}
