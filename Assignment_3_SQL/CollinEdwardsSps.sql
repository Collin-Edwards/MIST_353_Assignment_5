create proc registeruser
    @username nvarchar(50),
    @passwordhash nvarchar(255),
    @email nvarchar(100),
    @isdoduser bit
as
begin
    insert into users (username, passwordhash, email, isdoduser)
    values (@username, @passwordhash, @email, @isdoduser);
end;
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
