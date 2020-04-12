using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GymPass.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GymPass.Persistence
{
    public class GymPassDbContext: DbContext, IGymPassDbContext
    {
        public GymPassDbContext(DbContextOptions<GymPassDbContext> options)
            : base(options)
        {
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
