create database clinic_management_db

--Structure

CREATE TABLE login_table (
	emp_id INT PRIMARY KEY,
	FOREIGN KEY (emp_id) REFERENCES tbl_employee(emp_id),
	username VARCHAR(50) UNIQUE,
	password VARCHAR(50)
);

CREATE TABLE tbl_employee (
	emp_id INT IDENTITY(1,1) PRIMARY KEY,
	designation VARCHAR(50),
	f_name VARCHAR(50),
	l_name VARCHAR(50),
	father_name VARCHAR(50),
	date_of_birth DATE,
	date_of_joining DATE,
	street INT,
	city VARCHAR(50) NOT NULL,
	block VARCHAR(1),
	house_no INT,
	ph_country_code VARCHAR(10),
	phone_number VARCHAR(20) CHECK (LEN(phone_number) = 10),
	gender VARCHAR(10) CHECK (gender IN ('Male', 'Female', 'Other')),
	institution VARCHAR(50),
	cnic VARCHAR(15) UNIQUE
);

CREATE TABLE tbl_department (
	emp_id INT,
	department VARCHAR(50) NOT NULL,
	FOREIGN KEY (emp_id) REFERENCES tbl_employee(emp_id)
);

CREATE TABLE tbl_patient (
	patient_id INT IDENTITY(1,1) PRIMARY KEY,
	p_f_name VARCHAR(20) NOT NULL,
	p_l_name VARCHAR(20) NOT NULL,
	father_name VARCHAR(30),
	date_of_birth DATE,
	street INT,
	block VARCHAR(1),
	city VARCHAR(50),
	country VARCHAR(50),
	ph_country_code VARCHAR(10),
	phone_number VARCHAR(20) CHECK (LEN(phone_number) = 10),
	gender VARCHAR(10) NOT NULL,
	age INT,
	cnic VARCHAR(15) UNIQUE
);

CREATE TABLE tbl_specialization (
	specialization_id INT IDENTITY(1,1) PRIMARY KEY, --unique key
	specialization VARCHAR(20)   --i.e general physician 
);

CREATE TABLE tbl_emp_specialization (   --linking emp w specializaton (many to many has been broken)
	employee_id INT,
	specialization_id INT,
	institute VARCHAR(30),
	FOREIGN KEY (employee_id) REFERENCES tbl_employee(emp_id),
	FOREIGN KEY (specialization_id) REFERENCES tbl_specialization(specialization_id),
	PRIMARY KEY (employee_id, specialization_id)
);

CREATE TABLE tbl_appointment (
	appointment_id INT IDENTITY(1,1) PRIMARY KEY,
	booked_by_emp_id INT,
	booked_for_emp_id INT,
	patient_id INT,
	date_of_appointment DATE NOT NULL,
	time_of_appointment TIME NOT NULL,
	appointment_status VARCHAR(20) NOT NULL,
	appointment_type VARCHAR(50),
	FOREIGN KEY (booked_by_emp_id) REFERENCES tbl_employee(emp_id) ON DELETE CASCADE,   
	FOREIGN KEY (booked_for_emp_id) REFERENCES tbl_employee(emp_id),
	FOREIGN KEY (patient_id) REFERENCES tbl_patient(patient_id) ON DELETE CASCADE
);

CREATE TABLE tbl_treatment (
	treatment_id INT IDENTITY(1,1) PRIMARY KEY,
	treatment_type VARCHAR(20),
	emp_id INT,
	patient_id INT,
	FOREIGN KEY (emp_id) REFERENCES tbl_employee(emp_id),
	FOREIGN KEY (patient_id) REFERENCES tbl_patient(patient_id)
);

CREATE TABLE tbl_billing (
	bill_id INT IDENTITY(1,1) PRIMARY KEY,
	emp_fee INT DEFAULT 1000 CHECK (emp_fee >= 0),  --default kept to 1000, checking if entered 0 
	appointment_id INT NOT NULL,
	FOREIGN KEY (appointment_id) REFERENCES tbl_appointment(appointment_id)  --will be billed acc to appointment id 
);

CREATE TABLE tbl_prescription (
	prescription_id INT IDENTITY(1,1) PRIMARY KEY,
	appointment_id INT NOT NULL,
	follow_up_date DATE,
	followUpDoctorName VARCHAR(100),
	bookedByName VARCHAR(100),
	created_at DATETIME NOT NULL DEFAULT GETDATE(),
	FOREIGN KEY (appointment_id) REFERENCES tbl_appointment(appointment_id)  --gets emp id and patient id in the process too 
);

