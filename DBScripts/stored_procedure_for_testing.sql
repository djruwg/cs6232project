USE [cs6232-g1]
GO
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
        f.description
	from
        Furniture f 
        join Categories c
                on c.Name = f.Category;

END

