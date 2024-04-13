create table Notification
(
	userNameSender varchar(11) foreign key(userNameSender) REFERENCES Account(userName) null,
	userNameReceiver varchar(11) foreign key(userNameReceiver) REFERENCES Account(userName),
	sendingTime datetime not null,
	content nvarchar(max) not null,
	isWatched bit not null,
	type nvarchar(30) not null
)
drop table Notification
alter table Notification add type nvarchar(30) not null

insert Notification values(null, 'hoan47', '20040416 18:45', N'Bạn nhận được 15 điểm.', 0, 'system')
insert Notification values(null, 'hoan47', '20040416 18:45', N'Bạn vừa được thăng hạng đồng, Khi sử dụng các dịch vụ bạn được giảm 10 %.', 0, 'system')
insert Notification values('hoan123', 'hoan47', '20040416 18:05', N'Bạn nhận được 100 xu.', 0, 'coins') 
insert Notification values(null, 'hoan123', '20040416 18:05', N'Bạn bị trừ 100 xu. Gửi cho Bùi Quang Hoàn.', 0, 'coins') 


select * from Notification
delete Notification where content = N'Bạn nhận được 10 xu.'
