
CREATE SEQUENCE korisnik_seq
INCREMENT BY 1
START WITH 1
MAXVALUE 50100
NOCACHE
NOCYCLE

CREATE SEQUENCE artikal_seq
INCREMENT BY 1
START WITH 1
MAXVALUE 50100
NOCACHE
NOCYCLE

CREATE SEQUENCE lokacija_seq
INCREMENT BY 1
START WITH 1
MAXVALUE 50100
NOCACHE
NOCYCLE

CREATE SEQUENCE item_seq
INCREMENT BY 1
START WITH 1
MAXVALUE 50100
NOCACHE
NOCYCLE

CREATE SEQUENCE cart_seq
INCREMENT BY 1
START WITH 1
MAXVALUE 50100
NOCACHE
NOCYCLE

CREATE SEQUENCE zahtjev_seq
INCREMENT BY 1
START WITH 1
MAXVALUE 50100
NOCACHE
NOCYCLE


CREATE TABLE KorisnikInfo(id NUMBER NOT NULL,
                          username VARCHAR2(15) NOT NULL,
                          pass VARCHAR2(15) NOT NULL,
                          CONSTRAINT c_A_id_PK PRIMARY KEY (id)
);

CREATE TABLE KreditnaKartica(brojKartice VARCHAR2(15) NOT NULL,
                             tipZastitie VARCHAR2(20) NOT NULL,
                             zastitniKod NUMBER NOT NULL,
                             mjesecIsteka NUMBER NOT NULL,
                             godinaIsteka NUMBER NOT NULL,
                             CONSTRAINT c_brojKart_pk PRIMARY KEY (brojKartice));

CREATE TABLE KolekcijaKorisnika(id_korisnika NUMBER NOT NULL,
                                id_artikal NUMBER NOT NULL,
                                CONSTRAINT korisnik_fk FOREIGN KEY (id_korisnika) REFERENCES Korisnik (id),
                                CONSTRAINT artikal_fk FOREIGN KEY (id_korisnika) REFERENCES Artikal (id));

CREATE TABLE Korisnik(id NUMBER NOT NULL,
                      adresa NUMBER NOT NULL,
                      kreditna VARCHAR2(15) NOT NULL,
                      tipAccounta VARCHAR2(15) NOT NULL,
                      CONSTRAINT c_Korid_PK PRIMARY KEY (id),
                      CONSTRAINT kreditna_fk FOREIGN KEY (kreditna) REFERENCES KreditnaKartica (brojKartice)
);

CREATE TABLE Artikal(id NUMBER NOT NULL,
                     ime VARCHAR2(20) NOT null,
                     cijena NUMBER NOT NULL,
                     fizicki BOOLEAN,
                     info VARCHAR2(100) NOT NULL,
                     sifra number NOT NULL,
                     CONSTRAINT c_A_id_PK PRIMARY KEY (id),
                     CONSTRAINT sifr_id FOREIGN KEY (sifra) REFERENCES SifraArtikal (id));

CREATE TABLE Lokacija(id NUMBER NOT NULL,
                      adresa VARCHAR2(20) NOT NULL,
                      opisLokacije VARCHAR2(15) NOT NULL,
                      CONSTRAINT c_Loc_id_PK PRIMARY KEY (id));

CREATE TABLE Item(id NUMBER NOT NULL,
                  datumProdaje DATE,
                  id_location NUMBER, NOT NULL,
                  CONSTRAINT ITid_ArtID FOREIGN KEY (id) REFERENCES Artikal (id),
                  CONSTRAINT Loc_LocID_fk FOREIGN KEY (id_location) REFERENCES lokacija (id) );

CREATE TABLE DostavneInformacije(id_kupac NUMBER NOT NULL,
                                 id_location NUMBER NOT NULL,
                                 id_artikal NUMBER NOT NULL,
                                 CONSTRAINT kupac_id_fk FOREIGN KEY (id_kupac) REFERENCES Korisnik (id),
                                 CONSTRAINT location_id_fk FOREIGN KEY (id_location) REFERENCES Lokacija (id),
                                 CONSTRAINT artikal_id_fk FOREIGN KEY (id_artikal) REFERENCES Artikal (id));

CREATE TABLE Kritika(id_korisnika NUMBER NOT NULL,
                     komentar VARCHAR2(100) NOT NULL,
                     ocjena NUMBER NOT NULL,
                     CONSTRAINT korisnik_id_kritika_fk FOREIGN KEY (id_korisnika) REFERENCES Korisnik (id));

