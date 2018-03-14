CREATE PROCEDURE sproc_tblProduct_FilterByProductID
	@ProductID int
AS
	SELECT * from tblProduct where ProductID = @ProductID
RETURN 0
