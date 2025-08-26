CREATE TABLE CompanyRevenue (
    Id INT IDENTITY PRIMARY KEY,
    ReportDate VARCHAR(7) NOT NULL,
    DataYearMonth VARCHAR(6) NOT NULL,
    CompanyId NVARCHAR(10) NOT NULL,
    CompanyName NVARCHAR(100) NOT NULL,
    IndustryType NVARCHAR(50),
    MonthlyRevenue INT,
    LastMonthRevenue INT,
    LastYearRevenue INT,
    MoMGrowthPercent DECIMAL(20,20),
    YoYGrowthPercent DECIMAL(20,20),
    AccumulatedRevenue DECIMAL(20,20),
    LastYearAccumulatedRevenue DECIMAL(20,20),
    AccumulatedGrowthPercent DECIMAL(20,20),
    Note NVARCHAR(500)
);