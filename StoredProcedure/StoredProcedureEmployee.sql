create proc Employee_Add
	@FirstName nvarchar(max),
	@LastName nvarchar(max),
	@Gender nvarchar(max),
	@Address nvarchar(max),
	@PhoneNumber nvarchar(max)
as
begin
	insert into Employees values(
		@FirstName,
		@LastName,
		@Gender,
		@Address,
		@PhoneNumber
	)
end

create proc Employee_Update
	@Id int,
	@FirstName nvarchar(max),
	@LastName nvarchar(max),
	@Gender nvarchar(max),
	@Address nvarchar(max),
	@PhoneNumber nvarchar(max)
as
begin
	update Employees set
		FirstName = @FirstName,
		LastName = @LastName,
		Gender = @Gender,
		[Address] = @Address,
		PhoneNumber = @PhoneNumber
	where Id = @Id	
end


create proc Employee_Delete
	@Id int
as
begin
	delete from Employees where Id = @Id
end



create proc Employee_Id
@Id int
as
begin
	select * from Employees where Id = @Id
end