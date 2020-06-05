Create database BasePrueba
use BasePrueba

create table Club(
idClub int identity(1,1) primary key,
Nombre varchar(50))

insert into Club(Nombre)
values('River Plate'),
      ('Boca Juniors'),
	  ('San Lorenzo'),
	  ('Independiente'),
	  ('Racin Club')
     
create table Jugador(
idJugador int identity(1,1),
Apellido varchar(50) not null,
Edad int not null,
idClub int not null,
constraint PK_idJugador PRIMARY KEY (idJugador),
constraint FK_idClub FOREIGN KEY (idClub) references Club(IdClub))



insert into Jugador(Apellido,Edad,idClub)
values('Cortazar',30,1),
      ('Gomez',35,3),
	  ('Molina',25,2),
	  ('Hernandez',20,5)