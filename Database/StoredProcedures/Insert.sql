
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[People_Insert]
	@first_name varchar(50),
	@last_name varchar(50),
	@email varchar(255),
	@gender varchar(20),
	@created datetime,
	@updated datetime
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.People (first_name, last_name, email, gender, created, updated) values (@first_name, @last_name, @email,@gender, @created, @updated);
END
GO
