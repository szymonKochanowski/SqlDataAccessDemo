SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[People_GetByLastName]
	@last_name varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from dbo.People where last_name = @last_name;
END
GO
