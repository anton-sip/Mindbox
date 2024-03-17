CREATE TABLE Products (
                          Id INT PRIMARY KEY,
                          "Name" TEXT
);

INSERT INTO Products
VALUES
    (1, 'Chicken'),
    (2, 'Eggs'),
    (3, 'Prague cake'),
    (4, 'Bread'),
    (5, 'Juice');

CREATE TABLE Categories (
                            Id INT PRIMARY KEY,
                            "Name" TEXT
);

INSERT INTO Categories
VALUES
    (1, 'Meat'),
    (2, 'Animal products'),
    (3, 'Flour'),
    (4, 'Dessert');

CREATE TABLE ProductCategories (
                                   ProductId INT FOREIGN KEY REFERENCES Products(Id),
                                   CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
                                   PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
    (1, 1),
    (1, 2),
    (2, 2),
    (3, 3),
    (3, 4),
    (4, 3);


SELECT Products.Name, Categories.Name 
FROM Products
         LEFT JOIN ProductCategories
                   ON Products.Id = ProductCategories.ProductId
         LEFT JOIN Categories
                   ON ProductCategories.CategoryId = Categories.Id