CREATE TABLE tbl_item (
	item_id INT IDENTITY(1,1) PRIMARY KEY,
	item_name VARCHAR(255) NOT NULL
);

CREATE TABLE tbl_prescription_item (
	prescription_item_id INT IDENTITY(1,1) PRIMARY KEY,
	prescription_id INT NOT NULL,
	item_id INT NOT NULL,
	item_type VARCHAR(50) NOT NULL,
	FOREIGN KEY (prescription_id) REFERENCES tbl_prescription(prescription_id),
	FOREIGN KEY (item_id) REFERENCES tbl_item(item_id)
);

CREATE TABLE tbl_emp_working_hours (
	emp_id INT,
	FOREIGN KEY (emp_id) REFERENCES tbl_employee(emp_id),
	start_duty TIME NOT NULL CHECK (start_duty < end_duty),  --start duty should be less than end check
	end_duty TIME NOT NULL,
	emp_status VARCHAR(20) DEFAULT 'Available'  --default is always available unless set otherwise 
);

CREATE TABLE tbl_emp_shift (
	emp_id INT,
	FOREIGN KEY (emp_id) REFERENCES tbl_employee(emp_id),   
	start_time TIME NOT NULL,
	end_time TIME NOT NULL,
	date_of_shift DATE NOT NULL
);

CREATE TABLE tbl_appointment_log (
	log_id INT IDENTITY(1,1) PRIMARY KEY,
	appointment_id INT NOT NULL,
	patient_name VARCHAR(255) NOT NULL,
	doctor_name VARCHAR(255) NOT NULL,
	booked_by VARCHAR(255) NOT NULL,
	action_type VARCHAR(50) NOT NULL,
	column_updated VARCHAR(100),
	previous_value VARCHAR(255),
	new_value VARCHAR(255),
	log_date DATETIME NOT NULL,
	username VARCHAR(50),
	password VARCHAR(50),
	FOREIGN KEY (appointment_id) REFERENCES tbl_appointment(appointment_id)
);


create nonclustered index idx_patient_name_phone
on tbl_patient (p_f_name, p_l_name, phone_number);

create nonclustered index ix_tbl_employee_f_name_l_name
on tbl_employee (f_name, l_name);

create clustered index ix_tbl_emp_working_hours_emp_status
on tbl_emp_working_hours (emp_status);

create nonclustered index ix_tbl_appointment_appointment_status
on tbl_appointment (appointment_status);

create nonclustered index ix_tbl_billing_appointment_id
ON tbl_billing (appointment_id);

create nonclustered index ix_tbl_appointment_date_of_appointment
ON tbl_appointment (date_of_appointment);

create nonclustered index ix_tbl_billing_emp_fee
ON tbl_billing (emp_fee);

--Queries

select concat(f_name,' ', l_name) from tbl_employee
where designation = 'Doctor' 
  and emp_id IN (
      select emp_id from tbl_emp_working_hours 
      where emp_status = 'Available'
  ); --here the name of the doctors are fetched from the "employees" that are available hence
  --filter for the available doctors 


select * from tbl_patient p
where p.patient_id in (
	select patient_id from tbl_appointment a
	where a.date_of_appointment = CAST(GETDATE() AS DATE) 
)  --getting all appointments for the current date 
--here the patients whose apt date is the sasme as current dates, their information is fetched 

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
--getting all records for the cancelled appointments 
--apt id,date, time, patients name, doctors name, booked by employees name.

select count(appointment_id) as Booked_Appointment from tbl_appointment
where appointment_status = 'Booked' and date_of_appointment = CAST(GETDATE() AS DATE) 
-- this gets the current booked appointments for the CURRENT date and counts their number 
--say , today 7 booked appointments in front end 

 create procedure view_appointments_by_doctor
 @doctorName varchar(50)  --procedure receives the doctor 
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

CREATE PROCEDURE add_prescription_item
    @item_name VARCHAR(255),
    @item_type VARCHAR(50),
    @prescription_id INT
AS
BEGIN
    DECLARE @item_id INT;

    BEGIN TRY
        BEGIN TRANSACTION;

        EXEC get_or_create_item @item_name = @item_name, @item_id = @item_id OUTPUT;

        INSERT INTO tbl_prescription_item (prescription_id, item_id, item_type)
        VALUES (@prescription_id, @item_id, @item_type);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        -- Throw the error
        THROW;
    END CATCH
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
	p.followUpDoctorName,
    b.bill_id,
    b.emp_fee
FROM
    tbl_prescription p
Inner JOIN
    tbl_appointment a ON p.appointment_id = a.appointment_id
