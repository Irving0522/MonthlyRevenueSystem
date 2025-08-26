namespace MonthlyRevenue.Models
{
    public class CompanyRevenueDto
    {
        public string ReportDate { get; set; }
        public string DataYearMonth { get; set; } = string.Empty;
        public string CompanyId { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string IndustryType { get; set; } = string.Empty;
        public int MonthlyRevenue { get; set; }
        public int LastMonthRevenue { get; set; }
        public int LastYearRevenue { get; set; }
        public decimal MoMGrowthPercent { get; set; }
        public decimal YoYGrowthPercent { get; set; }
        public decimal AccumulatedRevenue { get; set; }
        public decimal LastYearAccumulatedRevenue { get; set; }
        public decimal AccumulatedGrowthPercent { get; set; }
        public string? Note { get; set; }
    }
}
