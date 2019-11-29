CREATE TABLE [Interests102146016]
(
	InterestCode varchar(2),
	CustomerNo int,
	InterestDesc nvarchar(100),
	Primary Key (InterestCode, CustomerNo),
	Foreign Key (CustomerNo) references Customers102146016
)
