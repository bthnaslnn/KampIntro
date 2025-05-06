-- Select 
-- ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers 

Select * from Customers where City = 'Berlin'

-- case insensitive / büyük küçük harf duyarsız.
select * from Products where categoryId =1 or categoryID =3

select * from Products where categoryId =1 and UnitPrice >=10

select * from Products where categoryId =1 order by UnitPrice desc  --ascending --> artan  -- descending --> düşen

Select count(*) ToplamAdet from Products where CategoryID=2

-- Yönetim dedi ki hangi kategoride, kaç farklı ürünümüz var

Select CategoryID,count(*) from products group by CategoryID

--Karar destek sistemlerinde genellikle fazla kullanılır
-- Yönetim << ürün sayısı 10 dan az olan kategorileri listele.

Select CategoryID,count(*) from products where UnitPrice >20 
group by CategoryID having count(*)<10
 

 -- inner join > sadece 2 tabloda da eşleşenleri bir araya getirir. Eşleşmeyen data var ise onu getirmez.

 select Products.ProductID,Products.ProductName, Products.UnitPrice, Categories.CategoryName
 from products inner join Categories 
 on Products.CategoryID = Categories.CategoryID
 where Products.UnitPrice>10

 --DTO << Data Transformation Object >>

 -- left join << solda olup sağda olmayan 

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID 

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

--in, distinct , union , union all -- ÖDEV






 
