CREATE PROCEDURE InsertCompanyRevenue
    @ReportDate VARCHAR(7),
    @DataYearMonth VARCHAR(6),
    @CompanyId NVARCHAR(10),
    @CompanyName NVARCHAR(100),
    @IndustryType NVARCHAR(50),
    @MonthlyRevenue INT,
    @LastMonthRevenue INT,
    @LastYearRevenue INT,
    @MoMGrowthPercent DECIMAL(20,20),
    @YoYGrowthPercent DECIMAL(20,20),
    @AccumulatedRevenue DECIMAL(20,20),
    @LastYearAccumulatedRevenue DECIMAL(20,20),
    @AccumulatedGrowthPercent DECIMAL(20,20),
    @Note NVARCHAR(500)
AS
BEGIN
    INSERT INTO CompanyRevenue (
        ReportDate, DataYearMonth, CompanyId, CompanyName, IndustryType,
        MonthlyRevenue, LastMonthRevenue, LastYearRevenue,
        MoMGrowthPercent, YoYGrowthPercent,
        AccumulatedRevenue, LastYearAccumulatedRevenue,
        AccumulatedGrowthPercent, Note
    )
    VALUES (
        @ReportDate, @DataYearMonth, @CompanyId, @CompanyName, @IndustryType,
        @MonthlyRevenue, @LastMonthRevenue, @LastYearRevenue,
        @MoMGrowthPercent, @YoYGrowthPercent,
        @AccumulatedRevenue, @LastYearAccumulatedRevenue,
        @AccumulatedGrowthPercent, @Note
    );
END