CREATE TABLE akun (
    id SERIAL PRIMARY KEY,
    username VARCHAR(100) NOT NULL,
    psword VARCHAR(20) UNIQUE NOT NULL);
CREATE TABLE Kontak (
	id SERIAL PRIMARY KEY,
	Nama VARCHAR(100) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	NoHp VARCHAR (100) NOT NULL);
INSERT INTO akun (username, psword) values ('suri','sisi')
