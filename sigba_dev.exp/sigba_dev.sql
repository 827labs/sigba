create table telefonou 
  (
    numdocu integer,
    numero integer,
    primary key (numero) 
  );

create table cargo 
  (
    idcargo integer,
    nombre varchar(100) not null,
    primary key (idcargo) 
  );

create table ejerce 
  (
    asignado date,
    idcargo integer,
    numdocu integer
  );
create table funcionalidad 
  (
    nombre varchar(100),
    primary key (nombre) 
  );

create table accede 
  (
    idcargo integer,
    nombre varchar(100)
  );

create table cheque 
  (
    fechaemisionche date,
    fechahabilitacobroche date,
    idche serial not null,
    monedache varchar(3),
    montoche decimal(8,2),
    numche integer not null,
    numdoccobr varchar(20),
    paisdoccobr varchar(50),
    tipoche varchar(3),
    tipodoccobr varchar(10),
    primary key (idche) 
  );

create table banco 
  (
    direccionb varchar(100) not null,
    habilitarccpersonas boolean not null,
    limiteretirocajerobdependenciaspesos integer not null,
    limiteretirocajerobisladolares integer not null,
    limiteretirocajerobislapesos integer not null,
    logob text,
    nombrefantasiab varchar(80) not null,
    rut integer not null,
    razonsocial varchar(80) not null,
    sitiowebb varchar(90),
    telefonob varchar(50),
    limiteretirocajerobdependenciasdolares integer not null,
    maxdepositosindeclararpesos integer not null,
    maxdepositosindeclarardolares integer not null,
    minimodepositocajapesos integer not null,
    minimodepositocajadolares integer not null 
  );

create table sucursal 
  (
    calledirsuc varchar(90) not null,
    horario varchar(50) not null,
    nombresuc varchar(90) not null,
    nrodirsuc integer not null,
    numsuc serial not null,
    primary key (numsuc) 
  );

create table cuenta 
  (
    fechacierre date,
    idcuenta integer,
    moneda varchar(3) not null,
    saldo decimal(8,2) not null,
    usofirmas varchar(20) not null,
    tipo char(2) not null,
    numsuc integer not null,
    primary key (idcuenta) 
  );

create table registroaccion 
  (
    datosextra varchar(255),
    fecha date not null,
    hora varchar(5),
    nombre varchar(100) not null,
    numdocu integer,
    idreg serial not null,
    primary key (idreg) 
  );

create table movimiento 
  (
    diferencia decimal(8,2) not null,
    idcuenta integer not null,
    numdocu integer not null,
    idmov serial not null,
    saldoanterior decimal(8,2) not null,
    primary key (idmov) 
  );

create table usuario 
  (
    nombre varchar(100),
    apellido varchar(100),
    numdocu integer,
    claveu varchar(100) not null,
    codrecuperacionu integer,
    suspendido varchar(10),
    emailu varchar(100),
    primary key (numdocu) 
  );

create table cliente 
  (
    aclaraciondirc text,
    apdirc integer,
    blockdirc varchar(8),
    calledirc varchar(80) not null,
    ciudadc varchar(20) not null,
    codpostalc integer not null,
    id serial not null,
    motivobaja text,
    nrodirc integer,
    telefonoc varchar(20),
    primary key (id) 
  );

create table persona 
  (
    apellidop varchar(100) not null,
    ciudadnac varchar(80) not null,
    fechanac date not null,
    mail varchar(100) not null,
    id integer not null,
    nombrep varchar(100) not null,
    numdoccony varchar(80),
    numdocp varchar(80) not null,
    paisdoccony varchar(80),
    paisdocp varchar(80) not null,
    paisnac varchar(80) not null,
    sexop char(1) not null,
    tipodoccony varchar(15),
    tipodocp varchar(15) not null,
    idp serial not null,
    primary key (idp) 
  );

create table empresa 
  (
    departamentoe varchar(50) not null,
    id integer not null,
    rut integer not null,
    ide integer not null,
    paisorigencapitale varchar(50) not null,
    paisorigene varchar(50) not null,
    webe varchar(100),
    razonsociale varchar(100),
    tiposociedade varchar(100),
    
    check (departamentoe IN ('Artigas' ,'Canelones' ,'Cerro Largo' ,'Colonia' ,'Durazno' ,'Flores' ,'Florida' ,'Lavalleja' ,'Maldonado' ,'Montevideo' ,'Paysandu' ,'Rio Negro' ,'Rivera' ,'Rocha' ,'Salto' ,'San Jose' ,'Soriano' ,'Tacuarembo' ,'Treinta y Tres' )),
    primary key (rut)  constraint pk_empresa
  );

create table socioempresa 
  (
    callesoc varchar(80) not null,
    nombresocio varchar(100) not null,
    nrodocsoc varchar(50) not null,
    numerosoc integer not null,
    paisdocsoc varchar(80) not null,
    participacion decimal(7,4) not null,
    rut integer,
    tipodocsoc varchar(15),
    idsocio serial not null,
    
    check ((participacion > 0.0000 ) AND (participacion <= 100.0000 ) ),
    primary key (idsocio) 
  );

create table cajeroautomatico 
  (
    dinero integer not null,
    numcaj serial not null,
    numsuc integer,
    
    check (dinero >= 0 ),
    primary key (numcaj) 
  );

create table libreta 
  (
    fechaemisionlib date not null,
    numlib serial not null,
    serie integer not null,
    primary key (numlib) 
  );

create table caja 
  (
    abierta integer,
    num serial not null,
    numsuc integer not null,
    primary key (num) 
  );

create table estado 
  (
    ide serial not null,
    fecha date not null,
    tipo varchar(8) not null,
    numcaja integer not null,
    saldousd integer not null,
    saldouyu integer not null,
    primary key (ide)  constraint pk_estado
  );


alter table telefonou add constraint (foreign key 
    (numdocu) references usuario );
alter table ejerce add constraint (foreign key (idcargo) 
    references cargo );
alter table ejerce add constraint (foreign key (numdocu) 
    references usuario );
alter table accede add constraint (foreign key (idcargo) 
    references cargo );
alter table accede add constraint (foreign key (nombre) 
    references funcionalidad );
alter table registroaccion add constraint (foreign 
    key (nombre) references funcionalidad );
alter table movimiento add constraint (foreign key 
    (idcuenta) references cuenta );
alter table movimiento add constraint (foreign key 
    (numdocu) references usuario );
alter table persona add constraint (foreign key (id) 
    references cliente );
alter table empresa add constraint (foreign key (id) 
    references cliente );
alter table socioempresa add constraint (foreign key 
    (rut) references empresa );
alter table cajeroautomatico add constraint (foreign 
    key (numsuc) references sucursal );
alter table caja add constraint (foreign key (numsuc) 
    references sucursal );
alter table estado add constraint (foreign key (numcaja) 
    references caja );
alter table caja add constraint (foreign key (abierta) 
    references estado  constraint pk_abierta);
    