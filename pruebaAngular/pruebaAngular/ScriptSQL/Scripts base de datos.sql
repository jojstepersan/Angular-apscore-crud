alter session set "_ORACLE_SCRIPT"=true;
CREATE USER elibreria IDENTIFIED BY Libro2021;
ALTER USER elibreria quota 100M on USERS;
GRANT create table TO elibreria;
GRANT create session TO elibreria;
GRANT create table TO elibreria;
GRANT create view TO elibreria;
GRANT create any trigger TO elibreria;
GRANT create any procedure TO elibreria;
GRANT create sequence TO elibreria;
GRANT create synonym TO elibreria;

CREATE TABLE genero(
id_genero NUMBER,
name varchar2(100),
CONSTRAINT pk_gen PRIMARY key(id_genero) 
);

CREATE TABLE editorial(
id_editorial NUMBER,
name varchar2(100),
CONSTRAINT pk_edt PRIMARY key(id_editorial)
);
ALTER TABLE editorial ADD direccion varchar2(100);
ALTER TABLE editorial ADD telefono varchar2(100);
ALTER TABLE editorial ADD correo varchar2(100);
ALTER TABLE editorial ADD maximo_libros NUMBER;

CREATE TABLE autor(
id_autor NUMBER,
name varchar2(100),
CONSTRAINT pk_aut PRIMARY key(id_autor)
);

ALTER TABLE autor ADD fecha_nacimiento timestamp;
ALTER TABLE autor ADD ciudad varchar2(100);
ALTER TABLE autor ADD correo varchar2(100);


CREATE TABLE libros(
id_libro NUMBER,
titulo varchar2(100),
anho NUMBER,
id_genero number,
num_paginas NUMBER,
id_editorial NUMBER,
id_autor NUMBER,
CONSTRAINT pk_lib PRIMARY key(id_libro),
CONSTRAINT fk_gen FOREIGN KEY(id_genero)  REFERENCES genero(id_genero),
CONSTRAINT fk_edi FOREIGN KEY(id_editorial)  REFERENCES editorial(id_editorial),
CONSTRAINT fk_aut FOREIGN KEY(id_autor)  REFERENCES autor(id_autor)
);

CREATE SEQUENCE autor_seq;
CREATE SEQUENCE editorial_seq;
CREATE SEQUENCE genero_seq;
CREATE SEQUENCE libro_seq;

SELECT * FROM GENERO g ;
SELECT * FROM AUTOR a ;
SELECT * FROM EDITORIAL e2 ;
SELECT * FROM LIBROS l2 ;
