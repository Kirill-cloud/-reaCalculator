create table Product(
	Id int Identity(1,1) Primary key,
	Name nvarchar(50) not null
)

create table Category(
	Id int Identity(1,1) Primary key,
	name nvarchar(50) not null
)

create table CategoryAndProduct(
	PId int,
	Foreign key (PId) References Product(Id),
	CId int,
	Foreign key (CId) References Category(Id)
)

Insert into Product
Values
('Продукт без категории'),
('Продукт с категорией'),
('Продукт 2 категории')

Insert into Category
Values 
('категория 1'),
('категория 2')

Insert into CategoryAndProduct
Values 
(2,1),
(3,1),
(3,2)

select Product.[Name], Category.[Name]
from Product 
left join CategoryAndProduct
on CategoryAndProduct.PId = Product.Id
left join Category
on CategoryAndProduct.CId = Category.Id 