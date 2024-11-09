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
    public class Transfer : BaseEntity
    {
        [Key]
        public int TransferId { get; set; }

        [Required(ErrorMessage = "The user ID is required.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The transfer amount is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The transfer amount must be greater than zero.")]
        public decimal TransferAmount { get; set; }

        [StringLength(300, ErrorMessage = "The transfer description must have a maximum of 300 characters.")]
        public string? TransferDescription { get; set; }

        [Required(ErrorMessage = "The transfer date is required.")]
        public DateTime TransferDate { get; set; }

        [Required(ErrorMessage = "The category is required.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The account is required.")]
        public int AccountId { get; set; }

        [ForeignKey("UserId")]
        public virtual User? User { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account? Account { get; set; }
    }

}
