using System.Threading;
using System.Threading.Tasks;

namespace GymPass.Application.Common.Interfaces
{
    public interface IGymPassDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