Inner JOIN
    tbl_patient pt ON a.patient_id = pt.patient_id
Inner JOIN
    tbl_employee d ON a.booked_for_emp_id = d.emp_id
LEFT JOIN
    tbl_billing b ON a.appointment_id = b.appointment_id;


CREATE PROCEDURE sp_get_prescription_summary
    @bill_id INT
AS
BEGIN
    SELECT
		p.prescription_id,
        CONCAT(pt.p_f_name, ' ', pt.p_l_name) AS patient_name,
        CONCAT(d.f_name, ' ', d.l_name) AS doctor_name,
        b.emp_fee AS doctor_fee
    FROM
        tbl_prescription p
    JOIN
        tbl_appointment a ON p.appointment_id = a.appointment_id
    JOIN
        tbl_patient pt ON a.patient_id = pt.patient_id
    JOIN
        tbl_employee d ON a.booked_for_emp_id = d.emp_id
    LEFT JOIN
        tbl_billing b ON a.appointment_id = b.appointment_id
    WHERE
        b.bill_id = @bill_id; 
END;




CREATE PROCEDURE CountPatientsByDateRange  --run
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT 
        CAST(a.date_of_appointment AS DATE) AS AppointmentDate,
        COUNT(a.patient_id) AS PatientCount
    FROM tbl_appointment a
    WHERE a.date_of_appointment BETWEEN @StartDate AND @EndDate
    GROUP BY CAST(a.date_of_appointment AS DATE)
    ORDER BY AppointmentDate;
END;

select * from tbl_appointment

CREATE PROCEDURE CountAppointmentsByDoctor  --run
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT 
        CONCAT(e.f_name, ' ', e.l_name) AS DoctorName,
        COUNT(a.appointment_id) AS AppointmentCount
    FROM tbl_appointment a
    INNER JOIN tbl_employee e
        ON a.booked_for_emp_id = e.emp_id
    WHERE a.date_of_appointment BETWEEN @StartDate AND @EndDate
    GROUP BY e.f_name, e.l_name
    ORDER BY AppointmentCount DESC;
END;

CREATE PROCEDURE CalculateDoctorRevenue  --run
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT 
        CONCAT(e.f_name, ' ', e.l_name) AS DoctorName,
        SUM(b.emp_fee) AS TotalRevenue
    FROM tbl_billing b
    INNER JOIN tbl_appointment a ON b.appointment_id = a.appointment_id
    INNER JOIN tbl_employee e ON a.booked_for_emp_id = e.emp_id
    WHERE a.date_of_appointment BETWEEN @StartDate AND @EndDate
    GROUP BY e.f_name, e.l_name
    ORDER BY TotalRevenue DESC;
END;



CREATE PROCEDURE sp_calculate_hospital_revenue   --run
    @StartDate DATE,
    @Duration VARCHAR(10),
	@profitpercent decimal(10,2) = 30.00
AS
BEGIN
    -- Temporary table to store daily revenues
    CREATE TABLE #DailyRevenue (
        RevenueDate DATE,
        RevenueAmount DECIMAL(18, 2)
    );

    DECLARE @EndDate DATE;

    -- Determine the end date based on the duration
    IF @Duration = 'weekly'
    BEGIN
        SET @EndDate = @StartDate;
        SET @StartDate = DATEADD(DAY, -6, @EndDate); -- Get the start date of the last week
    END
    ELSE IF @Duration = 'monthly'
    BEGIN
        SET @EndDate = @StartDate;
        SET @StartDate = DATEADD(MONTH, -1, @StartDate); -- Get the start date of the last month
    END

    -- Loop through each day in the range
    WHILE @StartDate <= @EndDate
    BEGIN


        DECLARE @DailyRevenue DECIMAL(18, 2);

        -- Calculate total revenue for the day by joining tbl_billing and tbl_appointment on appointment_id
        SELECT @DailyRevenue = SUM((b.emp_fee * @profitpercent) / 100)
        FROM tbl_billing b
        INNER JOIN tbl_appointment a ON b.appointment_id = a.appointment_id
        WHERE CAST(a.date_of_appointment AS DATE) = @StartDate;

        -- Handle NULL values (if no revenue, set it to 0)
        SET @DailyRevenue = ISNULL(@DailyRevenue, 0);

        -- Insert the calculated revenue into the temporary table
        INSERT INTO #DailyRevenue (RevenueDate, RevenueAmount)
        VALUES (@StartDate, @DailyRevenue);

        -- Increment the date
        SET @StartDate = DATEADD(DAY, 1, @StartDate);
    END;

    -- Return the result
    SELECT * FROM #DailyRevenue;

    -- Cleanup
    DROP TABLE #DailyRevenue;
