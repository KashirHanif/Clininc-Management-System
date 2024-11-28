create database clinic_management_db

--Structure

create table login_table (
	 emp_id int primary key,
	foreign key (emp_id) references tbl_employee(emp_id),
	username varchar(50),
	password varchar(50)
);

create table tbl_employee (
	emp_id int IDENTITY(1,1) primary key,
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
	patient_id int identity(1,1) primary key,
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
	specialization_id int identity(1,1) primary key,
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
	appointment_id int identity(1,1) primary key,
	booked_by_emp_id int,
	booked_for_emp_id int,
	foreign key (booked_by_emp_id) references tbl_employee(emp_id),
	foreign key (booked_for_emp_id) references tbl_employee(emp_id),
	date_of_appointment date not null,
	time_of_appointment time not null,
	appointment_status varchar(20) not null
);

create table tbl_treatment (
	treatment_id int identity(1,1) primary key,
	treatment_type varchar(20),
	treatment_date date,
	diagnosis varchar(20),
	emp_id int,
	patient_id int,
	foreign key (emp_id) references tbl_employee(emp_id),
	foreign key (patient_id) references tbl_patient(patient_id),
);

create table tbl_billing (
	bill_id int identity(1,1) primary key,
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
    item_id int identity(1,1) primary key,
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

create table tbl_emp_working_hours (
	emp_id int,
	foreign key(emp_id) references tbl_employee(emp_id),
	start_duty time not null,
	end_duty time not null,
	emp_status varchar(20) default 'Available'
)


create table tbl_emp_shift (
	emp_id int,
	foreign key(emp_id) references tbl_employee(emp_id),
	start_time time not null,
	end_time time not null,
	date_of_shift date not null
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

ALTER TABLE login_table
ADD CONSTRAINT UQ_username UNIQUE (username);

ALTER TABLE tbl_employee
ADD CONSTRAINT unique_cnic_employee UNIQUE (cnic);

ALTER TABLE tbl_patient
ADD CONSTRAINT unique_cnic_patient UNIQUE (cnic);


ALTER TABLE tbl_appointment
ADD patient_id INT;

ALTER TABLE tbl_appointment
ADD appointment_type VARCHAR(50);

ALTER TABLE tbl_appointment
ADD CONSTRAINT fk_patient_id FOREIGN KEY (patient_id) REFERENCES tbl_patient(patient_id);


--Query


insert into tbl_patient (p_f_name, p_l_name, father_name, date_of_birth, street, block, city, country, ph_country_code, phone_number, gender, age, cnic) values ('Ali', 'Khan', 'Ahmed Khan', '1990-05-15', 123, 'A', 'Lahore', 'Pakistan', '+92', '3001234567', 'Male', 33,2947192037402);

-- Insert 20 more rows into tbl_patient
INSERT INTO tbl_patient 
(p_f_name, p_l_name, father_name, date_of_birth, street, block, city, country, ph_country_code, phone_number, gender, age, cnic)
VALUES
('Sara', 'Khan', 'Imran Khan', '1995-08-12', 456, 'B', 'Karachi', 'Pakistan', '+92', '3219876543', 'Female', 29, 3847220193842),
('Ahmed', 'Ali', 'Saeed Ali', '1988-03-10', 789, 'M', 'Islamabad', 'Pakistan', '+92', '3345678901', 'Male', 36, 3849312345671),
('Fatima', 'Zafar', 'Hassan Zafar', '1992-12-25', 123, 'K', 'Lahore', 'Pakistan', '+92', '3421122334', 'Female', 31, 3748150193847),
('Hassan', 'Raza', 'Adeel Raza', '1990-06-15', 456, 'A', 'Rawalpindi', 'Pakistan', '+92', '3104567890', 'Male', 34, 3749123478563),
('Ayesha', 'Malik', 'Hamid Malik', '1985-11-20', 789, 'P', 'Faisalabad', 'Pakistan', '+92', '3225678904', 'Female', 39, 3847220193831),
('Bilal', 'Hameed', 'Yasir Hameed', '1997-07-07', 123, 'I', 'Multan', 'Pakistan', '+92', '3129876541', 'Male', 27, 3849350127842),
('Zara', 'Iqbal', 'Shahid Iqbal', '1991-09-09', 456, 'H', 'Quetta', 'Pakistan', '+92', '3312345678', 'Female', 33, 3748120193849),
('Ali', 'Shah', 'Naveed Shah', '1993-01-01', 789, 'S', 'Peshawar', 'Pakistan', '+92', '3434567890', 'Male', 31, 3849212387456),
('Maira', 'Ahmed', 'Fahad Ahmed', '1996-04-18', 123, 'F', 'Hyderabad', 'Pakistan', '+92', '3209876543', 'Female', 28, 3748123456789),
('Usman', 'Zahid', 'Nadeem Zahid', '1989-08-08', 456, 'R', 'Sialkot', 'Pakistan', '+92', '3104567891', 'Male', 35, 3749213947502),
('Anam', 'Chaudhry', 'Farhan Chaudhry', '1994-10-15', 789, 'H', 'Gujranwala', 'Pakistan', '+92', '3331234567', 'Female', 30, 3847210123456),
('Hamza', 'Iqbal', 'Sajid Iqbal', '1998-03-25', 123, 'Z', 'Bahawalpur', 'Pakistan', '+92', '3125678910', 'Male', 26, 3849345782930),
('Rabia', 'Naeem', 'Shafiq Naeem', '1990-12-05', 456, 'F', 'Sargodha', 'Pakistan', '+92', '3456789123', 'Female', 34, 3748134509284),
('Kashif', 'Ali', 'Irfan Ali', '1987-06-10', 789, 'O', 'Abbottabad', 'Pakistan', '+92', '3145678903', 'Male', 37, 3849203948123),
('Saima', 'Hassan', 'Faisal Hassan', '1989-09-19', 123, 'L', 'Mardan', 'Pakistan', '+92', '3214567890', 'Female', 35, 3847193048571),
('Imran', 'Javed', 'Kamran Javed', '1985-01-20', 456, 'G', 'Sahiwal', 'Pakistan', '+92', '3415678912', 'Male', 39, 3748190123945),
('Neha', 'Rehman', 'Tariq Rehman', '1993-03-13', 789, 'B', 'Okara', 'Pakistan', '+92', '3445678912', 'Female', 9, 3847293847501),
('Danish', 'Sadiq', 'Zafar Sadiq', '1992-11-30', 123, 'Q', 'Sukkur', 'Pakistan', '+92', '3112345678', 'Male', 32, 3849201938476),
('Iqra', 'Tariq', 'Rashid Tariq', '1999-02-02', 456, 'E', 'Rahim Yar Khan', 'Pakistan', '+92', '3219876543', 'Female', 25, 3849340123948),
('Shahzaib', 'Malik', 'Adnan Malik', '1986-07-22', 789, 'B', 'Kasur', 'Pakistan', '+92', '3147890123', 'Male', 38, 3749128374051);
INSERT INTO tbl_patient 
(p_f_name, p_l_name, father_name, date_of_birth, street, block, city, country, ph_country_code, phone_number, gender, age, cnic)
VALUES
('Nimra', 'Aslam', 'Javed Aslam', '1994-09-11', 123, 'B', 'Sheikhupura', 'Pakistan', '+92', '3106789123', 'Female', 30, 3748123948756),
('Taimoor', 'Ahmed', 'Asghar Ahmed', '1988-05-19', 456, 'O', 'Gujrat', 'Pakistan', '+92', '3123456789', 'Male', 36, 3847203948123),
('Sana', 'Zahid', 'Khalid Zahid', '1993-02-14', 789, 'A', 'Chakwal', 'Pakistan', '+92', '3209876541', 'Female', 31, 3847210938475),
('Raza', 'Hussain', 'Shahbaz Hussain', '1990-10-30', 123, 'B', 'Mansehra', 'Pakistan', '+92', '3434567890', 'Male', 34, 3849123478501),
('Mahnoor', 'Farooq', 'Tanveer Farooq', '1995-12-20', 456, 'B', 'Haripur', 'Pakistan', '+92', '3112345678', 'Female', 29, 3748192037456);


select * from tbl_patient
select * from tbl_employee




--login on base of designation
SELECT e.designation 
FROM login_table l
LEFT OUTER JOIN tbl_employee e 
ON l.emp_id = e.emp_id


-- Insert receptionist
insert into tbl_employee (designation, f_name, l_name, father_name, date_of_birth, date_of_joining, street, city, block, house_no, ph_country_code, phone_number, gender, institution, cnic)
values ('Receptionist', 'Ayesha', 'Khan', 'Ali Khan', '1990-07-10', '2024-11-20', 456, 'Lahore', 'A', 15, '+92', '3012345678', 'Female', 'Lahore City Clinic', 3220193847567);

insert into login_table (emp_id, username, password)
values (1, 'receptionist', 'receptionist123');

-- Insert admin
insert into tbl_employee (designation, f_name, l_name, father_name, date_of_birth, date_of_joining, street, city, block, house_no, ph_country_code, phone_number, gender, institution, cnic)
values ('Admin', 'Imran', 'Shah', 'Zafar Shah', '1988-11-05', '2024-11-21', 789, 'Islamabad', 'C', 12, '+92', '3023456789', 'Male', 'Capital Health Solutions', 3230123984756);

insert into login_table (emp_id, username, password)
values (2, 'admin', 'admin123');
-- Insert doctor
insert into tbl_employee (designation, f_name, l_name, father_name, date_of_birth, date_of_joining, street, city, block, house_no, ph_country_code, phone_number, gender, institution, cnic)
values ('Doctor', 'Ahmed', 'Raza', 'Khalid Raza', '1985-03-20', '2024-11-18', 123, 'Karachi', 'B', 21, '+92', '3001234567', 'Male', 'Karachi General Hospital', 3210123456789);

insert into login_table (emp_id, username, password)
values (3, 'doctor', 'doctor123');

select * from tbl_employee

select * from tbl_appointment
select appointment_id from tbl_appointment a
where a.booked_for_emp_id in (
	SELECT emp_id 
	FROM tbl_employee e
	WHERE CONCAT(e.f_name, ' ', e.l_name) = 'Ahmed Raza'
)


-- Insert two appointments for emp_id, booked by emp_id = 1
INSERT INTO tbl_appointment (booked_by_emp_id, booked_for_emp_id, date_of_appointment, time_of_appointment, appointment_status,patient_id,appointment_type)
VALUES
(1, 2, '2024-11-29', '10:30:00', 'Attended',2,'Online'),
(1, 3, '2024-11-29', '14:00:00', 'Booked',5,'Walk in'),
(1, 3, '2024-10-29', '14:00:00', 'Booked',8,'Online');

-- Inserting into tbl_emp_working_hours
INSERT INTO tbl_emp_working_hours (emp_id, start_duty, end_duty)
VALUES (3, '09:00:00', '17:00:00');



select top 1 a.time_of_appointment from tbl_employee e
inner join tbl_appointment a
on a.date_of_appointment = CAST(GETDATE() AS DATE) and a.appointment_status = 'booked'
where e.emp_id in (
	SELECT emp_id 
	FROM tbl_employee e
	WHERE CONCAT(e.f_name, ' ', e.l_name) = 'Ahmed Raza'
)
order by a.time_of_appointment desc

select * from tbl_emp_working_hours
select * from tbl_emp_shift
select * from tbl_appointment


