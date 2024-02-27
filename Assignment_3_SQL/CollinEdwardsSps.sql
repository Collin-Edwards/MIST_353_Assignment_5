create proc registeruser
    @username nvarchar(50),
    @passwordhash nvarchar(255),
    @email nvarchar(100),
    @isdoduser bit,
    @firstname nvarchar(50),
    @lastname nvarchar(50)
as
begin
    insert into users (username, passwordhash, email, isdoduser, firstname, lastname)
    values (@username, @passwordhash, @email, @isdoduser, @firstname, @lastname);
end;
go

go
create proc validateuserlogin
    @username nvarchar(50),
    @passwordhash nvarchar(255)
as
begin
    select userid
    from users
    where username = @username and passwordhash = @passwordhash;
end;
go
