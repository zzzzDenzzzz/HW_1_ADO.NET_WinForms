--CREATE TABLE VegetablesAndFruits
--(
--	Id INT NOT NULL IDENTITY PRIMARY KEY,
--	[Type] NVARCHAR(10) NOT NULL CHECK([Type] = N'овощь' OR [Type] = N'фрукт'),
--	Color NVARCHAR(100) NOT NULL,
--	Calories INT NOT NULL CHECK(Calories > 0)
--)

--INSERT INTO VegetablesAndFruits([Type], Color, Calories)
--VALUES(N'овощь', N'морковь', 41),
--(N'фрукт', N'яблоко', 52)

--SELECT * FROM VegetablesAndFruits