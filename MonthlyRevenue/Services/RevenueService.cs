using MonthlyRevenue.Data;
using MonthlyRevenue.Models;
using MonthlyRevenue.Services.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace MonthlyRevenue.Services
{
    public class RevenueService : IRevenueService
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public RevenueService(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CompanyRevenueDto>> GetByCompanyIdAsync(string companyId)
        {
            var data = await _db.CompanyRevenues
                .Where(x => x.CompanyId == companyId)
                .OrderByDescending(x => x.DataYearMonth)
                .ToListAsync();

            return _mapper.Map<IEnumerable<CompanyRevenueDto>>(data);
        }

        public async Task InsertAsync(CompanyRevenueDto dto)
        {
            var entity = _mapper.Map<CompanyRevenue>(dto);
            await _db.CompanyRevenues.AddAsync(entity);
            await _db.SaveChangesAsync();
        }
    }
}
