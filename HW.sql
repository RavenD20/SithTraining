use AdventureWorks2014

go


select * from sales.SpecialOffer

select * from sales.SalesOrderDetail 

select * 
from sales.specialoffer as S
left join sales.SalesOrderDetail as O
on s.Category = o.CarrierTrackingNumber
--where s.Category = 'no discount'
where s.Category = 'reseller ,customer '
---says its right but wont select---



use NORTHWND
go

select *
from dbo.Categories as cat
inner join dbo.Products as pro
on cat.CategoryID = pro.ProductID

