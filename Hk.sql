use AdventureWorks2014

go


select * from Sales.SalesTaxRate
select * from Sales.SpecialOffer


select SalesTaxRateID,TaxRate,TaxType from Sales.SalesTaxRate
union
select  SpecialOfferID,DiscountPct, EndDate from sales.SpecialOffer
--duplicates?

select * from Person.Person as #copyperson


select City from Person.Address
group by City


-------
use CCC

go

create table Practice 
( ID int not null identity (1,1),
FName varchar(30),
LN varchar (30)
)
select * from Practice

end 

create procedure tableUpdated
(
@ID int,
@FName varchar(30),
@LN varchar (30),
@StatementType varchar(30) = 'update You updated the table..You are how in trouble'
)
begin 
update Practice set


end 

create procedure tableUpdated

as begin

end ;

select * from Practice

end 
