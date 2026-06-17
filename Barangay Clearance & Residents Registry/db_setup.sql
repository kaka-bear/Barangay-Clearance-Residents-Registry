-- Create Residents Table
CREATE TABLE Residents (
    ResidentID AUTOINCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Sex VARCHAR(10) NOT NULL,
    BirthDate DATETIME NOT NULL,
    Address VARCHAR(255) NOT NULL,
    ContactNumber VARCHAR(20),
    CivilStatus VARCHAR(20),
    CreatedAt DATETIME DEFAULT NOW(),
    UpdatedAt DATETIME DEFAULT NOW()
)
-- GO

-- Create ClearanceTypes Table
CREATE TABLE ClearanceTypes (
    ClearanceTypeID AUTOINCREMENT PRIMARY KEY,
    TypeName VARCHAR(50) NOT NULL,
    DefaultFee DECIMAL(18,2) DEFAULT 0.00,
    CreatedAt DATETIME DEFAULT NOW(),
    UpdatedAt DATETIME DEFAULT NOW()
)
-- GO

-- Create Clearances Table
CREATE TABLE Clearances (
    ClearanceID AUTOINCREMENT PRIMARY KEY,
    ResidentID INTEGER NOT NULL,
    ClearanceTypeID INTEGER NOT NULL,
    Purpose VARCHAR(255),
    ORNo VARCHAR(50) NOT NULL,
    IssueDate DATETIME NOT NULL,
    Fee DECIMAL(18,2) NOT NULL,
    Status VARCHAR(20) DEFAULT 'Issued',
    CreatedAt DATETIME DEFAULT NOW(),
    UpdatedAt DATETIME DEFAULT NOW(),
    FOREIGN KEY (ResidentID) REFERENCES Residents(ResidentID),
    FOREIGN KEY (ClearanceTypeID) REFERENCES ClearanceTypes(ClearanceTypeID)
)
-- GO

-- Create Payments Table
CREATE TABLE Payments (
    PaymentID AUTOINCREMENT PRIMARY KEY,
    ORNo VARCHAR(50) NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    PayDate DATETIME NOT NULL,
    PaymentMethod VARCHAR(20) DEFAULT 'Cash',
    CreatedAt DATETIME DEFAULT NOW(),
    UpdatedAt DATETIME DEFAULT NOW()
)
-- GO