CREATE TABLE Cart(id_cart NUMBER NOT NULL,
                  id_korisnika NUMBER NOT NULL,
                  id_artikal NUMBER NOT NULL,
                  CONSTRAINT c_id_cart_PK PRIMARY KEY (id_cart),
                  CONSTRAINT korisnik_fk FOREIGN KEY (id_korisnika) REFERENCES Korisnik (id),
                  CONSTRAINT artikal_fk FOREIGN KEY (id_artikal) REFERENCES Artikal (id));

CREATE TABLE Zahtjev(id_korisnik NUMBER NOT NULL,
                     id_zahtjeva NUMBER NOT NULL,
                     datumPodnosenja DATE,
                     obrada VARCHAR2(10) NOT NULL,
                     CONSTRAINT c_id_zahtjev_PK PRIMARY KEY (id_zahtjeva),
                     CONSTRAINT korisnik_fk FOREIGN KEY (id_korisnika) REFERENCES Korisnik (id),
                     CONSTRAINT obrada_ck CHECK (obrada 'auto' OR 'manual'));

CREATE TABLE ZahtjevGoogleMaps(id_zahtjeva NUMBER NOT NULL,
                               id_lokacija NUMBER NOT NULL,
                               vrsta VARCHAR2(15) NOT NULL,
                               CONSTRAINT c_id_zahtjev_UK Unique KEY (id_zahtjeva),
                               CONSTRAINT lokacija_google_fk FOREIGN KEY (id_lokacija) REFERENCES Lokacija (id),
                               CONSTRAINT vrsta_ck CHECK (vrsta 'Dodavanje' OR 'Brisanje'));

CREATE TABLE ZahtjevPremjestaj(id_zahtjeva NUMBER NOT NULL,
                               CONSTRAINT c_id_zahtjev_ZP_UK Unique KEY (id_zahtjeva));

CREATE TABLE objektiItem(id_zahtjeva NUMBER NOT NULL,
                     id_item NUMBER NOT NULL,
                     CONSTRAINT obj_item_fk FOREIGN KEY (id_item) REFERENCES Item(id),
                     CONSTRAINT obj_zahtj_fk FOREIGN KEY (id_zahtjeva) REFERENCES Zahtjev(id_zahtjev));

CREATE TABLE ZahtjevZaKupovinu(id_zahtjev NUMBER NOT NULL,
                               id_cart NUMBER NOT NULL,
                               CONSTRAINT ZZK_zah_fk FOREIGN KEY (id_zahtjev) REFERENCES Zahtjev(id),
                               CONSTRAINT ZZK_cart_fk FOREIGN KEY (id_cart) REFERENCES Cart(id_cart));

CREATE TABLE ZahtjevPovratak(id_zahtjeva NUMBER NOT NULL,
                             id_item NUMBER NOT NULL,
                             razlog VARCHAR2(50) NOT NULL,
                             CONSTRAINT ZP_item_fk FOREIGN KEY (id_item) REFERENCES Item(id),
                             CONSTRAINT ZP_zahtj_fk FOREIGN KEY (id_zahtjeva) REFERENCES Zahtjev(id_zahtjev));

CREATE TABLE ZahtjevNabavka (id_zahtjeva NUMBER NOT NULL,
                             id_lokacija NUMBER NOT NULL,
                             kartica VARCHAR2(15) NOT NULL,
                             CONSTRAINT ZN_zahtj_fk FOREIGN KEY (id_zahtjeva) REFERENCES Zahtjev(id_zahtjev),
                             CONSTRAINT ZP_lokc_fk FOREIGN KEY (id_lokacija) REFERENCES Lokacija(id),
                             CONSTRAINT ZP_card_fk FOREIGN KEY (kartica) REFERENCES KreditnaKartica(brojKartice));

CREATE TABLE objektiArtikal(id_zahtjeva NUMBER NOT NULL,
                     id_artikal NUMBER NOT NULL,
                     CONSTRAINT objA_art_fk FOREIGN KEY (id_artikal) REFERENCES Artikal(id),
                     CONSTRAINT objA_zahtj_fk FOREIGN KEY (id_zahtjeva) REFERENCES Zahtjev(id_zahtjev));
