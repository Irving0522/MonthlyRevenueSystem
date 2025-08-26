using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MonthlyRevenue.Models;

namespace MonthlyRevenue.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CompanyRevenue> CompanyRevenues { get; set; } = null!;
    }
}
