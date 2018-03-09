
CREATE TABLE TARIFS
(idTarif varchar(25) not null primary key,
coutHoraire double, 
coutRevientHoraire double,
margeHoraire double, 
coutJour double, 
coutRevientJour double,
margeJour double);

CREATE TABLE PERSONNALISATION
(idPerso varchar(25) not null primary key, 
libPerso varchar(50),
coutPerso double, 
coutRevientPerso double, 
margePerso double);

CREATE TABLE INDEMNKM
(idIndemnKM varchar(25) primary key not null, 
nbCV int,
coef double,
coef2 double,
annee int,
nbKmAn int);

CREATE TABLE ELEMENT_PERSONNALISABLE
(idElementPerso varchar(25) not null primary key,
nomElementPerso varchar(50),
idTarif varchar(25),
foreign key (idTarif) references TARIF(idTarif));

CREATE TABLE ELEMENTS
(idElement varchar(25) not null primary key,
nomElement varchar(50),
idTarif varchar(25),
constraint fk_elements foreign key (idTarif) references TARIF(idTarif));

CREATE TABLE EQUIPE
(idEquipe varchar(25) not null primary key,
nomEquipe varchar(50));

CREATE TABLE EST_PERSONNALISE
(idElementPerso varchar(25),
idPerso varchar(25),
idEquipe varchar(25),
primary key (idElementPerso, idPerso, idEquipe),
constraint fk_est_perso foreign key (idElementPerso) references ELEMENT_PERSONNALISABLE(idElementPerso),
constraint fk_est_perso2 foreign key (idPerso) references PERSONNALISATION(idPerso),
constraint fk_est_perso3 foreign key (idEquipe) references EQUIPE(idEquipe));

CREATE TABLE COMPOSE
(idEquipe varchar(25), 
idElement varchar(25), 
quantite int,
primary key(idEquipe, idElement),
constraint fk_compose foreign key (idEquipe) references EQUIPE(idEquipe),
constraint fk_compose2 foreign key (idElement) references ELEMENTS(idElement));

INSERT INTO `tarifs`(`idTarif`, `coutHoraire`, `coutRevientHoraire`, `margeHoraire`, `coutJour`, `coutRevientJour`, `margeJour`) 
VALUES ('TA0', 40, 25, 15, null, null, null), 
('TA1', 45, 25, 20, null, null, null), 
('TA2', null, null, null, 150, 0, 150), 
('TA3', null, null, null, 500, 0, 500), 
('TA4', 40, 25, 15, null, null, null), 
('TA5', 45, 25, 20, null, null, null), 
('TA6', 35, 30, 5, null, null, null), 
('TA7', 60, 30, 30, 420, 280, 140), 
('TA8', null, null, null, 40, 30, 10);

INSERT INTO `elements`(`idElement`, `nomElement`, `idTarif`) 
VALUES ('EL0', 'manutentionnaire', 'TA4'), 
('EL1', 'pilote', 'TA5'), 
('EL2', 'encadrant', 'TA6'), 
('EL3', 'horaires2S', 'TA7'), 
('EL4', 'brief', 'TA8');

INSERT INTO `equipe`(`idEquipe`, `nomEquipe`) 
VALUES ('EQ0', 'distribution flyers'), 
('EQ1', 'velo pub'), 
('EQ2', 'velo triporteur');

INSERT INTO `element_personnalisable`(`idElementPerso`, `nomElementPerso`, `idTarif`) 
VALUES ('ELP0', 'hotesse distribution', 'TA0'), 
('ELP1', 'hotesse triporteur', 'TA1'), 
('ELP2', 'velo pub', 'TA2'), 
('ELP3', 'velo triporteur', 'TA3');

INSERT INTO `personnalisation`(`idPerso`, `libPerso`, `coutPerso`, `coutRevientPerso`, `margePerso`) 
VALUES ('PS0', 'journaux akilux', 60, 25, 35), 
('PS1', 'x banner', 130, 80, 50), 
('PS2', 'tenue vestimentaire hotesse', 65, 30, 35), 
('PS3', 'bache r/v', 270, 70, 200), 
('PS4', 'face avant + capot int/ext', 350, 130, 220), 
('PS5', 'roues velo triporteur', 475, 200, 275), 
('PS6', 'parasol pied fixe', 550, 295, 255), 
('PS7', 'parasol sur velo triporteur', 280, 190, 90), 
('PS8', 'chevalet', 300, 180, 120), 
('PS9', 'tenue vestimentaire pilote', 85, 30, 45);

INSERT INTO `indemnkm`(`idIndemnKM`, `nbCV`, `coef`, `coef2`, `annee`, `nbKmAn`) 
VALUES ('ID0', 3, 0.4, null, 2018, '5000'),
('ID1', 3, 0.245, 824, 2018, '20000'),
('ID2', 3, 0.286, null, 2018, 'MAX'),
('ID3', 4, 0.493, null, 2018, '5000'),
('ID4', 4, 0.277, 1082, 2018, '20000'),
('ID5', 4, 0.332, null, 2018, 'MAX'),
('ID6', 5, 0.543, null, 2018, '5000'),
('ID7', 5, 0.305, 1188, 2018, '20000'),
('ID8', 5, 0.364, null, 2018, 'MAX'),
('ID9', 6, 0.568, null, 2018, '5000'),
('ID10', 6, 0.32, 1244, 2018, '20000'),
('ID11', 6, 0.382, null, 2018, 'MAX'),
('ID12', 7, 0.595, null, 2018, '5000'),
('ID13', 7, 0.337, 1288, 2018, '20000'),
('ID14', 7, 0.401, null, 2018, 'MAX');