-- CREATE DATABASE zoldseges;
-- USE zoldseges;

CREATE TABLE zoldseg(
id INT PRIMARY KEY IDENTITY,
nev VARCHAR(50),
egysegAr INT);

CREATE TABLE eladas(
datum DATE,
zoldseg INT FOREIGN KEY REFERENCES zoldseg(id),
mennyiseg INT);

INSERT INTO zoldseg VALUES
('eper', 2600),
('bab', 1000),
('dinnye', 120),
('cékla', 250);

INSERT INTO eladas VALUES
('2019-12-20', 1, 1),
('2019-12-21', 2, 3),
('2019-12-23', 2, 6),
('2019-12-23', 2, 4),
('2019-01-05', 3, 7),
('2019-01-05', 4, 2),
('2019-01-06', 4, 4);