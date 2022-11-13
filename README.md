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

3 задание. 

![image](https://user-images.githubusercontent.com/71041667/201526357-ec84d9e5-c516-402d-a537-8a8bd7a5c956.png)

# Решение:

```rb
const a={
    typeobj: 0,
    nameobj: 'enterprise1',
    childs:[{
        typeobj: 500,
                nameobj: 'nameobj1',
                childs:[
                    {
                        typeobj: 2,
                        nameobj: 'test',
                        child: [
                            {
                                typeobj: 2,
                                nameobj: 'test_2',
                                child: [{
                                    typeobj: 555,
                                    nameobj: 'test_3',
                                    child: [],
                                } 
                                ],
                            }
                        ],
                    }
                ]	
        },
        {
        typeobj: 500,
                nameobj: 'oilfield2',
                childs:[]	
        }
    ]
    }
let ob = [];
getFiniteValue(a);
function getFiniteValue(obj) {
    getProp(obj);
    function getProp(o) {
        for(var prop in o) {
            if(typeof(o[prop]) === 'object') {
                getProp(o[prop]);
            } else {
                if(prop === 'typeobj'){
                    let obj = {'typeobj': o[prop], 'count': 1}
                    let getProperty = ob.find(item => item.typeobj === o[prop])
                    if(getProperty){
                        let findIndex = ob.findIndex(item => item.typeobj === o[prop])
                        ob[findIndex].count += 1;
                    }
                    else{
                        ob.push(obj);
                    } 
                }
            }
        }
    }
}   
console.log(ob);
 ```
 
# Результат: 

![image](https://user-images.githubusercontent.com/71041667/201526899-862a04bb-1b24-4e98-ac16-a9e840f082de.png)