END;

EXEC sp_calculate_hospital_revenue '2024-12-12', 'monthly',40.00;


create procedure sp_CalculateBillDetails
    @ProfitPercent DECIMAL(10, 2) = 30.00
AS
BEGIN
    -- Calculate and display the bill details
    SELECT 
        b.bill_id AS BillID,
        CONCAT(p.p_f_name, ' ', p.p_l_name) AS PatientName,
        CONCAT(e.f_name, ' ', e.l_name) AS DoctorName,
        a.date_of_appointment AS AppointmentDate,
        b.emp_fee AS DoctorFee,
        ROUND((b.emp_fee * @ProfitPercent) / 100, 2) AS HospitalProfit
    FROM tbl_billing b
    INNER JOIN tbl_appointment a ON b.appointment_id = a.appointment_id
    INNER JOIN tbl_employee e ON a.booked_for_emp_id = e.emp_id
    INNER JOIN tbl_patient p ON a.booked_by_emp_id = p.patient_id;
END

Exec sp_CalculateBillDetails


CREATE PROCEDURE sp_GetFilteredAppointments
    @FilterOption NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF @FilterOption = 'Upcoming Week'
    BEGIN
        SELECT 
            a.appointment_id,
            a.date_of_appointment,
            a.time_of_appointment,
            CONCAT(p.p_f_name, ' ', p.p_l_name) AS PatientName,
            CONCAT(b.f_name, ' ', b.l_name) AS BookedByEmployee,
            CONCAT(f.f_name, ' ', f.l_name) AS BookedForEmployee
        FROM tbl_appointment a
        LEFT JOIN tbl_patient p ON a.patient_id = p.patient_id
        LEFT JOIN tbl_employee b ON a.booked_by_emp_id = b.emp_id
        LEFT JOIN tbl_employee f ON a.booked_for_emp_id = f.emp_id
        WHERE a.date_of_appointment >= GETDATE()
          AND a.date_of_appointment < DATEADD(DAY, 7, GETDATE());
    END
    ELSE IF @FilterOption = 'Upcoming Month'
    BEGIN
        SELECT 
            a.appointment_id,
            a.date_of_appointment,
            a.time_of_appointment,
            CONCAT(p.p_f_name, ' ', p.p_l_name) AS PatientName,
            CONCAT(b.f_name, ' ', b.l_name) AS BookedByEmployee,
            CONCAT(f.f_name, ' ', f.l_name) AS BookedForEmployee
        FROM tbl_appointment a
        LEFT JOIN tbl_patient p ON a.patient_id = p.patient_id
        LEFT JOIN tbl_employee b ON a.booked_by_emp_id = b.emp_id
        LEFT JOIN tbl_employee f ON a.booked_for_emp_id = f.emp_id
        WHERE a.date_of_appointment >= GETDATE()
          AND a.date_of_appointment < DATEADD(MONTH, 1, GETDATE());
    END
    ELSE IF @FilterOption = 'Cancelled'
    BEGIN
        SELECT 
            a.appointment_id,
            a.date_of_appointment,
            a.time_of_appointment,
            CONCAT(p.p_f_name, ' ', p.p_l_name) AS PatientName,
            CONCAT(b.f_name, ' ', b.l_name) AS BookedByEmployee,
            CONCAT(f.f_name, ' ', f.l_name) AS BookedForEmployee
        FROM tbl_appointment a
        LEFT JOIN tbl_patient p ON a.patient_id = p.patient_id
        LEFT JOIN tbl_employee b ON a.booked_by_emp_id = b.emp_id
        LEFT JOIN tbl_employee f ON a.booked_for_emp_id = f.emp_id
        WHERE a.appointment_status = 'Cancelled';
    END
    ELSE IF @FilterOption = 'All'
    BEGIN
        SELECT 
            a.appointment_id,
            a.date_of_appointment,
            a.time_of_appointment,
            CONCAT(p.p_f_name, ' ', p.p_l_name) AS PatientName,
            CONCAT(b.f_name, ' ', b.l_name) AS BookedByEmployee,
            CONCAT(f.f_name, ' ', f.l_name) AS BookedForEmployee
        FROM tbl_appointment a
        LEFT JOIN tbl_patient p ON a.patient_id = p.patient_id
        LEFT JOIN tbl_employee b ON a.booked_by_emp_id = b.emp_id
        LEFT JOIN tbl_employee f ON a.booked_for_emp_id = f.emp_id;
    END
    ELSE
    BEGIN
        RAISERROR('Invalid filter option.', 16, 1);
    END
