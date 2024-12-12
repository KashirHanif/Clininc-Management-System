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

create table tbl_department(
	emp_id int,
	department varchar(50),
	foreign key(emp_id) references tbl_employee(emp_id)
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
	emp_id int,
	patient_id int,
	foreign key (emp_id) references tbl_employee(emp_id),
	foreign key (patient_id) references tbl_patient(patient_id),
);


create table tbl_billing (
	bill_id int identity(1,1) primary key,
	emp_fee int,
	appointment_id int,
	foreign key (appointment_id) references tbl_appointment(appointment_id)
);

create table tbl_profit (
	hospital_profit_percent decimal(10,2),
	start_date date,
	end_date date
)

create table tbl_prescription (
    prescription_id INT IDENTITY(1,1) PRIMARY KEY,
    appointment_id INT NOT NULL,
    follow_up_date DATE,
	followUpDoctorName VARCHAR(100),
    bookedByName VARCHAR(100),
    created_at DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (appointment_id) REFERENCES tbl_appointment(appointment_id)
);

create table tbl_item (
    item_id INT IDENTITY(1,1) PRIMARY KEY,
    item_name VARCHAR(255) NOT NULL
);

create table tbl_prescription_item (
    prescription_item_id INT IDENTITY(1,1) PRIMARY KEY,
    prescription_id INT NOT NULL,
    item_id INT NOT NULL,
    item_type VARCHAR(50) NOT NULL,
    FOREIGN KEY (prescription_id) REFERENCES tbl_prescription(prescription_id),
    FOREIGN KEY (item_id) REFERENCES tbl_item(item_id)
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

alter table tbl_treatment
drop column treatment_date

alter table tbl_treatment
drop column diagnosis

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

alter table tbl_treatment
alter column treatment_type varchar(50)

alter table tbl_billing
add bill_status varchar(50)

alter table tbl_billing
add remaining_payment varchar(50)

ALTER TABLE tbl_treatment_inventory
ADD CONSTRAINT FK_tbl_treatment_inventory_item_id
FOREIGN KEY (item_id)
REFERENCES tbl_inventory(item_id);


create nonclustered index idx_patient_name_phone
on tbl_patient (p_f_name, p_l_name, phone_number);

create nonclustered index ix_tbl_employee_f_name_l_name
on tbl_employee (f_name, l_name);

create clustered index ix_tbl_emp_working_hours_emp_status
on tbl_emp_working_hours (emp_status);

create nonclustered index ix_tbl_appointment_appointment_status
on tbl_appointment (appointment_status);

create nonclustered index ix_tbl_inventory_item_name_item_status
on tbl_inventory (item_name, item_status);


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

INSERT INTO tbl_employee (designation, f_name, l_name, father_name, date_of_birth, date_of_joining, street, city, block, house_no, ph_country_code, phone_number, gender, institution, cnic)
VALUES ('Doctor', 'Sara', 'Iqbal', 'Abdul Sattar', '1988-10-12', '2024-11-20', 789, 'Islamabad', 'D', 10, '+92', '3005551234', 'Female', 'Islamabad International Hospital', 3212345678901);


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

INSERT INTO tbl_emp_working_hours (emp_id, start_duty, end_duty)
VALUES (4, '08:00:00', '16:00:00');




select top 1 a.time_of_appointment from tbl_employee e
inner join tbl_appointment a
on a.date_of_appointment = CAST(GETDATE() AS DATE) and a.appointment_status = 'booked'
where a.booked_for_emp_id in (
	SELECT emp_id 
	FROM tbl_employee e
	WHERE CONCAT(e.f_name, ' ', e.l_name) = 'Ahmed Raza'
)
order by a.time_of_appointment desc




select * from tbl_emp_working_hours
select * from tbl_emp_shift
select * from tbl_appointment

select concat(f_name,' ', l_name) from tbl_employee
where designation = 'Doctor' 
  and emp_id IN (
      select emp_id from tbl_emp_working_hours 
      where emp_status = 'Available'
  );



select * from tbl_patient p
where p.patient_id in (
	select patient_id from tbl_appointment a
	where a.date_of_appointment = CAST(GETDATE() AS DATE) 
)

select concat(f_name,' ',l_name) from tbl_employee
where emp_id in (
	select emp_id from login_table
	where username = 'receptionist' and password = 'receptionist123'
)

select a.appointment_id,
    a.date_of_appointment,
    a.time_of_appointment,
    (select concat(p.p_f_name,' ',p.p_l_name) 
     from tbl_patient p 
     where p.patient_id = a.patient_id) AS PatientName,
    (select concat(e.f_name,' ',e.l_name)
     from tbl_employee e 
     where e.emp_id = a.booked_by_emp_id) AS BookedByEmployee,
    (select concat(e.f_name,' ',e.l_name)
     from tbl_employee e 
     where e.emp_id = a.booked_for_emp_id) AS BookedForEmployee
from
    tbl_appointment a
where a.appointment_status = 'Cancelled'

select * from tbl_appointment

select count(appointment_id) as Booked_Appointment from tbl_appointment
where appointment_status = 'Booked' and date_of_appointment = CAST(GETDATE() AS DATE) 

INSERT INTO tbl_appointment (booked_by_emp_id, booked_for_emp_id, date_of_appointment, time_of_appointment, appointment_status,patient_id,appointment_type)
VALUES
(1, 4, '2024-11-30', '14:15:00', 'Cancelled',21,'Online')

insert into tbl_treatment (treatment_type,emp_id,patient_id) values('consultation & treatment',4,13);


SELECT 
    p.*,
    t.treatment_type,
    (SELECT CONCAT(e.f_name, ' ', e.l_name) 
     FROM tbl_employee e 
     WHERE e.emp_id = a.booked_for_emp_id) AS DoctorName,
    a.date_of_appointment,
    b.bill_status,
    b.remaining_payment
FROM 
    tbl_patient p
LEFT JOIN tbl_treatment t ON p.patient_id = t.patient_id
LEFT JOIN tbl_appointment a ON p.patient_id = a.patient_id
LEFT JOIN tbl_billing b ON t.treatment_id = b.treatment_id;

select * from tbl_treatment

INSERT INTO tbl_inventory (item_name, category, quantity, unit_of_measurement, purchase_price, selling_price,expiration_date, date_of_purchase, item_status, batch_no) 
VALUES 
('Syringe', 'Medical Equipment', 100, 'pieces', 50.00, 75.00,'2025-12-01', '2023-12-01', 'Available', 'BATCH001');

ALTER TABLE tbl_treatment_inventory
DROP CONSTRAINT FK_tbl_treatitem__51300E55;

delete from tbl_inventory

SELECT name 
FROM sys.check_constraints 
WHERE parent_object_id = OBJECT_ID('tbl_inventory') 
AND parent_column_id = (
    SELECT column_id 
    FROM sys.columns 
    WHERE object_id = OBJECT_ID('tbl_inventory') 
    AND name = 'item_status'
);


ALTER TABLE tbl_inventory
DROP CONSTRAINT CK_tbl_invenitem__0C50D423

ALTER TABLE tbl_inventory
ADD CONSTRAINT chk_item_status
CHECK (item_status IN ('Available', 'Out of Stock', 'Expired', 'Near Expiry', 'Top Sold'));

 update tbl_inventory 
 set item_status = 
     case 
         when expiration_date <= GETDATE() then 'Expired' 
         when expiration_date > GETDATE() AND expiration_date <= DATEADD(MONTH, 3, GETDATE()) THEN 'Near Expiry'
         else item_status 
    end
 where item_status not in ('Expired', 'Near Expiry')

 create procedure view_appointments_by_doctor
 @doctorName varchar(50)
AS
BEGIN
    SELECT 
        a.appointment_id AS AppointmentID,
        a.date_of_appointment AS AppointmentDate,
        a.time_of_appointment AS AppointmentTime,
        CONCAT(p.p_f_name, ' ', p.p_l_name) AS PatientName,
        CONCAT(be.f_name, ' ', be.l_name) AS BookedByEmployee,
        CONCAT(bfe.f_name, ' ', bfe.l_name) AS BookedForEmployee
    FROM tbl_appointment a
    inner join tbl_patient p ON p.patient_id = a.patient_id
    inner join tbl_employee be ON be.emp_id = a.booked_by_emp_id
    inner join tbl_employee bfe ON bfe.emp_id = a.booked_for_emp_id
        and concat(bfe.f_name, ' ', bfe.l_name) = @doctorName
END

create procedure add_appointment
    @booked_by_name varchar(100),
    @booked_for_name varchar(100),
    @appointment_date date,
    @appointment_time time,
    @appointment_type varchar(50),
    @appointment_status varchar(50),
    @patient_id int
as
begin
    set nocount on;

    declare @booked_by_emp_id int, @booked_for_emp_id int;

    select @booked_by_emp_id = emp_id
    from tbl_employee
    where concat(f_name, ' ', l_name) = @booked_by_name;

    if @booked_by_emp_id is null
    begin
        throw 50001, 'booked by employee not found', 1;
    end

    select @booked_for_emp_id = emp_id
    from tbl_employee
    where concat(f_name, ' ', l_name) = @booked_for_name;

    if @booked_for_emp_id is null
    begin
        throw 50002, 'booked for employee not found', 1;
    end
    insert into tbl_appointment 
    (date_of_appointment, time_of_appointment, booked_by_emp_id, booked_for_emp_id, appointment_type, appointment_status, patient_id)
    values 
    (@appointment_date, @appointment_time, @booked_by_emp_id, @booked_for_emp_id, @appointment_type, @appointment_status, @patient_id);
end;

create procedure get_next_appointment_time
    @doctor_name varchar(100),
    @appointment_date date,
    @next_time time output
as
begin
    set nocount on;
    select top 1 @next_time = dateadd(minute, 15, a.time_of_appointment)
    from tbl_appointment a
    where a.date_of_appointment = @appointment_date
      and a.appointment_status = 'booked'
      and a.booked_for_emp_id = (
          select emp_id 
          from tbl_employee 
          where concat(f_name, ' ', l_name) = @doctor_name
      )
    order by a.time_of_appointment desc;

    if @next_time is null
    begin
        select @next_time = ewh.start_duty
        from tbl_emp_working_hours ewh
        inner join tbl_employee e on e.emp_id = ewh.emp_id
        where concat(e.f_name, ' ', e.l_name) = @doctor_name;
    end
end;


create procedure GetEmployeeDetails
AS
BEGIN
    SELECT 
        e.emp_id, 
        e.designation, 
        e.f_name,  
        e.l_name, 
        d.department, 
        e.father_name, 
        e.date_of_birth, 
        e.date_of_joining, 
        e.street, 
        e.city, 
        e.block,
        e.house_no,
        e.ph_country_code, 
        e.phone_number, 
        e.gender, 
        e.institution, 
        e.cnic,
        wh.emp_status,
        wh.start_duty, 
        wh.end_duty
    FROM tbl_employee e
    INNER JOIN tbl_department d
        ON e.emp_id = d.emp_id
    INNER JOIN tbl_emp_working_hours wh
        ON e.emp_id = wh.emp_id;
END;

create procedure UpdateEmployeeDetails
    @EmployeeId INT,
    @Designation VARCHAR(50),
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Department VARCHAR(50),
    @FatherName VARCHAR(50),
    @DOB DATE,
    @DOJ DATE,
    @Street VARCHAR(100),
    @City VARCHAR(50),
    @Block VARCHAR(50),
    @HouseNo VARCHAR(20),
    @PhoneNumber VARCHAR(20),
    @Gender VARCHAR(10),
    @Institution VARCHAR(100),
    @CNIC VARCHAR(15),
    @Status VARCHAR(50),
    @StartDuty TIME,
    @EndDuty TIME
AS
BEGIN
    BEGIN TRANSACTION;
	BEGIN TRY
        UPDATE tbl_employee
        SET 
            designation = @Designation,
            f_name = @FirstName,
            l_name = @LastName,
            father_name = @FatherName,
            date_of_birth = @DOB,
            date_of_joining = @DOJ,
            street = @Street,
            city = @City,
            block = @Block,
            house_no = @HouseNo,
            phone_number = @PhoneNumber,
            gender = @Gender,
            institution = @Institution,
            cnic = @CNIC
        WHERE emp_id = @EmployeeId;

        UPDATE tbl_department
        SET department = @Department
        WHERE emp_id = @EmployeeId;

        UPDATE tbl_emp_working_hours
        SET 
            emp_status = @Status,
            start_duty = @StartDuty,
            end_duty = @EndDuty
        WHERE emp_id = @EmployeeId;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;

CREATE PROCEDURE insert_prescription_and_billing
    @appointment_id INT,
    @follow_up_date DATE,
    @doctor_name VARCHAR(100),
    @booked_by_name VARCHAR(100),
    @doctor_fee DECIMAL(10, 2),
    @bill_id INT OUTPUT 
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO tbl_prescription (appointment_id, follow_up_date, followUpDoctorName, bookedByName)
        VALUES (@appointment_id, @follow_up_date, @doctor_name, @booked_by_name);

        INSERT INTO tbl_billing (appointment_id, emp_fee)
        VALUES (@appointment_id, @doctor_fee);

        SELECT @bill_id = SCOPE_IDENTITY();

        UPDATE tbl_appointment
        SET appointment_status = 'Attended'
        WHERE appointment_id = @appointment_id;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        THROW;
    END CATCH
END;




create procedure get_or_create_item
    @item_name VARCHAR(255),
    @item_id INT OUTPUT
AS
BEGIN
    SELECT @item_id = item_id
    FROM tbl_item
    WHERE item_name = @item_name;

    IF @item_id IS NULL
    BEGIN
        INSERT INTO tbl_item (item_name)
        VALUES (@item_name);

        SET @item_id = SCOPE_IDENTITY();
    END
END;

CREATE TRIGGER trg_book_followup_appointment
ON tbl_prescription
AFTER INSERT
AS
BEGIN
    DECLARE 
        @follow_up_date DATE, 
        @appointment_id INT,
        @patient_id INT,
        @doctor_name VARCHAR(100),
        @booked_by_name VARCHAR(100),
        @doctor_id INT,
        @appointment_time TIME,
        @appointment_status VARCHAR(50) = 'Booked';

    SELECT 
        @follow_up_date = follow_up_date,
        @appointment_id = appointment_id,
        @doctor_name = followUpDoctorName,
        @booked_by_name = bookedByName
    FROM inserted;


    IF @follow_up_date IS NULL
        RETURN;

    SELECT 
        @patient_id = patient_id
    FROM tbl_appointment
    WHERE appointment_id = @appointment_id;

    SELECT 
        @doctor_id = emp_id
    FROM tbl_employee
    WHERE CONCAT(f_name, ' ', l_name) = @doctor_name;

    EXEC get_next_appointment_time 
        @doctor_name = @doctor_name, 
        @appointment_date = @follow_up_date, 
        @next_time = @appointment_time OUTPUT;

    EXEC add_appointment
        @booked_by_name = @booked_by_name,
        @booked_for_name = @doctor_name,
        @appointment_date = @follow_up_date,
        @appointment_time = @appointment_time,
        @appointment_type = 'Follow-Up',
        @appointment_status = @appointment_status,
        @patient_id = @patient_id;
END;




create view vw_prescription_details AS
SELECT
    p.prescription_id,
    concat(pt.p_f_name,pt.p_l_name) AS patient_name,
    CONCAT(d.f_name, ' ', d.l_name) AS doctor_name,
    a.date_of_appointment,
    p.follow_up_date,
    i.item_name,
    pi.item_type,
    b.bill_id,
    b.emp_fee
FROM
    tbl_prescription p
JOIN
    tbl_appointment a ON p.appointment_id = a.appointment_id
JOIN
    tbl_patient pt ON a.patient_id = pt.patient_id
JOIN
    tbl_employee d ON a.booked_for_emp_id = d.emp_id
JOIN
    tbl_prescription_item pi ON p.prescription_id = pi.prescription_id
JOIN
    tbl_item i ON pi.item_id = i.item_id
LEFT JOIN
    tbl_billing b ON a.appointment_id = b.appointment_id;




select * from tbl_billing

select * from tbl_appointment

select * from tbl_prescription

select * from login_table