create database school
create table users 
(
ID int primary key IDENTITY(1,1),
username nvarchar(60) NULL,
password nvarchar(60) NULL
)
insert into users (username, password) values ('Abdimalik', 'mahadalle2004')

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

create table teachers
(
ID int primary key IDENTITY (1,1),
teachers_name nvarchar(60) null,
teachers_gender nvarchar(60) null,
teachers_addres nvarchar(60) null,
teachers_status nvarchar(60) null,
students_image nvarchar(max) null,
date_insert DATE null,
date_update date null,
date_delete date null,
)
select * from studdents


ALTER TABLE studdents
DROP COLUMN students_status;


create table teacherss
(
ID int primary key IDENTITY (1,1),
teachers_name nvarchar(60) null,
teachers_gender nvarchar(60) null,
teachers_addres nvarchar(60) null,
teachers_status nvarchar(60) null,
teachers_image nvarchar(max) null,
date_insert DATE null,
date_update date null,
date_delete date null,
)