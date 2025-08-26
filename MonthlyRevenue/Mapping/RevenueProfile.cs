using AutoMapper;
using MonthlyRevenue.Models;

namespace MonthlyRevenue.Mapping
{
    public class RevenueProfile : Profile
    {
        public RevenueProfile()
        {
            CreateMap<CompanyRevenue, CompanyRevenueDto>().ReverseMap();
        }
    }
}
