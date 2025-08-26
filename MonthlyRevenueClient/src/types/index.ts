export interface CompanyRevenueDto {
  reportDate: string
  dataYearMonth: string
  companyId: string
  companyName: string
  industryType: string
  monthlyRevenue: number
  lastMonthRevenue: number
  lastYearRevenue: number
  moMGrowthPercent: number
  yoYGrowthPercent: number
  accumulatedRevenue: number
  lastYearAccumulatedRevenue: number
  accumulatedGrowthPercent: number
  note: string
}
