create database QuanLyQuanCafe
go

use QuanLyQuanCafe
go

create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	status nvarchar(100) not null default N'Trống'
)
go

create table Account
(
	UserName nvarchar(100) not null primary key,
	DisplayName nvarchar(100) not null default N'Chưa đặt tên',
	PassWord nvarchar(1000) not null,
	Type int not null default 0 --1:admin, 0: staff
)
go

create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên'
)
go

create table Food
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0

	foreign key (idCategory) references dbo.FoodCategory(id)
)
go

create table Bill
(
	id int identity primary key,
	DateCheckIn date not null default getdate(),
	DateCheckOut date,
	idTable int not null,
	status int not null --1: da thanh toan, 0: chua thanh toan

	foreign key (idTable) references dbo.TableFood(id)
)
go

create table BillInfo
(
	id int identity primary key,
	idBill int  not null,
	idFood int not null,
	count int not null default 0

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
go

create proc USP_GetListAccount
@userName nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @userName
end
go

exec dbo.USP_GetListAccount @userName = N'admin'
go

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(1000)
as
begin
	select * from dbo.Account where UserName = @userName and PassWord = @passWord
end
go

create proc USP_GetTableList
as select * from dbo.TableFood
go



alter proc USP_InsertBill
@idTable int
as
begin
	insert into Bill(
					DateCheckIn, 
					DateCheckOut, 
					idTable, 
					status,
					totalPrice
					)
	values (
			GETDATE(), 
			null, 
			@idTable, 
			0,
			0
			)
	update dbo.TableFood set status = N'Có người' where id = @idTable
end
go

alter proc USP_InsertBillInfo
@idBill int, @idFood int, @count int, @idTable int
as
begin

	declare @isExistsBillInfo int;
	declare @foodCount int = 1;

	select @isExistsBillInfo = id, @foodCount = count from BillInfo where idBill = @idBill and idFood = @idFood

	if(@isExistsBillInfo > 0)
	begin
		
		declare @newCount int = @foodCount + @count

		if(@newCount > 0)
		begin
			update BillInfo set count = @foodCount + @count where idFood = @idFood and idBill = @idBill
		end
		else
		begin
			delete BillInfo where idBill = @idBill and idFood = @idFood
			--update TableFood set status = N'Trống' where id = @idTable
			-- kiem tra neu billinfo = 0 thi xóa bill
			declare @countBillInfo int
			select @countBillInfo = count(*) from BillInfo where idBill = @idBill
			if(@countBillInfo = 0)
				delete Bill where id = @idBill
		end
			
	end
	else
	begin
		if(@count > 0)
		begin
			insert into BillInfo(
					idBill, 
					idFood, 
					count)
		values (
				@idBill, 
				@idFood, 
				@count
				)
		end
		else
			update TableFood set status = N'Trống' where id = @idTable
	end
end
go

exec USP_InsertBill 8
exec USP_InsertBillInfo 175, 1, 1, 8
exec USP_InsertBillInfo 175, 2, 1, 8
exec USP_InsertBill 5
exec USP_InsertBillInfo 176, 2, 1, 5
exec USP_InsertBillInfo 176, 2, -1, 5
exec USP_InsertBillInfo 175, 2, -1, 8





select count(*) from BillInfo where idBill = 2



update TableFood set status = N'Trống' where id = 1



select f.id, f.name, bi.count, f.price, (f.price*bi.count*(100-f.discount))/100 as totalPrice, f.discount from Bill as b, BillInfo as bi, Food as f where bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = 5
go



SELECT TOP 1 * FROM Bill ORDER BY id DESC 
go

select max(id) from Bill
go

select * from dbo.Bill where idTable = 1 and status = 0
go


alter table Bill
add totalPrice float
go

update dbo.bill set totalPrice = 0
go

alter table Food
add discount int
go

update dbo.Food set discount = 0

delete from BillInfo
delete from Bill

create proc USP_ThanhToan
@idTable int, @idBill int, @dateCheckOut Date, @totalPrice float
as
begin
	update TableFood set status = N'Trống' where id = @idTable
	update Bill set DateCheckOut = @dateCheckOut, status = 1, totalPrice = @totalPrice where id = @idBill
end
go

exec USP_ThanhToan 8, 123, '20210519', 30000

select id from Bill where idTable = 5 and status = 0
