using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanTypeMicroservice.Models;

namespace LoanTypeMicroservice.Models
{
    public class LoanTypeDbContext : DbContext
    {
         public LoanTypeDbContext(DbContextOptions<LoanTypeDbContext> options) : base(options)
        {
        }
       public DbSet<ApplyLoan> ApplyLoans { get;set; }
       public DbSet<EducationLoan> EducationLoans { get;set; }
       public  DbSet<PersonalLoan> PersonalLoans { get;set; }
    }
}
