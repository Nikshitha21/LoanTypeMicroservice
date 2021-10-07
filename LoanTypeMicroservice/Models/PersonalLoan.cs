using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanTypeMicroservice.Models
{
    public class PersonalLoan
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public int AnnualIncome { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public int TotalExp { get; set; }
         [Required]
        public int CurCompanyExp { get; set; }
    }
}
