using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanTypeMicroservice.Models
{
    public class ApplyLoan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string LoanType { get; set; }
        [Required]
        public long LoanAmount { get; set; }
        [Required]
        public DateTime LoanApplyDate { get; set; }
        [Required]
        public DateTime LoanIssueDate { get; set; }
        [Required]
        public int RateOfIntrest { get; set; }
        [Required]
        public int LoanDuration { get; set; }
    }
}
