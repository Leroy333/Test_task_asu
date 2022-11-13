# Test_task_asu
  1 задание.
  
![image](https://user-images.githubusercontent.com/71041667/201525984-5167036f-b9a9-499a-950e-8347a28165d9.png)
# Решение: 
```rb
CREATE TABLE Users(
id INT NOT NULL PRIMARY KEY,
name VARCHAR(100),
parentId INT,
FOREIGN KEY (parentId) REFERENCES Users(id));

INSERT INTO Users VALUES(1,'Иван',NULL), 
(2,'Екатерина',1),(3,'Тамара',1),
(4,'Евгений',2),(5,'Илья',2),
(6,'Антон',3),(7,'Влада',3),
(8,'Никита',3),(9,'Василиса',6),
(10,'Мария',6),(11,'Андрей',8);

SELECT * FROM Users;

WITH RECURSIVE name_chain(id, name, path) AS ( 
          SELECT id, name, CAST(name AS CHAR(100))  
          FROM Users
          WHERE parentId IS NULL 
          UNION ALL 
          SELECT us.id, us.name, CONCAT(nc.path,'.',us.name) 
          FROM name_chain nc JOIN Users us ON nc.id=us.parentId) 
       SELECT * FROM name_chain;
 ```
 
# Результат: 
![image](https://user-images.githubusercontent.com/71041667/201526130-e2c387ae-1f81-4a8b-9fbd-a898b0ed44c5.png)


