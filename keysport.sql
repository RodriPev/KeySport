create table Jugador (
idJugador integer not null primary key,
numCamiseta varchar(2),
nomjugador varchar(15),
apelJugador varchar(15),
idEquipo integer,
foreign key (idEquipo) references Equipo(idEquipo)
);

create table Equipo (
idEquipo integer not null primary key,
nomEquipo varchar(15),
nacEquipo varchar(15),
cede varchar (20),
alineacion varchar(500)
);

create table eventos (
idEvento integer not null primary key,
fechain date,
fechafin date
);

create table campeonato(
idcampeonato integer not null primary key,
localidad varchar(20),
nomCampeonato varchar(20),
resultado varchar (50),
idPartido integer,
foreign key (idPartido) references Partido(idPartido)
);

create table equiposCamp(
idcampeonato integer not null primary key,
equipos varchar(15),
foreign key (idcampeonato) references campeonato(idcampeonato)
);

create table partido(
idPartido integer not null primary key,
fecha date,
hora varchar(10),
resultadoPartido varchar(50),
idJugador integer,
idArbitro integer,
IdEquipo integer,
foreign key (idJugador) references Jugador(idJugador),
foreign key (idArbitro) references arbitro(idArbitro),
foreign key (idEquipo) references Equipo(idEquipo)
);

create table equipoPartido (
idPartido integer not null primary key,
equipos varchar (200),
foreign key (idPartido) references partido(idPartido)
);

create table tarjetaCredito (
numTarjeta integer not null primary key,
fechaVen date
);

create table suscripcion(
idSuscripcion integer not null primary key,
plan varchar(50),
numTarjeta integer,
foreign key (numTarjeta) references tarjetaCredito(numTarjeta)
);

create table notificacion(
idNotificacion integer not null primary key
);

create table de (
idNotificacion integer,
idEvento integer,
foreign key (idNotificacion) references notificacion(idNotificacion),
foreign key (idEvento) references eventos(idEvento)
);

insert into equipo
values (2, "Soca","Uruguay", "Cancha social Soca", "6 en cancha, 3 suplentes");

select nomEquipo from equipo where idEquipo=1;
