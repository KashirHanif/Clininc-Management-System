create database clinic_management_db

create table login_table (
	username varchar(50),
	password varchar(50)
)

insert into login_table values('admin','admin123')

select * from login_table