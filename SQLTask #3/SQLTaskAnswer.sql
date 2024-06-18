-- TABLE INITIALIZATION

CREATE TABLE Products
( 
    PRODUCT_ID      INT IDENTITY(1, 1),
    PRODUCT_NAME    VARCHAR(100)
);

CREATE TABLE Categories
( 
    CATEGORY_ID     INT IDENTITY(1, 1),
    CATEGORY_NAME   VARCHAR(100)
);

CREATE TABLE ProductCategoryLink
( 
    LINK_ID         INT IDENTITY(1, 1),
    PRODUCT_ID      INT,
    CATEGORY_ID     INT
);

INSERT INTO Products (product_name) VALUES ('BOOK_ONE');
INSERT INTO Products (product_name) VALUES ('BOOK_TWO');
INSERT INTO Products (product_name) VALUES ('BOOK_THREE');
INSERT INTO Products (product_name) VALUES ('BOOK_FOUR');

INSERT INTO Categories (category_name) VALUES ('FANTASY');
INSERT INTO Categories (category_name) VALUES ('DETECTIVE');
INSERT INTO Categories (category_name) VALUES ('HORROR');

INSERT INTO ProductCategoryLink (product_id, category_id) VALUES ('1', '1');
INSERT INTO ProductCategoryLink (product_id, category_id) VALUES ('1', '2');
INSERT INTO ProductCategoryLink (product_id, category_id) VALUES ('2', '3');
INSERT INTO ProductCategoryLink (product_id, category_id) VALUES ('2', '2');
INSERT INTO ProductCategoryLink (product_id, category_id) VALUES ('3', '1');

-- QUERY

SELECT Products.PRODUCT_ID, Products.PRODUCT_NAME, Categories.CATEGORY_NAME
FROM Products
LEFT JOIN ProductCategoryLink ON Products.PRODUCT_ID = ProductCategoryLink.PRODUCT_ID
LEFT JOIN Categories ON ProductCategoryLink.CATEGORY_ID = Categories.CATEGORY_ID
ORDER BY Products.PRODUCT_ID, Categories.CATEGORY_ID