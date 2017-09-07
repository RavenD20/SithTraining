
use CCC go 

create table Sales.products
(SalesNumberID int not null identity (2,1),
ProductName varchar(30),
QuantityOnHand int,
CashType varchar (10),
QuantityPerUnit int
)

select * from sales.products;

insert into sales.products
(ProductName, QuantityOnHand, CashType, QuantityperUnit) values
('JoseQuervo',20,'DebitCard',1),
('TrulysSelzter',30,'Cash',12),
('GreyGoose',15,'CreditCard',1),
('MillerGenuineDraft',50,'Cash',30),
('NotYourFathers',36,'Cash',6),
('TangereyGin',5,'Check',1),
('Absente',28,'DebitCard',4),
('WildTurkey',20,'Check',3),
('Jameson',55,'Creditcard',15),
('ChivasRegal',67,'CreditCard',10)