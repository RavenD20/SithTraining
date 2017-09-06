

 --truncate table specialofferproduct

use AdventureWorks2014
go

select * from Sales.SalesOrderDetail
where ProductID between 43660 and 43700

--select * from Sales.SpecialOfferProduct
--where ProductID in (771,777)
