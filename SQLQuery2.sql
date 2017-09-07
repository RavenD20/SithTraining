

 --truncate table specialofferproduct

use AdventureWorks2014
go

--select * from Sales.SalesOrderDetail
--where SalesOrderDetailID between 43660 and 43700

--finds range
--select * from Sales.SpecialOfferProduct
--where ProductID in (771,777)

--order by ProductID
--desc

select top 1000 [ItemID]
,['Item Name']
,['ItemDescription']
,['']