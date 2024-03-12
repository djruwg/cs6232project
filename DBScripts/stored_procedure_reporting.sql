USE [cs6232-g1]
GO
/****** Object:  StoredProcedure [dbo].[getMostPopularFurnitureDuringDates]    Script Date: 3/12/2024 12:52:10 PM ******/
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
        c.Name as 'category',
        f.description,
        count(distinct ren.RentalId) as QualifiedRentals,
        count(distinct all_rentals.RentalId) as 'all_rentals',
        concat(format(count(distinct ren.RentalId) / count(distinct all_rentals.RentalId) * 100, '##.##'), '%') as 'transaction ratio',
        concat(format(count(certain_members.MemberId) / count(all_members.MemberId) * 100, '##.##'), '%') as '% within 18 to 29',
        concat(format(100.0 - (count(certain_members.MemberId) / count(all_members.MemberId) * 100), '##.##'), '%') '% outside 18 to 29'
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
                and datediff(day, ren.DateRented, certain_members.DateOfBirth) / 365 between 18 and 29 
        left join RentalTransactions all_rentals
                on all_rentals.DateRented between @startDate and @endDate
	where
        ren.DateRented between @startDate and @endDate
	group by f.FurnitureId, c.name, f.description
	having count(distinct ren.RentalId) > 1
	order by QualifiedRentals desc, f.FurnitureId desc;

END