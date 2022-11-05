select
	Products.Name, Categories.Name
from Products
left join Products_to_categories
	on Products.Id = Products_to_categories.ProductId
left join Categories
	on Products_to_categories.CategoryId = Categories.Id

-- Products - продукты
-- Categories - категории
-- Products_to_categories - связующая таблица обеспечивающая Many-to-Many связь
