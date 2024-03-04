INSERT INTO DailyMenu (Date) VALUES ('2024-03-01');
INSERT INTO DailyMenu (Date) VALUES ('2024-03-02');
INSERT INTO DailyMenu (Date) VALUES ('2024-03-03');
INSERT INTO DailyMenu (Date) VALUES ('2024-03-04');
INSERT INTO DailyMenu (Date) VALUES ('2024-03-05');
INSERT INTO DailyMenu (Date) VALUES ('2024-03-06');
INSERT INTO DailyMenu (Date) VALUES ('2024-03-07');


INSERT INTO Ingredients (Name, IsVeganFriendly, IsAllergen) VALUES 
('Sesame', 1, 1),
('Beans', 1, 0),
('Cheese', 0, 0),
('Tomato', 1, 0),
('Spinach', 1, 0),
('Chicken', 0, 1),
('Pasta', 1, 0);


INSERT INTO Dishes (Name, Description) VALUES 
('Sesame Salad', 'A refreshing salad with Sesame, Tomato, and Spinach'),
('Vegan Bean Burrito', 'A delicious burrito filled with Beans, Tomato, and Spinach'),
('Cheese Pizza', 'Classic pizza topped with Cheese'),
('Spinach and Tomato Pasta', 'Pasta dish with Spinach and Tomato'),
('Chicken Spinach Wrap', 'A flavorful wrap with Chicken and Spinach'),
('Sesame Chicken Stir Fry', 'Stir-fried dish with Sesame and Chicken'),
('Tomato and Spinach Omelette', 'Healthy omelette with Tomato and Spinach'),
('Cheese and Spinach Stuffed Mushrooms', 'Mushrooms stuffed with Cheese and Spinach'),
('Bean and Tomato Soup', 'A hearty soup with Beans and Tomato'),
('Pasta Primavera', 'Vegetarian pasta dish with a variety of fresh vegetables');


-- Update dishes for the given DailyMenuId values (adjust as needed)
UPDATE Dishes SET DailyMenuId = 8 WHERE Id IN (18, 19);
UPDATE Dishes SET DailyMenuId = 9 WHERE Id IN (20, 21);
UPDATE Dishes SET DailyMenuId = 10 WHERE Id IN (22, 23);
UPDATE Dishes SET DailyMenuId = 11 WHERE Id IN (24, 25);
UPDATE Dishes SET DailyMenuId = 12 WHERE Id IN (26, 27);
UPDATE Dishes SET DailyMenuId = 13 WHERE Id IN (28, 29);
UPDATE Dishes SET DailyMenuId = 14 WHERE Id IN (30, 31);


-- DishIngredient for Vegan Salad (DishId: 18)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(18, 55), -- Sesame
(18, 56), -- Beans
(18, 58), -- Tomato
(18, 59); -- Spinach

-- DishIngredient for Chicken and Spinach Salad (DishId: 19)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(19, 59), -- Spinach
(19, 60), -- Chicken
(19, 58); -- Tomato

-- DishIngredient for Penne with Parmesan (DishId: 20)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(20, 61), -- Pasta
(20, 57); -- Cheese

-- DishIngredient for Beef and Shrimp Stir-Fry (DishId: 21)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(21, 60), -- Chicken
(21, 61); -- Pasta

-- DishIngredient for Margherita Pizza (DishId: 22)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(22, 58), -- Tomato
(22, 57); -- Cheese

-- DishIngredient for Sushi Rolls (DishId: 23)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(23, 57); -- Cheese

-- DishIngredient for Eggplant Parmesan (DishId: 24)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(24, 57), -- Cheese
(24, 61); -- Pasta

-- DishIngredient for Sesame Salad (DishId: 25)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(25, 55), -- Sesame
(25, 58), -- Tomato
(25, 59); -- Spinach

-- DishIngredient for Vegan Bean Burrito (DishId: 26)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(26, 56), -- Beans
(26, 58), -- Tomato
(26, 59); -- Spinach

-- DishIngredient for Cheese Pizza (DishId: 27)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(27, 57); -- Cheese

-- DishIngredient for Spinach and Tomato Pasta (DishId: 28)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(28, 59), -- Spinach
(28, 58); -- Tomato

-- DishIngredient for Chicken Spinach Wrap (DishId: 29)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(29, 60), -- Chicken
(29, 59); -- Spinach

-- DishIngredient for Sesame Chicken Stir Fry (DishId: 30)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(30, 55), -- Sesame
(30, 60); -- Chicken

-- DishIngredient for Tomato and Spinach Omelette (DishId: 31)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(31, 58), -- Tomato
(31, 59); -- Spinach

-- DishIngredient for Cheese and Spinach Stuffed Mushrooms (DishId: 32)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(32, 57), -- Cheese
(32, 59); -- Spinach

-- DishIngredient for Bean and Tomato Soup (DishId: 33)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(33, 56), -- Beans
(33, 58); -- Tomato

-- DishIngredient for Pasta Primavera (DishId: 34)
INSERT INTO DishIngredient (DishId, IngredientsId) VALUES 
(34, 55), -- Sesame
(34, 58), -- Tomato
(34, 59); -- Spinach
