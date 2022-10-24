create table dbo.People
(
	id int PRIMARY KEY IDENTITY(1,1),
	first_name varchar(50) not null,
	last_name varchar(50) not null,
	email varchar(255) not null,
	gender varchar(20),
	created datetime,
	updated datetime
);

