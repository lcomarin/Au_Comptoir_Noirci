#--------------------------------------------------------------------------------
#-- Script SQL qui permet de créer les tables pour le projet Asp.Net
#-- Au Comptoir Noirci de Lionel COMARIN et Pierre-Antoine TRIDON
#-------------------------------------------------------------------------------

DROP Table IF EXISTS  Utilisateur;
DROP TABLE IF EXISTS  Message;
DROP Table IF EXISTS  Annonce;
DROP Table IF EXISTS  Categorie_Annonce;
DROP TABLE IF EXISTS  CategorieCategorie_Annonce;
DROP TABLE IF EXISTS  Annonce;
DROP TABLE IF EXISTS  Categorie;

#------------------------------------
#-- Table Utilisateur
#------------------------------------
CREATE TABLE Utilisateur (
	id_utilisateur int PRIMARY KEY, 
	login VARCHAR(25),
	password VARCHAR(25), 
	nom VARCHAR(25), 
	prenom VARCHAR(25), 
	adresse VARCHAR(255),
	courriel VARCHAR(150),  
	telephone int, 
	statut VARCHAR(25)
);

#------------------------------------
#-- Table Message
#------------------------------------
CREATE TABLE Message (
	id_message int PRIMARY KEY, 
	dateMessage Date NOT NULL, 
	id_utilisateur_expediteur int REFERENCES Utilisateur(id_utilisateur), 
	id_utilisateur_destinataire int REFERENCES Utilisateur(id_utilisateur),
	id_annonce int REFERENCES Annonce(id_annonce)
);

#------------------------------------
#-- Table Annonce
#------------------------------------
CREATE TABLE Annonce (
	id_annonce int PRIMARY KEY, 
	titre VARCHAR(100),
	contenu VARCHAR(MAX),
	dateAnnonce Date NOT NULL, 
	statut VARCHAR(25),
	photo VARCHAR(100),
	id_utilisateur int REFERENCES Utilisateur(id_utilisateur)
);

#------------------------------------
#-- Table Categorie_Annonce
#------------------------------------
CREATE TABLE Categorie_Annonce (
	id_categorie VARCHAR(10) REFERENCES Categorie(id_categorie), 
	id_annonce VARCHAR(10) REFERENCES Annonce(id_annonce),
	PRIMARY KEY (id_categorie, id_annonce)
);


#------------------------------------
#-- Table Categorie
#------------------------------------
CREATE TABLE Categorie(
	id_categorie int PRIMARY KEY, 
	libelle VARCHAR(100),
	description VARCHAR(255)
);

#------------------------------------
#-- Mise à jour de la table Categorie
#------------------------------------
INSERT INTO Categorie VALUES (1,'Meuble','Pour décorer ou ranger');
INSERT INTO Categorie VALUES (2,'Bois','C''est ne matière vivante, il faut donc le traiter, c''est capital!');
INSERT INTO Categorie VALUES (3,'Ferme','Idéal pour élever des animaux, comme des ânes mignon comme tout');
INSERT INTO Categorie VALUES (4,'Château','Place fortifiée. Vérifier le nombre de pierres.');
INSERT INTO Categorie VALUES (5,'Pierre','C''est joli à la vue');

#------------------------------------
#-- Mise à jour de la table Categorie_Annonce
#------------------------------------
INSERT INTO Categorie_Annonce VALUES (1,1);
INSERT INTO Categorie_Annonce VALUES (1,2);
INSERT INTO Categorie_Annonce VALUES (2,3);
INSERT INTO Categorie_Annonce VALUES (2,2);
INSERT INTO Categorie_Annonce VALUES (3,4);
INSERT INTO Categorie_Annonce VALUES (3,5);

#------------------------------------
#-- Mise à jour de la table Annonce
#------------------------------------
INSERT INTO Annonce VALUES (1,'Table Ronde','Une table ayant à peine servie, revêtement cuir, intemporel, tannerie de luxe, assemblée au crochet de six, traitement à l''huile de porc. Attention aux repas.','2015-01-07', 'En vente', 'http://i.skyrock.net/7552/87697552/pics/3156954740_1_2_sG0NNL1k.jpg',1);
INSERT INTO Annonce VALUES (2,'Ferme','Une ferme familiale, avec dépendances, et un pré plus vert que celui du voisin.','2015-03-27', 'En vente', 'http://www.carte-france.info/photos/images/maxi/ferme,des,freres,perrel.jpg',2);
INSERT INTO Annonce VALUES (3,'Camelot','Château en bon état, 24 000 pierres, attire souvent les envahisseurs par paquet de 1 ou 2 dans les salles. Penser à verrouiller la porte la nuit pour dormir tranquille','2015-06-08', 'En vente', 'http://vignette4.wikia.nocookie.net/kaamelott-officiel/images/1/12/Camelot.jpg/revision/latest/scale-to-width-down/1000?cb=20150102191154&path-prefix=fr',1);

#------------------------------------
#-- Mise à jour de la table Utilisateur
#------------------------------------
INSERT INTO Utilisateur VALUES (1, 'Arthur','Arthur', 'Pendragon', 'Arthur', 'Camelot', 'arthur@camelot.fr', 0, 'Utilisateur');
INSERT INTO Utilisateur VALUES (2, 'Guethenoc','Guethenoc', 'Aucun', 'Guethenoc', 'Village de Camelot', 'guethenoc@camelot.fr', 0, 'Utilisateur');

#------------------------------------
#-- Mise à jour de la table Message
#------------------------------------
INSERT INTO Message VALUES (1,'Bonjour sire, j''aimerais savoir pour la table ronde , elle fait quelle taille?','2015-01-07',2,1);
INSERT INTO Message VALUES (2,'Alors, déjà, je ne suis plus roi, alors arrêtez de m''appeler sire. Ensuite, elle fait une toise et demie, soit six pieds, soit deux verges, soit une aune et demie.','2015-01-07',1,2);
INSERT INTO Message VALUES (3,'Désolé, sire. Mais du coup, elle fait quelle taille? Une toise et demie, ou six pieds, ou deux verges, ou une aune et demie?','2015-01-07',2,1);

