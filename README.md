# Praise the Sun
![sun](https://github.com/ooad-2016-2017/Tim19-PraiseTheSun/blob/master/sun.jpg)
![pogchamp](https://github.com/ooad-2016-2017/Tim19-PraiseTheSun/blob/master/pogchamp.gif)

## Èlanovi tima
- Azur Taliæ
- Jan Ahmetspahiæ

# Game store
## Opis teme
Industrija igara, opreme i sistema za igranje je u današnje vrijeme iznimno velika. Kako više biznisa
nastaje upravo u tom sektoru i zbog integracije interneta i raèunarskih sistema u svemu što radimo,
postoji potreba pravljenja robusne aplikacije koja funkcioniše kao online prodavnica ovih tipova robe.
Naša tema je upravo jedan takav sistem koji uz osnovnu funkcionalnost prodavnice posjeduje funkcionalnost
foruma za ocjenjivanje artikala i interakcije sa fizièkim prodavnicama koje posjeduje biznis. Osim toga
on daje korisne moguænosti koje se tièu spašavanja historije korisnikove kupnje, zahtjeva za povratak
robe, kupovanja specijalnih èlanstava za buduæe popuste, analize podataka o kupljenim artiklima, te 
preporuka za kupovinu novih artikala bazirana na odraðenoj analizi.

## Procesi

### Registracija korisnika
Korisnik unosi svoje liène podatke i nakon provjere validnosti i nezauzetosti tih podataka dobija pristup
prodavnici. Uz to on sada ima moguænost pristupa svojem profilu te sposobnosti mijenjanja svojih podataka
unutar opcija na profilu.

### Promjena profilnih postavki
Korisnik može nakon ulaska u profil da otvori novu formu pritiskom na dugme settings. Unutar ove forme
on može podnijeti zahtjev za promjenu svojih login informacija, spašenih informacija o kreditnoj kartici,
adresi i sl.

### Pregledanje prodavnice
Korisnik može da pregleda online prodavnicu i vidi osnovne podatke o njima. On može za artikle koji ga 
zainteresuju otvoriti posebnu stranicu koja detaljno prikazuje informacije o tom artiklu, njegovu cijenu,
raspoloživost, te ocjene i komentare koji su ostavili drugi korisnici o tom artiklu. Dalje, on može ubaciti
taj artikal u korpu i kasnije kupiti ili odbaciti.

### Kupovina robe
Nakon što je ispunio korpu robom, korisnik dobiva pregled onoga što je izabrao i informacije o ukupnoj cijeni
te robe. Dalje, za fizièke artikle on ima moguænost odabira lokacije na koju æe biti dostavljeni i tipa dostave
(da li dolazi fizièki u prodavnicu po robu ili prima poštom). Uz to on ima moguænost da ispuni informacije o
kreditnoj kartici koju upotrebljava za kupovinu. Nakon slanja zahtjeva za kupnju, radi se provjera raspoloživosti
sredstava i nakon ustanovljenja validnosti, izvršava se prodaja.

### Kupovanje premium membershipa
Korisnik kroz profil može da pristupi stavci kupovanje premium membershipa ili da pronaðe to kao jedan od artikala
u prodavnici. Nakon ovoga on ima sposobnost dodavanja ovog èlanstva kao svakog drugog artikla. Kupovina èlanstva
korisniku odmah daje popuste na buduæe kupovine.

### Podnošenje zahtjeva za povratak robe
Korisnik može kroz profil pristupiti pregledu svoje kolekcije i kroz to podnijeti zahtjev za povratak robe 
davajuæi usput odgovarajuæi komentar. Ovaj zahtjev procesuira neki od uposlenika i daje odgovarajuæe
obrazloženje kada odobri ili odbije zahtjev. U sluèaju odobrenja, korisnik biva obaviješten o konkretnostima
ovog povratka.

### Administracija korisnika
Admin ima moguænost pristupa sistemu kroz koji može da pregleda korisnike i artikle. Kada otvori profil korisnika
on ima moguænost da tog korisnika banuje. Kada otvori artikal on može da uklanja neodgovarajuæe kritike za taj
artikal.

### Podnošenje zahtjeva
Uposlenici tog biznisa imaju moguænost kroz svoje profile da podnose zahtjeve za razne svrhe kao što su
nabavka robe, premještanje robe sa jednog mjesta na drugo, dodavanje lokacija na sistem mapa(vanjski sistem),
itd. Osim toga drugi uposlenici/admini mogu da odobravaju ili odbijaju ove zahtjeve ili sistem sam može da
to uradi ukoliko se zahtjev tog tipa automatski procesira.

## Funkcionalnosti
- Login/Registracija korisnika u aplikaciji
- Izmjena profilnih podataka
- Kupovanje premium membershipa za buduæe popuste
- Podnošenje zahtjeva za povratak neodgovarajuæe robe
- Pregled kolekcije(prethodno kupljenih artikala kroz prodavnicu)
- Pregled liste ponuðenih artikala i osnovnih informacija o tim artiklima
- Pregled detaljnijih informacija o artiklu, kritika od strane drugih korisnika i sl.
- Dodavanje artikala u korpu i sklanjanje stvari iz te korpe
- Kupovina artikala uz navoðenje informacija o konkretnostima kupovine
- Moguænost kupovanja kreditnom karticom
- Moguænost kupovanja bilo poštom ili rezervisanja artikla na odreðenoj prodajnoj lokaciji ili skladištu te dolazak po artikal
- Dodavanje komentara i ocjena na artikle u prodavnici
- Pregled prodajnih mjesta kroz integrisani sistem mapa
- Pregled preporuèenih artikala na osnovu prethodnih transakcija izvršenih od svih korisnika
- Promovisanje novog materijala na glavnoj stranici
- Sistem za offline prodaju spregnut sa online prodavnicom
- Podnošenje raznih administrativnih zahtjeva(od strane uposlenika) za razlièite fizikalne probleme(premještanje, nabavka robe, i sl.)
- Podnošenje zahtjeva(od strane zaposlenika) koji se tièu aplikacije
- Manuelna obrada zahtjeva od strane drugog uposlenika / admina
- Sistem administracije nad korisnicima i kritikama 
- Sistem za fizikalno skeniranje kreditnih kartica

## Akteri
- Korisnik usluga: To je osoba koja ima moguænosti pregleda, kupovine i povratka robe unutar online prodavnice.
- Uposlenik: On je zadužen za razne administrativne poslove na poslovnim mjestima, te za komunikaciju u vidu
zahtjeva kroz aplikaciju sa drugim poslovnicama i administratorima. Oni u isto vrijeme podnosi i obraðuje odgovarajuæe
zahtjeve ovisno od svojih obaveza.
- Administrator: To je osoba koja je istovremeno uposlenik, ali uz to ima dodatne ovlasti koje se tièu administracije
stranice kroz sklanjanje nepoželjnih(uvredljivih, spam i sl.) komentara te nepoželjnih korisnika.
- Kritièar: Osoba èiji je zadatak da daje ocjene za robu koju prodaje firma. Komentari kritièara su istaknuti i
svrha je da korisnici dobiju mišljenje od osobe koja ima iskustva i kvalificirana je da govori o prednostima i manama
artikala.