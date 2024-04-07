USE [cs6232-g1]
GO
/****** Object:  StoredProcedure [dbo].[getMostPopularFurnitureDuringDates]    Script Date: 4/7/2024 1:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getMostPopularFurnitureDuringDates]
	-- Add the parameters for the stored procedure here
	(@startDate Date, @endDate Date)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select
        f.FurnitureId,
        c.Name as 'Category',
        f.Name,
        count(distinct ren.RentalId) as QualifiedRentals,
        count(distinct all_rentals.RentalId) as 'All Rentals',
        concat(format(count(distinct ren.RentalId) * 1.0 / count(distinct all_rentals.RentalId) * 100.0, '0.00'), '%') as 'Transaction Ratio',
        concat(format(count(certain_members.MemberId) * 1.0 / count(all_members.MemberId) * 100.0, '0.00'), '%') as '% within 18 to 29',
        concat(format(100.0 - (count(certain_members.MemberId) * 1.0 / count(all_members.MemberId) * 100.0), '0.00'), '%') '% outside 18 to 29'
	from
        RentalTransactions ren 
        join RentalLineItems ren_li 
                on ren.RentalId = ren_li.RentalId
        join Furniture f 
                on f.FurnitureId = ren_li.FurnitureId
        join Categories c
                on c.Name = f.Category
        join Members all_members 
                on all_members.MemberId = ren.MemberId
        left join Members certain_members 
                on certain_members.MemberId = ren.MemberId
                and datediff(year, certain_members.DateOfBirth, ren.DateRented) between 18 and 29 
        left join RentalTransactions all_rentals
                on all_rentals.DateRented between @startDate and @endDate
	where
        ren.DateRented between @startDate and @endDate
	group by f.FurnitureId, c.Name, f.Name
	having count(distinct ren.RentalId) > 1
	order by QualifiedRentals desc, f.FurnitureId desc;

END