-- Insert 20 Residents
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Juan Dela Cruz', 'Male', #1990-05-15#, '123 Rizal St, Zone 1', '09171234567', 'Married', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Maria Clara Santos', 'Female', #1993-10-22#, '456 Mabini St, Zone 2', '09187654321', 'Single', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Jose Rizal Mercado', 'Male', #1985-06-19#, '789 Bonifacio St, Zone 3', '09192223333', 'Single', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Andres Bonifacio', 'Male', #1988-11-30#, '101 Katipunan St, Zone 1', '09204445555', 'Married', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Gabriela Silang', 'Female', #1991-03-19#, '202 Diego Silang Rd, Zone 4', '09213334444', 'Widowed', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Melchora Aquino', 'Female', #1975-01-06#, '303 Tandang Sora St, Zone 5', '09225556666', 'Widowed', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Emilio Aguinaldo', 'Male', #1980-03-22#, '404 Kawit St, Zone 2', '09236667777', 'Married', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Apolinario Mabini', 'Male', #1982-07-23#, '505 Sublime Paralytic St, Zone 3', '09247778888', 'Single', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Marcelo H. Del Pilar', 'Male', #1987-08-30#, '606 Plaridel St, Zone 1', '09258889999', 'Married', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Juan Luna', 'Male', #1989-10-23#, '707 Spoliarium Ave, Zone 4', '09269990000', 'Single', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Antonio Luna', 'Male', #1992-10-29#, '808 Heneral St, Zone 4', '09301112222', 'Single', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Leonor Rivera', 'Female', #1994-04-11#, '909 Dagupan St, Zone 3', '09312223333', 'Single', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Emilio Jacinto', 'Male', #1995-12-15#, '111 Pingkian St, Zone 1', '09323334444', 'Single', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Gregoria De Jesus', 'Female', #1996-05-09#, '222 Lakambini St, Zone 2', '09334445555', 'Married', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Macario Sakay', 'Male', #1984-03-01#, '333 Hanger St, Zone 5', '09345556666', 'Single', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Teresa Magbanua', 'Female', #1978-10-13#, '444 Nayisa St, Zone 5', '09356667777', 'Married', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Gliceria Marella', 'Female', #1981-05-13#, '555 Taal St, Zone 2', '09367778888', 'Widowed', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Felipe Agoncillo', 'Male', #1983-05-26#, '666 Diplomat St, Zone 3', '09378889999', 'Married', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Galicano Apacible', 'Male', #1986-06-25#, '777 Batangas St, Zone 4', '09389990000', 'Married', NOW(), NOW())
-- GO
INSERT INTO Residents (FullName, Sex, BirthDate, Address, ContactNumber, CivilStatus, CreatedAt, UpdatedAt) VALUES ('Mariano Ponce', 'Male', #1985-03-22#, '888 Kalayaan Rd, Zone 1', '09391112222', 'Single', NOW(), NOW())
-- GO

-- Insert 20 Clearance Types
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - Local Employment', 150.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - Overseas Employment', 200.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Certificate of Indigency - Scholarship', 0.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Certificate of Indigency - Medical Aid', 0.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Certificate of Residency', 100.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - Business Permit', 500.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - Postal ID', 100.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - Bank Transaction', 150.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Certificate of Good Moral Character', 120.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - Travel Purposes', 250.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - Police Clearance Req', 100.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - NBI Clearance Req', 100.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Certificate of Solo Parent', 150.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Certificate of Cohabitation', 200.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - Tricycle Franchise', 150.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - Driver License Req', 100.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Certificate of No Income', 100.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Certificate of Destruction/Damage', 150.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - Electric Connection', 100.00, NOW(), NOW())
-- GO
INSERT INTO ClearanceTypes (TypeName, DefaultFee, CreatedAt, UpdatedAt) VALUES ('Barangay Clearance - Water Connection', 100.00, NOW(), NOW())
-- GO

-- Insert 30 Clearances and Payments
INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (1, 1, 'Local Job Application', 'OR-10001', #2026-06-01#, 150.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10001', 150.00, #2026-06-01#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (2, 5, 'Identification Requirement', 'OR-10002', #2026-06-01#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10002', 100.00, #2026-06-01#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (3, 3, 'Scholarship Application', 'OR-10003', #2026-06-02#, 0.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10003', 0.00, #2026-06-02#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (4, 6, 'Store Permit Renewal', 'OR-10004', #2026-06-02#, 500.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10004', 500.00, #2026-06-02#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (5, 9, 'School Requirement', 'OR-10005', #2026-06-03#, 120.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10005', 120.00, #2026-06-03#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (6, 4, 'Hospital Bill Discount', 'OR-10006', #2026-06-03#, 0.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10006', 0.00, #2026-06-03#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (7, 2, 'Work Abroad', 'OR-10007', #2026-06-04#, 200.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10007', 200.00, #2026-06-04#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (8, 7, 'Postal ID application', 'OR-10008', #2026-06-04#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10008', 100.00, #2026-06-04#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (9, 8, 'Bank Account Opening', 'OR-10009', #2026-06-05#, 150.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10009', 150.00, #2026-06-05#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (10, 10, 'Out of Country Travel', 'OR-10010', #2026-06-05#, 250.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10010', 250.00, #2026-06-05#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (11, 11, 'Police Clearance', 'OR-10011', #2026-06-06#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10011', 100.00, #2026-06-06#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (12, 12, 'NBI Requirement', 'OR-10012', #2026-06-06#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10012', 100.00, #2026-06-06#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (13, 13, 'Solo Parent Allowance', 'OR-10013', #2026-06-07#, 150.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10013', 150.00, #2026-06-07#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (14, 15, 'Tricycle Franchise Renewal', 'OR-10014', #2026-06-07#, 150.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10014', 150.00, #2026-06-07#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (15, 16, 'LTO Driver License Renewal', 'OR-10015', #2026-06-08#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10015', 100.00, #2026-06-08#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (16, 17, 'Scholarship No Income Certificate', 'OR-10016', #2026-06-08#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10016', 100.00, #2026-06-08#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (17, 19, 'Meralco Electric Connection', 'OR-10017', #2026-06-09#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10017', 100.00, #2026-06-09#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (18, 20, 'Maynilad Water Connection', 'OR-10018', #2026-06-09#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10018', 100.00, #2026-06-09#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (19, 1, 'Job Application', 'OR-10019', #2026-06-10#, 150.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10019', 150.00, #2026-06-10#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (20, 5, 'ID requirement', 'OR-10020', #2026-06-10#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10020', 100.00, #2026-06-10#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (1, 8, 'Loan Requirement', 'OR-10021', #2026-06-11#, 150.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10021', 150.00, #2026-06-11#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (2, 11, 'Police Clearance Req', 'OR-10022', #2026-06-11#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10022', 100.00, #2026-06-11#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (3, 12, 'NBI Clearance Req', 'OR-10023', #2026-06-12#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10023', 100.00, #2026-06-12#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (4, 18, 'Insurance Claim', 'OR-10024', #2026-06-12#, 150.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10024', 150.00, #2026-06-12#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (5, 5, 'Residency Certificate', 'OR-10025', #2026-06-13#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10025', 100.00, #2026-06-13#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (6, 1, 'Part time job', 'OR-10026', #2026-06-13#, 150.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10026', 150.00, #2026-06-13#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (7, 3, 'Scholarship application', 'OR-10027', #2026-06-14#, 0.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10027', 0.00, #2026-06-14#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (8, 6, 'Sari-Sari Store Permit', 'OR-10028', #2026-06-14#, 500.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10028', 500.00, #2026-06-14#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (9, 2, 'OFW Application', 'OR-10029', #2026-06-15#, 200.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10029', 200.00, #2026-06-15#, 'Cash', NOW(), NOW())
-- GO

INSERT INTO Clearances (ResidentID, ClearanceTypeID, Purpose, ORNo, IssueDate, Fee, Status, CreatedAt, UpdatedAt) VALUES (10, 7, 'Postal ID req', 'OR-10030', #2026-06-15#, 100.00, 'Issued', NOW(), NOW())
-- GO
INSERT INTO Payments (ORNo, Amount, PayDate, PaymentMethod, CreatedAt, UpdatedAt) VALUES ('OR-10030', 100.00, #2026-06-15#, 'Cash', NOW(), NOW())
-- GO
