create database clinic_management_db

--Structure

create table login_table (
	username varchar(50),
	password varchar(50)
)

--Query

insert into login_table values('admin','admin123')

select * from login_table