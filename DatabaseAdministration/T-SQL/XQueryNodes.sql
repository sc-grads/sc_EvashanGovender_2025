declare @x xml  
set @x='<Shopping ShopperName="Phillip Burton" >  
<ShoppingTrip ShoppingTripID="L1" >  
  <Item Cost="5">Bananas</Item>  
  <Item Cost="4">Apples</Item>  
  <Item Cost="3">Cherries</Item>  
</ShoppingTrip>  
<ShoppingTrip ShoppingTripID="L2" >  
  <Item>Emeralds</Item>  
  <Item>Diamonds</Item>  
  <Item>Furniture</Item>  
</ShoppingTrip>  
</Shopping>'  

select tbl.col.value('.', 'varchar(50)') as Item
     , tbl.col.value('@Cost','varchar(50)') as Cost
into tblTemp
from @x.nodes('/Shopping/ShoppingTrip/Item') as tbl(col)

select * from tblTemp

drop table tblTemp
--for let where order by return
