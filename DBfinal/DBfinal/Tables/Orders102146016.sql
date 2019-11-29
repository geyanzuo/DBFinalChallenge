CREATE TABLE [Orders102146016]
(
	CustomerNo INT,
	RecordID varchar(20),
	DateOrder Date,
	Price float,
	Primary Key(CustomerNo, RecordID, DateOrder),
	Foreign Key(CustomerNo) references Customers102146016(CustomerNo),
	Foreign Key(RecordID) references Perform102146016(RecordID)
)
