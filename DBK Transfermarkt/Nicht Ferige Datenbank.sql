Drop database if exists Transfermarkt;
create database Transfermarkt;
use Transfermarkt;

-- Spieler Tabelle
CREATE TABLE Spieler (
    SpielerID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100),
    Nationalität VARCHAR(100),
    Geburtsdatum DATE,
    VereinID INT,
    VertragID INT,
    AuszeichnungID INT
   
);

-- Verein Tabelle
CREATE TABLE Verein (
    VereinID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100),
    LigaID INT,
    WettbewerbID INT,
    WerbepartnerID INT
   
);

-- Liga Tabelle
CREATE TABLE Liga (
    LigaID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100)
);

-- Wettbewerb Tabelle
CREATE TABLE Wettbewerb (
    WettbewerbID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100)
);

-- Nation Tabelle
CREATE TABLE Nation (
    NationID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100)
);

-- Trainer Tabelle
CREATE TABLE Trainer (
    TrainerID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100),
    VereinID INT
  
);

-- Statistik Tabelle
CREATE TABLE Statistik (
    StatistikID INT AUTO_INCREMENT PRIMARY KEY,
    SpielerID INT,
    Statistiktyp VARCHAR(100),
    Wert INT
  
);

-- Werbepartner Tabelle
CREATE TABLE Werbepartner (
    WerbepartnerID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100)
);

-- Vertrag Tabelle
CREATE TABLE Vertrag (
    VertragID INT AUTO_INCREMENT PRIMARY KEY,
    SpielerID INT,
    VereinID INT,
    Startdatum DATE,
    Enddatum DATE
  
);

-- Auszeichnung Tabelle
CREATE TABLE Auszeichnung (
    AuszeichnungID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100)
);

-- ------------------------------------------------------------------------------------------------------------------------------------------------------
-- Spieler Tabelle
ALTER TABLE Spieler
ADD COLUMN NationalitaetsID INT,
ADD FOREIGN KEY (NationalitaetsID) REFERENCES Nation(NationID);

-- Verein Tabelle
ALTER TABLE Verein
ADD FOREIGN KEY (LigaID) REFERENCES Liga(LigaID),
ADD FOREIGN KEY (WettbewerbID) REFERENCES Wettbewerb(WettbewerbID),
ADD FOREIGN KEY (WerbepartnerID) REFERENCES Werbepartner(WerbepartnerID);

-- Trainer Tabelle
ALTER TABLE Trainer
ADD FOREIGN KEY (VereinID) REFERENCES Verein(VereinID);

-- Statistik Tabelle
ALTER TABLE Statistik
ADD FOREIGN KEY (SpielerID) REFERENCES Spieler(SpielerID);

-- Vertrag Tabelle
ALTER TABLE Vertrag
ADD FOREIGN KEY (SpielerID) REFERENCES Spieler(SpielerID),
ADD FOREIGN KEY (VereinID) REFERENCES Verein(VereinID);

-- Auszeichnung Tabelle
ALTER TABLE Auszeichnung
ADD COLUMN SpielerID INT,
ADD FOREIGN KEY (SpielerID) REFERENCES Spieler(SpielerID);


