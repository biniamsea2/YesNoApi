# YesNoApi  
*Author: Biniam Tesfamariam*

----

## Program Summary 
This is a yes/ no api that generates a random yes/ no with a gif. This application was created using Visual Studio 2019 and written in C#. This application has two get methods: 

- [HttpGet] Gets one random yes/ no with a gif from the database.  
- [HttpGet("{id}")] Gets one yes/ no from the database based on the ID given from the user.   

## Application Specifications
###### This application includes the following:  

#### 1) Startup File 
- DBContext registered in ConfigureServices  
- Service registered in ConfigureServices    
- Use of static files accepted  

#### 2) Controller  
- YesNoController  

#### 3) Data  
- DBContext present and properly configured  
- DB Tables for each entity model (DbSet<YesNo>)  
- appsettings.json file present with name of database updated.  
 
#### 4) Models  
- Each Entity from the DB Table converted into a Model  
- Proper naming conventions of Primary keys  
- Navigation properties present in each Model where required  
---

### Getting Started
Clone this repository to your local machine.

```
$ git clone https://github.com/biniamsea2/YesNoApi.git
```

### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```YesNoApp``` directory.

Then select and open ```YesNoApp.sln```

---

### Visuals

### Get random record
![Image 1](https://github.com/biniamsea2/KobeAPI/blob/master/Screenshot%20(4).png)
### Get record based on ID
![Image 1](https://github.com/biniamsea2/KobeAPI/blob/master/Screenshot%20(5).png)
### Get all records
![Image 1](https://github.com/biniamsea2/KobeAPI/blob/master/Screenshot%20(6).png)

---
### Records Table:  
The "YesNoTable" in our YesNoDB database consists of 10 yes/ no. Each row has information regarding a primary ID key, yes/ no, and a gif. 

---
