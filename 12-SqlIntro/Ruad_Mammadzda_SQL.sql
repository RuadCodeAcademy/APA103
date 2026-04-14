CREATE DATABASE Company 

USE Company

create table Employees(
EmployeeID int,
FirstName nvarchar(max),
LastName nvarchar(max),
Email varchar(max),
PhoneNumber varchar(max),
HireDate date,
JobTitle nvarchar(max),
Salary money,
Department nvarchar(max)
)

insert into Employees(EmployeeID,FirstName,LastName,Email,PhoneNumber,HireDate,JobTitle,Salary,Department)
values
(1, 'Ali', 'Mammadov', 'ali.mammadov@company.az', '+994501112233', '2019-05-10', 'Software Developer', 2500, 'IT'),
(2, 'Leyla', 'Hasanova', 'leyla.hasanova@company.az', '+994502223344', '2021-03-15', 'HR Specialist', 1800, 'HR'),
(3, 'Rashad', 'Aliyev', 'rashad.aliyev@company.az', '+994503334455', '2022-07-20', 'Data Analyst', 2200, 'IT'),
(4, 'Aysel', 'Quliyeva', 'aysel.quliyeva@gmail.com', '+994504445566', '2018-11-01', 'Accountant', 1700, 'Finance'),
(5, 'Nigar', 'Huseynova', 'nigar.huseynova@company.az', '+994505556677', '2020-01-25', 'Finance Specialist', 2100, 'Finance'),
(6, 'Orxan', 'Karimov', 'orxan.karimov@company.az', '+994506667788', '2023-02-10', 'System Admin', 2600, 'IT'),
(7, 'Sabina', 'Aliyeva', 'sabina.aliyeva@company.az', '+994507778899', '2017-09-05', 'HR Manager', 2400, 'HR'),
(8, 'Elvin', 'Ismayilov', 'elvin.ismayilov@yahoo.com', '+994508889900', '2021-06-30', 'Support Engineer', 1500, 'IT'),
(9, 'Gunel', 'Rahimova', 'gunel.rahimova@company.az', '+994509990011', '2019-12-12', 'Accountant', 1900, 'Finance'),
(10, 'Tural', 'Bayramov', 'tural.bayramov@company.az', '+994501234567', '2024-01-01', 'Junior Developer', 1400, 'IT');


select * from Employees

select * from Employees where Salary > 2000

select * from Employees where Department = 'IT'

select * from Employees order by Salary desc

select FirstName,Salary from Employees

select * from Employees where HireDate > '2020-12- 31'

select * from Employees where Email like   '%company.az%'

select  max(Salary) as maxsalary  from Employees

select  min(Salary) as minsalary from Employees

select  avg(Salary) as Avgsalary from Employees

select count(*)  as iscisayi from Employees

select sum(Salary) as maaslarcemi from Employees

select Department, count(*) as iscisayi from Employees
group by Department

select Department, avg(Salary) as AvgSalary from Employees
group by Department

select Department, max(Salary) as Maxsalary from Employees
group by Department 

update Employees set Salary = 2800 where EmployeeID = 1

select * from Employees

update Employees set Salary = Salary * 1.1 where Department = 'IT'

update Employees set JobTitle = 'HR Meneceri' where EmployeeID = 2

delete Employees where EmployeeID = 5

insert into Employees(EmployeeID,FirstName,LastName,Email,PhoneNumber,HireDate,JobTitle,Salary,Department)
values
(5, 'Kamal', 'Aliyev', 'kamal.aliyev@company.az', '+994501111111', '2022-05-05', 'Intern', 1200, 'IT')

insert into Employees(EmployeeID,FirstName,LastName,Email,PhoneNumber,HireDate,JobTitle,Salary,Department)
values
(11, 'Murad', 'Qasimov', 'murad.qasimov@company.az', '+994509876543', '2023-08-12', 'Assistant', 1300, 'Finance')

delete Employees where Salary < 1500

select * from Employees where FirstName like '%a%'

select * from Employees where  Salary BETWEEN  2000 and 2500 

select * from Employees where Department in ('finance', 'it')