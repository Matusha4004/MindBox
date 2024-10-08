SELECT PR.Name, CA.Name as CategoryName
FROM AdventureWorks2017.Production.Product as PR FULL JOIN
AdventureWorks2017.Production.ProductSubcategory AS SU ON PR.ProductSubcategoryID = SU.ProductSubcategoryID FULL JOIN
AdventureWorks2017.Production.ProductCategory as CA ON CA.ProductCategoryID = SU.ProductCategoryID
ORDER BY PR.Name
