using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App07_ModelValidation.Models;

namespace App07_ModelValidation.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext (DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<App07_ModelValidation.Models.Employee> Employee { get; set; }
    }
}
