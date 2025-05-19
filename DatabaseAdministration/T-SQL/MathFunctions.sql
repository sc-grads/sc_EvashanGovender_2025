DECLARE @myvar AS numeric(7,2) = 3

SELECT POWER(@myvar,3)
SELECT SQUARE(@myvar)
SELECT POWER(@myvar,0.5)
SELECT SQRT(@myvar)


DECLARE @myvar1 as numeric(7,2) = 3.7


SELECT FLOOR(@myvar1)
SELECT CEILING(@myvar1)
SELECT ROUND(@myvar1,0)

SELECT PI() as myPi
SELECT EXP(1) as e

SELECT ABS(456) as myABS, SIGN(@myvar) as mySign


