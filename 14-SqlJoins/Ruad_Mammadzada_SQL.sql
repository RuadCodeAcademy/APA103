CREATE DATABASE Company2
USE Company2


CREATE TABLE Countries (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50)
)


CREATE TABLE Cities (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50),
    CountryId INT,
    FOREIGN KEY (CountryId) REFERENCES Countries(Id)
)

CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50),
    Surname NVARCHAR(50),
    Age INT,
    Salary DECIMAL(10,2),
    Position NVARCHAR(50),
    IsDeleted BIT,
    CityId INT,
    FOREIGN KEY (CityId) REFERENCES Cities(Id)
)

INSERT INTO Countries (Name) VALUES
('Azerbaijan'),
('Turkey'),
('Germany')

INSERT INTO Cities (Name, CountryId) VALUES
('Baku', 1),
('Ganja', 1),
('Istanbul', 2),
('Berlin', 3)


INSERT INTO Employees (Name, Surname, Age, Salary, Position, IsDeleted, CityId) VALUES
('Ali', 'Aliyev', 25, 2500, 'Developer', 0, 1),
('Veli', 'Veliyev', 30, 1800, 'Reseption', 0, 2),
('Ayse', 'Demir', 28, 3000, 'Manager', 0, 3),
('John', 'Smith', 35, 1500, 'Reseption', 1, 4),
('Leyla', 'Huseynova', 27, 2200, 'HR', 0, 1)




select e.Name,e.Surname, c.Name as City, co.Name as Country  from Employees e
join Cities c on CityId = c.Id
join Countries co on CountryId = co.Id

select e.Name,e.Surname, e.Age, co.Name as Country  from Employees e
join Cities c on CityId = c.Id
join Countries co on CountryId = co.Id
where e.Salary > 2000

select  c.Name as City, co.Name as Country  from Employees e
join Cities c on CityId = c.Id
join Countries co on CountryId = co.Id

select Name, Surname,Age,Salary,Position,IsDeleted from Employees
where Position = 'reseption'

select    c.Name as City, co.Name as Country, e.Name, e.Surname from Employees e
join Cities c on CityId = c.Id
join Countries co on CountryId = co.Id
where IsDeleted = 1



