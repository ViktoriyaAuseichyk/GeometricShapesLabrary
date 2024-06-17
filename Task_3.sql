CREATE TABLE "Categories" (
	"ID"	INTEGER NOT NULL UNIQUE,
	"Name"	VARCHAR(255) NOT NULL UNIQUE,
	PRIMARY KEY("ID" AUTOINCREMENT)
)
CREATE TABLE "Products" (
	"ID"	INTEGER NOT NULL UNIQUE,
	"Name"	VARCHAR(255) NOT NULL UNIQUE,
	PRIMARY KEY("ID" AUTOINCREMENT)
)
CREATE TABLE "ProductsToCategories" (
	"ID_Product"	INTEGER,
	"ID_Categories"	INTEGER,
	FOREIGN KEY("ID_Product") REFERENCES "Products"("ID")
)

SELECT Products.Name AS NameOfProducts, Categories.Name AS NameOfCategories FROM Products
LEFT JOIN ProductsToCategories ON Products.ID = ProductsToCategories.ID_Product
LEFT JOIN Categories ON ProductsToCategories.ID_Categories = Categories.ID