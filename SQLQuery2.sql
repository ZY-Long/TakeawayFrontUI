CREATE DATABASE TakeOutDB

USE TakeOutDB

--1.菜品表
CREATE TABLE MenuInfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(20),
Img VARCHAR(200),
Price DECIMAL(18,2),
TypeId INT DEFAULT(1),--默认为1是菜品  默认为2是酒水  默认为3是套餐
Remark VARCHAR(20),
BusinessInfo INT not null,
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)


--4.套餐菜品关联
CREATE TABLE MenuPackageInfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
PackageId  INT,
TypeId INT,
DetailsId INT,--具体的Id,
Count Int,
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)

--5.销量表
CREATE TABLE SalesInfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
TypeId INT,
DetailsId INT,--具体的Id,
Sales INT,
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)

--6.省
CREATE TABLE ProvinceInfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(20),

)

--7.市
CREATE TABLE CityInfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(20),
ProvinceId INT NOT NULL
)

--8.区
CREATE TABLE Arealnfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(20),
CityId INT NOT NULL
)

--9.活动表
CREATE TABLE Activity
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(20),
Content VARCHAR(200),
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)

--10.口味表
CREATE TABLE TasteInfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(20),
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)

--11.用户信息表
CREATE TABLE UserInfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
NickName VARCHAR(20),
Img VARCHAR(200),
PhoneNumber VARCHAR(40),
PassWord VARCHAR(50),
SaIt VARCHAR(200),
Email VARCHAR(50),
RealName varchar(50),
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)

--12.用户地址表
CREATE TABLE AddressInfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
ProvinceId INT,
CityId INT,
Area INT,
Content VARCHAR(200),
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)

--13.购物车
CREATE TABLE CartInfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
UserId INT,
BusinessInfo INT not null,
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)

--14.购物车详情表
CREATE TABLE CartDetails
(
Id INT PRIMARY KEY IDENTITY(1,1),
TypeId INT,
DetailsId INT,--具体的Id,
Count INT,
TasteId INT,
ToPrice DECIMAL(18,2),
CartId int,
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)
drop table CartDetails

select m.Name 菜品名称,m.Img 菜品图片,m.Price 菜品价钱,d.Name 酒水名称,d.Img 酒水图片,d.Price 酒水价钱,t.Name 口味,p.Name 套餐名称,p.Img 套餐图片,p.Price 套餐价钱 from CartDetails as c
join MenuInfo as m on c.Id=m.TypeId
join DrinkInfo as d on c.Id=d.TypeId
join TasteInfo as t on t.Id=c.TasteId
join PackageInfo as p on p.TypeId=c.Id
select m.Name,m.Img,m.Price,d.Name,d.Img,d.Price,t.Name,p.Name,p.Img,p.Price from CartDetails as c
join MenuInfo as m on c.Id=m.TypeId
join DrinkInfo as d on c.Id=d.TypeId
join TasteInfo as t on t.Id=c.TasteId
join PackageInfo as p on p.TypeId=c.Id

insert into CartDetails (TypeId,DetailsId,Count,TasteId,ToPrice) values()
--15.订单表
CREATE TABLE OrderInfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
UserId int,
AddressId INT,
DataState INT,
Freight INT,--运费
PackagingFee INT, --包装费
TablewareCount INT,--餐具数量
ActivityId INT,--活动Id
TotalPrice decimal(18,2),--总价
Consignee VARCHAR(50),--收货人
BusinessInfo INT NOT NULL,--商家ID
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)

--16.订单详情表
CREATE TABLE OrderDetails
(
Id INT PRIMARY KEY IDENTITY(1,1),
OrderId INT,
TypeId INT,
DetailsId INT,
Count INT,
TasteId INT,
Content VARCHAR(200),
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)
--17.商家表
CREATE TABLE BusinessInfo
(
Id INT PRIMARY KEY IDENTITY(1,1),
Img varchar(200),
Name varchar(50),
PhoneNumber varchar(50),
ContactPerson VARCHAR(50),
Merchataddress varchar(100),
Sates int DEFAULT (1),
CreateTime datetime default(GETDATE()),
UpdateTime datetime default(GETDATE()),
CreaterId int DEFAULT(1),
UpdaterId int DEFAULT(1)
)