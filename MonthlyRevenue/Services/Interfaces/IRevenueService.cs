using MonthlyRevenue.Models;

namespace MonthlyRevenue.Services.Interfaces
{
    public interface IRevenueService
    {
        Task<IEnumerable<CompanyRevenueDto>> GetByCompanyIdAsync(string companyId);
        Task InsertAsync(CompanyRevenueDto dto);
    }
}
