use AdventureWorks2014

go


select * from Production.WorkOrder

select * from Production.Product



select WorkOrderID, workorder.ProductID, OrderQty, Scrappedqty, StartDate, EndDate, DueDate, ScrapReasonID, workorder.ModifiedDate

from Production.WorkOrder

full outer join Production.Product on Product.ProductID = WorkOrderID  ;
select top 501 * from Production.Product 


select WorkOrderID, workorder.ProductID,ScrapReasonID
from Production.WorkOrder
return top 729 

select top 1 * from Production.WorkOrder

select ScrapReasonID
from Production.WorkOrder








select WorkOrderID,ProductID
from Production.WorkOrder 
where WorkOrderID <> ProductID

