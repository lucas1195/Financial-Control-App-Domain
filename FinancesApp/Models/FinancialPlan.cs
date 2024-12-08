using Finances_Control_App.Domain.FinancesApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp.Models
{
    public class FinancialPlan
    {
        [Key]
        public int FinancialPlanId { get; set; }

        [Required(ErrorMessage = "The financial plan name is required.")]
        [MaxLength(100, ErrorMessage = "The financial plan name must be at most 100 characters long.")]
        public string FinancialPlanName { get; set; }

        [Required(ErrorMessage = "The user ID is required.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The monthly income is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "The monthly income must be a positive value.")]
        public decimal MonthlyIncome { get; set; }

        [Required(ErrorMessage = "The personal spendings value is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "The personal spendings value must be a positive value.")]
        public decimal PersonalSpendingsValue { get; set; }

        [Required(ErrorMessage = "The prioritary spendings value is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "The prioritary spendings value must be a positive value.")]
        public decimal PrioritarySpendingsValue { get; set; }

        [Required(ErrorMessage = "The start date is required.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "The active status is required.")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "The financial plan type is required.")]
        public FinancialPlanType PlanType { get; set; }
    }
}
