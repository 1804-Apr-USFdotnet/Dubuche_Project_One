create database Restaurants
go

use Restaurants
go

alter table Restaurants.Restaurants
add Id int Identity (1,1)primary key;


alter table Restaurants.Reviewers
add Id int Identity (1,1)primary key;

select * from Restaurants.Reviewers

alter table Restaurants.Reviewers
add foreign key (RestaurantId) references Restaurants.Restaurants(Id);