create database ccDB;

use ccDB;

CREATE TABLE Clientes (
    Usuario VARCHAR(30) NOT NULL,
    Contrasena VARCHAR(30) NOT NULL,
    Mejor_Puntaje INT NOT NULL,
    Ultimo_Puntaje INT NOT NULL,
    PRIMARY KEY (Usuario)
)  ENGINE=InnoDB;