-- select * from categories;
-- select * from products;

-- find all products
SELECT * FROM products;
-- find all products that cost $1400
SELECT * FROM products -- select * from products;//the semicolon isn't used until the end of the coding sequence, which in this case happens to be on two different lines, so the semicolon acts as the actual ending of that line of code in SQL.
WHERE price = 1400;
-- find all products that cost $11.99 or $13.99
SELECT * FROM products
WHERE price = 11.99 OR price = 13.99; -- where price = 11.99 or 13.99;//need to be specific here.
-- find all products that do NOT cost 11.99 - using NOT
SELECT * FROM products
WHERE NOT price = 11.99;
-- find all products and sort them by price from greatest to least
SELECT * FROM products -- this is how you build a query; by looking at all of the data from all of the tables.
ORDER BY price DESC; -- order by price;//default order by functionality has items with the least value starting form the top, and then the greatest valued items at the bottom.
-- find all employees who don't have a middle initial
SELECT * FROM employees
WHERE middleinitial is null; -- where middle initial is null;//cannot have a space between category types.
-- find distinct product prices
SELECT DISTINCT(price) FROM products;
-- find all employees whose first name starts with the letter ‘j’
SELECT * FROM employees -- //% sign must be used in tandem with the like keyword.
WHERE firstname like 'j%'; -- The % sign acts like more of a generality; a wild card, at least if it's typed in at the very end, as opposed to the start (%j [this insinuates that the letter j would be specified at the end of a first name in this context versus j% [this suggests that j could be at the beginning of the first name]). There's also '%j%' which seems to showcase first names that or end with the letter j here.
-- find all Macbooks
SELECT * FROM products
WHERE NAME LIKE '%macbook%';
-- find all products that are on sale
SELECT * FROM products
WHERE onsale = 1; -- finally got this one up and working -- altering the commands from lower to capital casing made no difference, but for the sake of good coding practices; I'll maintain the habit of writing int he commands and functions for SQL IN CAPITAL LETTERS.
-- find the average price of all products
SELECT AVG(price) FROM products;
-- find all Geek Squad employees who don't have a middle initial
SELECT * FROM employees
WHERE title LIKE '%geek squad%' AND middleinitial IS NULL; -- //where title like '%geek squad%' && middleinitial is null; I'm so used to utilizing the && operators in C#.... that I used them here in SQL, lol.... and SQL didn't even throw compile error nor a run time error.
-- find all products from the products table whose stock level is in the range -- of 500 to 1200. Order by Price from least to greatest. Hint: Use the between keyword
SELECT * FROM products
WHERE stocklevel BETWEEN 500 AND 1200
ORDER BY price ASC;