using Finances_Control_App.Domain.FinancesApp.Enums;
using SolidarityBlood.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp.Models
{
    public class Account : BaseEntity
    {
        [Key]
        public int AccountId { get; set; }

        [StringLength(100, ErrorMessage = "The agency name must have a maximum of 100 characters.")]
        public string? AgencyNumber { get; set; }

        [StringLength(100, ErrorMessage = "The account number must have a maximum of 100 characters.")]
        public string? AccountNumber { get; set; }

        [Required(ErrorMessage = "The account name is required.")]
        [StringLength(100, ErrorMessage = "The account name must have a maximum of 100 characters.")]
        public string AccountName { get; set; }

        [Required(ErrorMessage = "The institution name is required.")]
        [StringLength(100, ErrorMessage = "The institution name must have a maximum of 100 characters.")]
        public string InstitutionName { get; set; }

        [Required(ErrorMessage = "The user ID is required.")]
        public int UserId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The account flag must be a positive value.")]
        public int? AccountFlagId { get; set; }

        [Required(ErrorMessage = "The balance is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "The balance must be greater than or equal to zero.")]
        [Column(TypeName = "decimal(18, 2)")]
        public double Balance { get; set; }

        public AccountType? TransactionType { get; set; }

        [ForeignKey("UserId")]
        public virtual User? User { get; set; }

        [ForeignKey("AccountFlagId")]
        public virtual AccountFlag? AccountFlag { get; set; }
    }
}
