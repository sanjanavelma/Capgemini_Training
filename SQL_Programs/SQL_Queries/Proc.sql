CREATE PROCEDURE GetSportsPaged
    @PageNumber INT,
    @PageSize INT
AS
BEGIN
    SELECT *
    FROM dbo.PunjabSportss
    ORDER BY id
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY
END

EXEC GetSportsPaged 1,5