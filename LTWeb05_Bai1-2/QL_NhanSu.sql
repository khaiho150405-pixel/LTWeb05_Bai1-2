CREATE DATABASE QL_NhanSu

CREATE TABLE tbl_Department
(
DeptId CHAR(10) PRIMARY KEY,
Ten NVARCHAR(50)
)

CREATE TABLE tbl_Employee
(
Id CHAR(10) PRIMARY KEY,
Tennv NVARCHAR(50),
Gender NVARCHAR(10),
City NVARCHAR(50),
DeptId CHAR(10) REFERENCES tbl_Department(DeptId)
)

INSERT INTO tbl_Department VALUES
('1',N'Khoa CNTT'),
('2',N'Khoa Ngoại Ngữ'),
('3',N'Khoa tài chính'),
('4',N'Khoa Thực Phẩm'),
('5',N'Phòng đào tạo');

insert into tbl_Employee values
('1',N'Nguyễn Hải Yến',N'Nữ',N'Đà Lạt','1'),
('2',N'Trương Mạnh Hùng','Nam','TP.HCM','1'),
('3',N'Đinh Duy Minh','Nam',N'Thái Bình','2'),
('4',N'Ngô Thị Nguyệt',N'Nữ','Long An','2'),
('5',N'Đào Minh Châu',N'Nữ',N'Bạc Liêu','3'),
('14',N'Phan Thị Ngọc Mai',N'Nữ',N'Bến Tre','3'),
('15',N'Trương Nguyễn Quỳnh Anh',N'Nữ','TP.HCM','4'),
('16',N'Lê Thanh Liêm','Nam','TP.HCM','4');
