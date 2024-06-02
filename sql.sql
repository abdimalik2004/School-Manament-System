create table users 
(
Id int primary key IDENTITY(1,1),
username nvarchar(60) NULL,
password nvarchar(60) NULL
)
select * from users

insert into users (username, password) values ('Abdimalik', 'mahadalle2004')
select * from users

create table studdents
(
ID int primary key IDENTITY (1,1),
students_name nvarchar(60) null,
students_gender nvarchar(60) null,
students_addres nvarchar(60) null,
students_grade nvarchar(60) null,
students_section nvarchar(60) null,
students_image nvarchar(max) null,
students_status nvarchar(60) null,
date_insert DATE null,
date_update date null,
date_delete date null,
)