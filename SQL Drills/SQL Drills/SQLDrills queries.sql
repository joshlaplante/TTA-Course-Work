-- 1. Select the names of all the products in the store.

select Name from Products;

-- 2. Select the names and the prices of all the products in the store.

select Name,Price from Products;

-- 3. Select the name of the products with a price less than or equal to $200.

select Name,Price from Products
where Price <= 200;

-- 4. Select all the products with a price between $60 and $120.

select Name,Price from Products
where 60 < Price and Price < 120;

-- 5. Select the name and price in cents (i.e., the price must be multiplied by 100).

select Name,Price*100 as PriceInCents from Products;

-- 6. Compute the average price of all the products.

select avg(Price) as AveragePrice from Products;

-- 7. Compute the average price of all products with manufacturer code equal to 2.

select avg(Price) as AveragePriceManufacturer2 from Products
where Manufacturer = 2;

-- 8. Compute the number of products with a price larger than or equal to $180.

select count(Price) as NumOfProductsOver180 from Products
where Price >= 180;

-- 9. Select the name and price of all products with a price larger than or equal to $180, and sort first by price (in descending order), and then by name (in ascending order).

select Name,Price from Products
where Price >= 180
order by Price desc, Name;

-- 10. Select all the data from the products, including all the data for each product's manufacturer.

select * from Products 
join Manufacturers 
on Products.Manufacturer = Manufacturers.Code;

-- 11. Select the product name, price, and manufacturer name of all the products.

select Products.Name, Price, Manufacturers.Name from Products
join Manufacturers 
on Products.Manufacturer = Manufacturers.Code;

-- 12. Select the average price of each manufacturer's products, showing only the manufacturer's code.

select Manufacturers.Code, avg(Price) as AveragePriceForManufacturer from Products
join Manufacturers
on Products.Manufacturer = Manufacturers.Code
group by Manufacturers.Code;

-- 13. Select the average price of each manufacturer's products, showing the manufacturer's name.

select Manufacturers.Name, avg(Price) as AveragePriceForManufacturer from Products
join Manufacturers
on Products.Manufacturer = Manufacturers.Code
group by Manufacturers.Name;

-- 14. Select the names of manufacturer whose products have an average price larger than or equal to $150.

select Manufacturers.Name, avg(Price) as AveragePriceForManufacturer from Products
join Manufacturers
on Products.Manufacturer = Manufacturers.Code
group by Manufacturers.Name
having avg(Price) > 150;

-- 15. Select the name and price of the cheapest product.

select Name,Price from Products
where Price = (select min(Price) from Products);

-- 16. Select the name of each manufacturer along with the name and price of its most expensive product.

select Manufacturers.Name, Products.Name, Price from Products 
join Manufacturers 
on Products.Manufacturer = Manufacturers.Code
where Price = (select max(Price) from Products where Products.Manufacturer = Manufacturers.Code);

-- 17. Add a new product: Loudspeakers, $70, manufacturer 2.

insert into Products(Code,Name,Price,Manufacturer)
values(11, 'Loudspeakers', 70, 2);

-- 18. Update the name of product 8 to "Laser Printer".

update Products 
set Name = 'Laser Printer'
where Code = 8;
 
-- 19. Apply a 10% discount to all products.

update Products
set Price = Price * 0.9;

-- 20. Apply a 10% discount to all products with a price larger than or equal to $120.

update Products
set Price = Price* 0.9
where Price > 120;