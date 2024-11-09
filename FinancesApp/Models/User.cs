using SolidarityBlood.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp.Models
{
    public class User : BaseEntity
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The user name is required.")]
        [StringLength(100, ErrorMessage = "The user name must have a maximum of 100 characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The password is required.")]
        [StringLength(100, ErrorMessage = "The password must have a maximum of 100 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The login is required.")]
        [StringLength(100, ErrorMessage = "The login must have a maximum of 100 characters.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "The email is required.")]
        [StringLength(100, ErrorMessage = "The email must have a maximum of 100 characters.")]
        [EmailAddress(ErrorMessage = "The email format is invalid.")]
        public string UserEmail { get; set; }
    }
}
