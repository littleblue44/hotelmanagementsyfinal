create database myHotel

create table rooms(
roomid int Identity(1,10) primary key,
roomNo varchar(250) not null unique,
roomType varchar(250) not null,
bed varchar (250) not null,
price bigint not null,
booked varchar (50) default 'NO'
);
