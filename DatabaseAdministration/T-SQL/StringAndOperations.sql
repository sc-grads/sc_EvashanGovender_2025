--char -ASCII - 1byte
--varchar - ASCII - 1 byte
--nchar - UNICODE - 2 byte
-- nvarchar - UNICODE - 2 byte

DECLARE @chrMyCharacters as varchar(10)

SET @chrMyCharacters = 'hello'

Select @chrMyCharacters as myString, LEN(@chrMyCharacters) as myLength, DATALENGTH(@chrMyCharacters) as myDataLength

declare @firstname as nvarchar(20)
declare @middlename as nvarchar(20)
declare @lastname as nvarchar(20)

set @firstname = 'Sarah'
--set @middlename = 'Jane'
set @lastname = 'Mulligan'

--Select @firstname + iif(@middlename is null, '', ' ' + @middlename) + ' ' + @lastname as FullName
Select @firstname + CASE WHEN @middlename is null THEN '' ELSE ' ' + @middlename END + ' ' + @lastname as FullName

--Format strings with currencies
Select 'My salary is: ' + FORMAT(2345.6,'C','en-GB')