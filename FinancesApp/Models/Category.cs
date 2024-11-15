using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The category name is required.")]
        [StringLength(200, ErrorMessage = "The category name must have a maximum of 200 characters.")]
        public string CategoryName { get; set; }
    }
}
