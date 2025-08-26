CREATE PROCEDURE GetCompanyRevenueById
    @CompanyId NVARCHAR(10)
AS
BEGIN
    SELECT * FROM CompanyRevenue
    WHERE CompanyId = @CompanyId
    ORDER BY DataYearMonth DESC
END