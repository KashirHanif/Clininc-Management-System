create database clinic_management_db

--Structure



create table login_table (
	emp_id int,
	foreign key (emp_id) references tbl_employee(emp_id),
	username varchar(50),
	password varchar(50)
);

create table tbl_employee (
	emp_id int primary key,
	designation varchar(50),
	f_name varchar(50),
	l_name varchar(50),
	father_name varchar(50),
	date_of_birth date,
	date_of_joining date,
	street int,
	city varchar(50) not null,
	block varchar(1),
	house_no int,
	ph_country_code varchar(10),
	phone_number varchar(20),
	gender varchar(10),
	institution varchar(50)
);

create table tbl_patient (
	patient_id int primary key,
	p_f_name varchar(20),
	p_l_name varchar(20),
	father_name varchar(30),
	date_of_birth date,
	street int,
	block varchar(1),
	city varchar(50),
	country varchar(50),
	ph_country_code varchar(10),
	phone_number varchar(20),
	gender varchar(10),
	age int
);

create table tbl_specialization (
	specialization_id int primary key,
	specialization varchar(20)
);

create table tbl_emp_specialization (
	employee_id int,
	specialization_id int,
	foreign key (employee_id) references tbl_employee(emp_id),
	foreign key (specialization_id) references tbl_specialization(specialization_id),
	primary key (employee_id,specialization_id)
);

create table tbl_appointment(
	appointment_id int primary key,
	booked_by_emp_id int,
	booked_for_emp_id int,
	foreign key (booked_by_emp_id) references tbl_employee(emp_id),
	foreign key (booked_for_emp_id) references tbl_employee(emp_id),
	date_of_appointment date not null,
	time_of_appointment time not null,
	appointment_status varchar(20) not null
);

create table tbl_treatment (
	treatment_id int primary key,
	treatment_type varchar(20),
	treatment_date date,
	diagnosis varchar(20),
	emp_id int,
	patient_id int,
	foreign key (emp_id) references tbl_employee(emp_id),
	foreign key (patient_id) references tbl_patient(patient_id),
);

create table tbl_billing (
	bill_id int primary key,
	total_bill decimal(10, 2) not null,
	emp_fee decimal(10, 2) not null,
	treatment_cost decimal(10, 2) not null,
	hospital_profit_percent decimal(5,2),
	emp_id int,
	patient_id int,
	foreign key (emp_id) references tbl_employee(emp_id),
	foreign key (patient_id) references tbl_patient(patient_id),
);

create table tbl_inventory (
    item_id int primary key,
    item_name varchar(50) not null,
    category varchar(30),
    num_of_packs decimal(10, 2) default 0.00 check (num_of_packs >= 0),
    strips_per_pack decimal(10, 2) default 0.00 check (strips_per_pack >= 0),
    tablets_per_strip int default 0 check (tablets_per_strip >= 0),
    quantity_of_strips decimal(10, 2) default 0.00 check (quantity_of_strips >= 0),
    quantity_of_tablets decimal(10, 2) default 0.00 check (quantity_of_tablets >= 0),
    purchase_price decimal(10, 2) not null check (purchase_price > 0),
    selling_price decimal(10, 2) not null,
    expiration_date date not null,
    date_of_purchase date not null,
    item_status varchar(20),
    batch_no varchar(10)
);

create table tbl_treatment_inventory (
    treatment_id int,
    item_id int,
    quantity_used decimal(10, 2) not null check (quantity_used >= 0),
    primary key (treatment_id, item_id),
    foreign key (treatment_id) references tbl_treatment(treatment_id),
    foreign key (item_id) references tbl_inventory(item_id)
);

alter table tbl_inventory
add constraint chk_selling_price check (selling_price >= purchase_price);

alter table tbl_inventory
add constraint chk_expiration_date check (expiration_date > date_of_purchase);

create index idx_batch_no on tbl_inventory(batch_no);


alter table tbl_emp_specialization 
add institute varchar(30)

alter table tbl_employee
add cnic varchar(15)

alter table tbl_patient
add cnic varchar(15)

alter table tbl_inventory
add bill_id int;

alter table tbl_inventory
add constraint fk_bill_id foreign key (bill_id) references tbl_billing(bill_id)

alter table tbl_billing
add treatment_id int

alter table tbl_billing
add constraint fk_treatment_id foreign key (treatment_id) references tbl_treatment(treatment_id);


alter table tbl_inventory
drop constraint fk_bill_id;

alter table tbl_inventory
drop column bill_id;

--Query


insert into tbl_patient  values (1, 'Ali', 'Khan', 'Ahmed Khan', '1990-05-15', 123, 'A', 'Lahore', 'Pakistan', '+92', '3001234567', 'Male', 33);


select * from login_table
select * from tbl_patient

insert into tbl_employee (emp_id, designation, f_name, l_name, father_name, date_of_birth, date_of_joining, street, city, block, house_no, ph_country_code, phone_number, gender, institution, cnic)
values (1, 'Doctor', 'Ahmed', 'Raza', 'Khalid Raza', '1985-03-20', '2024-11-18', 123, 'Karachi', 'B', 21, '+92', '3001234567', 'Male', 'Karachi General Hospital', '32101-2345678-9');

insert into login_table (emp_id, username, password)
values (1, 'admin', 'admin123');

