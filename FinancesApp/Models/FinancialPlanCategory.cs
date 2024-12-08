using Finances_Control_App.Domain.FinancesApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp.Models
{
    public class FinancialPlanCategory
    {
        [Key]
        public int FinancialPlanCategoryId { get; set; }

        [Required(ErrorMessage = "The financial plan ID is required.")]
        public int FinancialPlanId { get; set; }

        [Required(ErrorMessage = "The user ID is required.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The category ID is required.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The financial plan type is required.")]
        public FinancialPlanType PlanType { get; set; }
    }
}
