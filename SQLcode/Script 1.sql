
CREATE TABLE KorisnikInfo(id NUMBER NOT NULL,
                          username VARCHAR2(15) NOT NULL,
                          pass VARCHAR2(15) NOT NULL,
                          CONSTRAINT c_A_id_PK PRIMARY KEY (id)
);


CREATE TABLE KolekcijaKorisnika(id_korisnika NUMBER NOT NULL,
                                id_artikal NUMBER NOT NULL,
                                CONSTRAINT korisnik_fk FOREIGN KEY (id_korisnika) REFERENCES Korisnik (id),
                                CONSTRAINT artikal_fk FOREIGN KEY (id_korisnika) REFERENCES Artikal (id));

CREATE TABLE Korisnik(id INTEGER PRIMARY KEY,
                      adresa NUMBER NOT NULL,
                      kreditna VARCHAR2(15) NOT NULL,
                      tipAccounta VARCHAR2(15) NOT NULL,
		      removed BOOLEAN
);

CREATE TABLE Artikal(id INTEGER PRIMARY KEY,
                     ime VARCHAR2(20) NOT null,
                     cijena NUMBER NOT NULL,
                     fizicki BOOLEAN,
                     info VARCHAR2(100) NOT NULL,
                     sifra number NOT NULL,
		     removed BOOLEAN);

CREATE TABLE Lokacija(INTEGER PRIMARY KEY,
                      adresa VARCHAR2(20) NOT NULL,
                      opisLokacije VARCHAR2(15) NOT NULL,
  		      removed BOOLEAN);

CREATE TABLE Item(id NUMBER NOT NULL,
                  datumProdaje DATE,
                  id_location NUMBER, NOT NULL,
		  removed BOOLEAN,
                  CONSTRAINT ITid_ArtID FOREIGN KEY (id) REFERENCES Artikal (id),
                  CONSTRAINT Loc_LocID_fk FOREIGN KEY (id_location) REFERENCES lokacija (id) );


CREATE TABLE Kritika(id_korisnika NUMBER NOT NULL,
                     komentar VARCHAR2(100) NOT NULL,
                     ocjena NUMBER NOT NULL,
		     removed BOOLEAN,
                     CONSTRAINT korisnik_id_kritika_fk FOREIGN KEY (id_korisnika) REFERENCES Korisnik (id));