END;


CREATE TRIGGER trg_AppointmentLog
ON tbl_appointment
AFTER INSERT, UPDATE
AS
BEGIN
    -- Log Insertions
    INSERT INTO tbl_appointment_log (
        appointment_id, patient_name, doctor_name, booked_by, 
        action_type, column_updated, previous_value, new_value, log_date
    )
    SELECT 
        i.appointment_id, 
        p.p_f_name + ' ' + p.p_l_name AS patient_name, 
        e.f_name + ' ' + e.l_name AS doctor_name, 
        b.f_name + ' ' + b.l_name AS booked_by, 
        'INSERT' AS action_type, 
        NULL AS column_updated, 
        NULL AS previous_value, 
        NULL AS new_value, 
        GETDATE() AS log_date
    FROM inserted i
    INNER JOIN tbl_employee e ON i.booked_for_emp_id = e.emp_id
    INNER JOIN tbl_patient p ON i.booked_by_emp_id = p.patient_id
    LEFT JOIN tbl_employee b ON i.booked_by_emp_id = b.emp_id;

    -- Log Updates for Date of Appointment
    INSERT INTO tbl_appointment_log (
        appointment_id, patient_name, doctor_name, booked_by, 
        action_type, column_updated, previous_value, new_value, log_date
    )
    SELECT 
        i.appointment_id, 
        p.p_f_name + ' ' + p.p_l_name AS patient_name, 
        e.f_name + ' ' + e.l_name AS doctor_name, 
        b.f_name + ' ' + b.l_name AS booked_by, 
        'UPDATE' AS action_type, 
        'date_of_appointment' AS column_updated, 
        CAST(d.date_of_appointment AS VARCHAR) AS previous_value, 
        CAST(i.date_of_appointment AS VARCHAR) AS new_value, 
        GETDATE() AS log_date
    FROM inserted i
    INNER JOIN deleted d ON i.appointment_id = d.appointment_id
    INNER JOIN tbl_employee e ON i.booked_for_emp_id = e.emp_id
    INNER JOIN tbl_patient p ON i.booked_by_emp_id = p.patient_id
    LEFT JOIN tbl_employee b ON i.booked_by_emp_id = b.emp_id
    WHERE d.date_of_appointment <> i.date_of_appointment;

    -- Log Updates for Time of Appointment
    INSERT INTO tbl_appointment_log (
        appointment_id, patient_name, doctor_name, booked_by, 
        action_type, column_updated, previous_value, new_value, log_date
    )
    SELECT 
        i.appointment_id, 
        p.p_f_name + ' ' + p.p_l_name AS patient_name, 
        e.f_name + ' ' + e.l_name AS doctor_name, 
        b.f_name + ' ' + b.l_name AS booked_by, 
        'UPDATE' AS action_type, 
        'time_of_appointment' AS column_updated, 
        CAST(d.time_of_appointment AS VARCHAR) AS previous_value, 
        CAST(i.time_of_appointment AS VARCHAR) AS new_value, 
        GETDATE() AS log_date
    FROM inserted i
    INNER JOIN deleted d ON i.appointment_id = d.appointment_id
    INNER JOIN tbl_employee e ON i.booked_for_emp_id = e.emp_id
    INNER JOIN tbl_patient p ON i.booked_by_emp_id = p.patient_id
    LEFT JOIN tbl_employee b ON i.booked_by_emp_id = b.emp_id
    WHERE d.time_of_appointment <> i.time_of_appointment;

    -- Log Updates for Appointment Status
    INSERT INTO tbl_appointment_log (
        appointment_id, patient_name, doctor_name, booked_by, 
        action_type, column_updated, previous_value, new_value, log_date
    )
    SELECT 
        i.appointment_id, 
        p.p_f_name + ' ' + p.p_l_name AS patient_name, 
        e.f_name + ' ' + e.l_name AS doctor_name, 
        b.f_name + ' ' + b.l_name AS booked_by, 
        'UPDATE' AS action_type, 
        'appointment_status' AS column_updated, 
        d.appointment_status AS previous_value, 
        i.appointment_status AS new_value, 
        GETDATE() AS log_date
    FROM inserted i
    INNER JOIN deleted d ON i.appointment_id = d.appointment_id
    INNER JOIN tbl_employee e ON i.booked_for_emp_id = e.emp_id
    INNER JOIN tbl_patient p ON i.booked_by_emp_id = p.patient_id
    LEFT JOIN tbl_employee b ON i.booked_by_emp_id = b.emp_id
    WHERE d.appointment_status <> i.appointment_status;
END;

