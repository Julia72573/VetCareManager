CREATE TABLE Owners (
    id_owner INT PRIMARY KEY IDENTITY(1,1),
    firstname NVARCHAR(50),
    lastname NVARCHAR(50),
    phone NVARCHAR(15) UNIQUE
);


CREATE TABLE Vets (
    id_vet INT PRIMARY KEY IDENTITY(1,1),
    firstname NVARCHAR(50),
    lastname NVARCHAR(50),
    specialization NVARCHAR(100)
);

CREATE TABLE Pets (
    id_pet INT PRIMARY KEY IDENTITY(1,1),
    firstname NVARCHAR(50),
    breed NVARCHAR(50),
    birthday_date DATE,
    id_owner INT,
    species NVARCHAR(50),
    FOREIGN KEY (id_owner) REFERENCES Owners(id_owner)
);


CREATE TABLE Visits (
    id_visit INT PRIMARY KEY IDENTITY(1,1),
    visit_date DATETIME,
    reason NVARCHAR(MAX),
    id_pet INT,
    id_vet INT,
    FOREIGN KEY (id_pet) REFERENCES Pets(id_pet),
    FOREIGN KEY (id_vet) REFERENCES Vets(id_vet)
);

INSERT INTO Owners (firstname, lastname, phone) VALUES 
('Jan', 'Kowalski', '501-234-567'),
('Anna', 'Nowak', '602-345-678'),
('Julia', 'Kosniowska', '503-111-222'),
('Anna', 'Kowalska', '344-542-687'),
('Maria', 'Lukasik', '345-653-134'),
('Aniela', 'Karpacz', '501-234-566'),
('Irena', 'Kmiecik', '435-645-543');


INSERT INTO Vets (firstname, lastname, specialization) VALUES 
('Marek', 'Nowak', 'Kardiolog'),
('Ewa', 'Lis', 'Chirurg'),
('Tomasz', 'Kaczmarek', 'Neurolog');

INSERT INTO Pets (firstname, breed, birthday_date, id_owner, species) VALUES 
('Bella', 'Labrador', '2018-05-12', 1, 'Pies'),
('Max', 'Beagle', '2020-11-03', 1, 'Pies'),
('Luna', 'Perski', '2019-08-15', 2, 'Kot'),
('Rocky', 'Owczarek niemiecki', '2017-02-20', 3, 'Pies'),
('Bonnie', 'Perski', '2022-01-15', 2, 'Kot'),
('Maya', 'Europejski', '2025-11-06', 2, 'Kot'),
('Pepsi', 'Europejski', '2025-12-12', 3, 'Kot');

INSERT INTO Visits (visit_date, reason, id_pet, id_vet) VALUES 
('2023-09-10 10:30:00', 'Szczepienie', 1, 1),
('2023-10-05 12:00:00', 'Kontrola', 2, 1),
('2026-05-20 10:00:00', 'Zlamana noga', 4, 2),
('2026-06-12 14:30:00', 'Problemy skórne', 3, 3),
('2026-07-05 09:15:00', 'Rutynowe badanie', 1, 2),
('2026-03-21 21:46:00', 'Szczepienie', 7, 1),
('2026-10-24 19:10:00', 'Rutynowe badanie', 2, 3),
