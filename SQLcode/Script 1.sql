
CREATE TABLE KolekcijaKorisnika(id_korisnika NUMBER NOT NULL,
                                id_artikal NUMBER NOT NULL,
                                CONSTRAINT korisnik_fk FOREIGN KEY (id_korisnika) REFERENCES Korisnik (id),
                                CONSTRAINT artikal_fk FOREIGN KEY (id_korisnika) REFERENCES Artikal (id));

CREATE TABLE Korisnik(id INTEGER PRIMARY KEY,
		      username VARCHAR2(15) NOT NULL,
                      pass VARCHAR2(15) NOT NULL,
                      adresa INTEGER NOT NULL,
		      tipAccounta VARCHAR2(15) NOT NULL,
		      slika image NOT NULL,
		      removed BOOLEAN,
		      CONSTRAINT lokacija_fk FOREIGN KEY (adresa) REFERENCES Lokacija (id)
);

CREATE TABLE Artikal(id INTEGER PRIMARY KEY,
                     ime VARCHAR2(20) NOT null,
                     cijena NUMBER NOT NULL,
                     fizicki BOOLEAN,
                     info VARCHAR2(100) NOT NULL,
		     slika image NOT NULL,
		     removed BOOLEAN,
		     CONSTRAINT Item_Art_fk FOREIGN KEY (id) REFERENCES Item (id));

CREATE TABLE Lokacija(id INTEGER PRIMARY KEY,
                      adresa VARCHAR2(20) NOT NULL,
                      opisLokacije VARCHAR2(15),
  		      removed BOOLEAN);

CREATE TABLE Item(id INTEGER PRIMARY KEY,
                  datumProdaje DATE,
                  id_location INTEGER NOT NULL,
		  removed BOOLEAN,
                  CONSTRAINT ITid_ArtID FOREIGN KEY (id) REFERENCES Artikal (id),
                  CONSTRAINT Loc_LocID_fk FOREIGN KEY (id_location) REFERENCES Lokacija (id) );


CREATE TABLE Kritika(id_korisnika NUMBER NOT NULL,
		     id_artikla NUMBER NOT NULL,
                     komentar VARCHAR2(100) NOT NULL,
                     ocjena NUMBER NOT NULL,
		     removed BOOLEAN,
                     CONSTRAINT korisnik_id_kritika_fk FOREIGN KEY (id_korisnika) REFERENCES Korisnik (id),
		     CONSTRAINT artikal_id_kritika_fk FOREIGN KEY (id_artikla) REFERENCES Artikal(id));