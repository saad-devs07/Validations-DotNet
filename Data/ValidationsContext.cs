using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Validations.Models;

namespace Validations.Data
{
    public class ValidationsContext : DbContext
    {
        public ValidationsContext (DbContextOptions<ValidationsContext> options) : base(options) { }

        public DbSet<Validations.Models.Student> Student { get; set; } = default!;
        public DbSet<Fees> Fees { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}