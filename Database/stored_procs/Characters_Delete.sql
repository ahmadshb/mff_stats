CREATE PROCEDURE [dbo].[Characters_Delete]
	@id int
AS
/*

DECLARE @_id INT = 9;
EXEC [Characters_Delete]
	@_id
SELECT * FROM [dbo].[Characters]

*/
BEGIN
	DELETE FROM [dbo].[Characters]
	WHERE Id = @id
END