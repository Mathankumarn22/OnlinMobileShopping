CREATE TABLE Userdetails
(
userId int identity(1,1)primary key,
name varchar(25)not null,
number varchar(10) not null,
mailID varchar(30) not null,
password varchar(15)not null,

)

select * from Userdetails

CREATE procedure SP_SignUp
@name varchar(25),
@number varchar(10) ,
@mailID varchar(30) ,
@password varchar(15)

AS 
BEGIN
	INSERT INTO Userdetails(name,number,mailID,password) values(@name,@number,@mailID,@password	)
END


alter procedure SP_LogIn

@password varchar(15),
@userId INT

AS
BEGIN

SELECT 'true'  FROM UserDetails WHERE userId=@userId AND password=@password

END


CREATE procedure SP_UpdateData
@userID int,
@name varchar(25),
@number varchar(10) ,
@mailID varchar(30) ,
@password varchar(15)

AS 
BEGIN
	update Userdetails set name=@name,number=@number,mailID=@mailID,password=@password where userID=@userID
	END


CREATE PROCEDURE SP_InserData
@name varchar(25),
@number varchar(10) ,
@mailID varchar(30) ,
@password varchar(15)

AS
BEGIN
	INSERT 