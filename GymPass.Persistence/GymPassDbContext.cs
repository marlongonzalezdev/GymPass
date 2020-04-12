using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GymPass.Application.Common.Interfaces;
using GymPass.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymPass.Persistence
{
    public class GymPassDbContext: DbContext, IGymPassDbContext
    {
        public GymPassDbContext(DbContextOptions<GymPassDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentPeriod> PaymentPeriods { get; set; }
        public DbSet<WorkoutRoutine> WorkoutRoutines { get; set; }
        public DbSet<SubRoutine> SubRoutines { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GymPassDbContext).Assembly);
        }
    }
}
