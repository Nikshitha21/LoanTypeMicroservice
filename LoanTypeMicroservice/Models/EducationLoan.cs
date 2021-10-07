using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanTypeMicroservice.Models
{
    public class EducationLoan
    {
        [Key]
        public int CustId { get; set; }
        [Required]
        public int CourseFee { get; set; }
        [Required]
        public string Course { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string FaherOccupation { get; set; }
        [Required]
        public int Experience { get; set; }
        [Required]
        public int CurCompanyExp { get; set; }
        [Required]
        public long RationCardNo { get; set; }
        [Required]
        public int AnnualIncome { get; set; }
    }
}
