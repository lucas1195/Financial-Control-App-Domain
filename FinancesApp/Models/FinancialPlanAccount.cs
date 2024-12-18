using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp.Models
{
    public class FinancialPlanAccount
    {
        [Key]
        public int FinancialPlanAccountId { get; set; }

        [Required(ErrorMessage = "The account ID is required.")]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "The financial plan ID is required.")]
        public int FinancialPlanId { get; set; }

        [Required(ErrorMessage = "The user ID is required.")]
        public int UserId { get; set; }
    }
}
