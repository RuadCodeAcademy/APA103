create database CompanyMM
use CompanyMM

create table Employees(
EmployeeID int primary key identity,
FirstName nvarchar(50) not null,
LastName nvarchar (50) not null,
BirthDate date not null,
Email varchar(50) unique,
CHECK (BirthDate < GETDATE())
)

create table Projects(
ProjectID int primary key identity,
ProjectName nvarchar(50) not null,
StartDate date not null,
EndDate date,
 CHECK (EndDate IS NULL OR EndDate >= StartDate)

)


create table EmployeeProjects (
EmployeeID int,
ProjectID int, 
AssignedDate date not null,

PRIMARY KEY (EmployeeID, ProjectID),

foreign key (EmployeeID) references Employees(EmployeeID),

foreign key (ProjectID) references Projects(ProjectID),

CHECK (AssignedDate <= GETDATE())

)

insert into Employees(FirstName, LastName, BirthDate, Email)
values
('Ali', 'Mammadov', '1990-05-12', 'ali.mammadov@mail.com'),
('Aysel', 'Aliyeva', '1995-08-22', 'aysel.aliyeva@mail.com'),
('Rashad', 'Huseynov', '1988-03-10', 'rashad.huseynov@mail.com'),
('Nigar', 'Ismayilova', '1992-11-30', 'nigar.ismayilova@mail.com'),
('Tural', 'Karimov', '1985-07-18', 'tural.karimov@mail.com');


insert into Projects (ProjectName, StartDate, EndDate)
values
('Website Development', '2024-01-01', '2024-06-01'),
('Mobile App', '2024-03-15', NULL),
('Database Migration', '2023-09-01', '2024-02-01');


insert into EmployeeProjects (EmployeeID, ProjectID, AssignedDate)
values
(1, 1, '2024-01-02'),
(1, 2, '2024-03-20'),
(2, 1, '2024-01-05'),
(3, 3, '2023-09-10'),
(4, 2, '2024-03-18'),
(5, 1, '2024-01-10');



select * from Employees

select * from Projects


SELECT 
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    p.ProjectName,
    ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;


SELECT 
    p.ProjectName,
    COUNT(ep.EmployeeID) AS EmployeeCount
FROM Projects p
LEFT JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
GROUP BY p.ProjectName;


SELECT 
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    COUNT(ep.ProjectID) AS ProjectCount
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(ep.ProjectID) > 2;


CREATE VIEW EmployeeProjectView AS
SELECT 
    e.EmployeeID,
    e.FirstName + ' ' + e.LastName AS FullName,
    p.ProjectID,
    p.ProjectName,
    ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;

SELECT *
FROM EmployeeProjectView
WHERE EmployeeID = 1;


CREATE PROCEDURE sp_AssignEmployeeToProject
    @empId INT,
    @projId INT
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 
        FROM EmployeeProjects
        WHERE EmployeeID = @empId AND ProjectID = @projId
    )
    BEGIN
        INSERT INTO EmployeeProjects (EmployeeID, ProjectID, AssignedDate)
        VALUES (@empId, @projId, GETDATE());
    END
END;



CREATE FUNCTION fn_GetProjectCount (@empId INT)
RETURNS INT
AS
BEGIN
    DECLARE @count INT;

    SELECT @count = COUNT(*)
    FROM EmployeeProjects
    WHERE EmployeeID = @empId;

    RETURN @count;
END;


SELECT dbo.fn_GetProjectCount(1) AS ProjectCount;

EXEC sp_AssignEmployeeToProject @empId = 1, @projId = 3;


SELECT * 
FROM EmployeeProjects
WHERE EmployeeID = 1;


DELETE FROM EmployeeProjects
WHERE EmployeeID = 1;
