
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[People_Update]
	@first_name varchar(50),
	@last_name varchar(50),
	@email varchar(255),
	@gender varchar(20),
	@updated datetime
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.People SET first_name = @first_name, last_name =  @last_name, email =  @email, gender = @gender, updated =@updated WHERE email = @email;
END
