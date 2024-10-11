create database BikeRentalManagement;
use BikeRentalManagement ;

create table Bikes (
BikeId NVarchar(20) primary key,
Brand NVarchar(20),
Model NVarchar(20),
RentalPrice decimal

);

select * from Bikes;

insert into Bikes(BikeId, Brand, Model, RentalPrice)
values('BIKE_001 ', 'Honda ', 'CB-Shine', 5.00);