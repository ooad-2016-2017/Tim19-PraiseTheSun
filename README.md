# Praise the Sun
![sun](https://github.com/ooad-2016-2017/Tim19-PraiseTheSun/blob/master/sun.jpg)
![pogchamp](https://github.com/ooad-2016-2017/Tim19-PraiseTheSun/blob/master/pogchamp.gif)

## �lanovi tima
- Azur Tali�
- Jan Ahmetspahi�

# Game store
## Opis teme
Industrija igara, opreme i sistema za igranje je u dana�nje vrijeme iznimno velika. Kako vi�e biznisa
nastaje upravo u tom sektoru i zbog integracije interneta i ra�unarskih sistema u svemu �to radimo,
postoji potreba pravljenja robusne aplikacije koja funkcioni�e kao online prodavnica ovih tipova robe.
Na�a tema je upravo jedan takav sistem koji uz osnovnu funkcionalnost prodavnice posjeduje funkcionalnost
foruma za ocjenjivanje artikala i interakcije sa fizi�kim prodavnicama koje posjeduje biznis. Osim toga
on daje korisne mogu�nosti koje se ti�u spa�avanja historije korisnikove kupnje, zahtjeva za povratak
robe, kupovanja specijalnih �lanstava za budu�e popuste, analize podataka o kupljenim artiklima, te 
preporuka za kupovinu novih artikala bazirana na odra�enoj analizi.

## Procesi

### Registracija korisnika
Korisnik unosi svoje li�ne podatke i nakon provjere validnosti i nezauzetosti tih podataka dobija pristup
prodavnici. Uz to on sada ima mogu�nost pristupa svojem profilu te sposobnosti mijenjanja svojih podataka
unutar opcija na profilu.

### Promjena profilnih postavki
Korisnik mo�e nakon ulaska u profil da otvori novu formu pritiskom na dugme settings. Unutar ove forme
on mo�e podnijeti zahtjev za promjenu svojih login informacija, spa�enih informacija o kreditnoj kartici,
adresi i sl.

### Pregledanje prodavnice
Korisnik mo�e da pregleda online prodavnicu i vidi osnovne podatke o njima. On mo�e za artikle koji ga 
zainteresuju otvoriti posebnu stranicu koja detaljno prikazuje informacije o tom artiklu, njegovu cijenu,
raspolo�ivost, te ocjene i komentare koji su ostavili drugi korisnici o tom artiklu. Dalje, on mo�e ubaciti
taj artikal u korpu i kasnije kupiti ili odbaciti.

### Kupovina robe
Nakon �to je ispunio korpu robom, korisnik dobiva pregled onoga �to je izabrao i informacije o ukupnoj cijeni
te robe. Dalje, za fizi�ke artikle on ima mogu�nost odabira lokacije na koju �e biti dostavljeni i tipa dostave
(da li dolazi fizi�ki u prodavnicu po robu ili prima po�tom). Uz to on ima mogu�nost da ispuni informacije o
kreditnoj kartici koju upotrebljava za kupovinu. Nakon slanja zahtjeva za kupnju, radi se provjera raspolo�ivosti
sredstava i nakon ustanovljenja validnosti, izvr�ava se prodaja.

### Kupovanje premium membershipa
Korisnik kroz profil mo�e da pristupi stavci kupovanje premium membershipa ili da prona�e to kao jedan od artikala
u prodavnici. Nakon ovoga on ima sposobnost dodavanja ovog �lanstva kao svakog drugog artikla. Kupovina �lanstva
korisniku odmah daje popuste na budu�e kupovine.

### Podno�enje zahtjeva za povratak robe
Korisnik mo�e kroz profil pristupiti pregledu svoje kolekcije i kroz to podnijeti zahtjev za povratak robe 
davaju�i usput odgovaraju�i komentar. Ovaj zahtjev procesuira neki od uposlenika i daje odgovaraju�e
obrazlo�enje kada odobri ili odbije zahtjev. U slu�aju odobrenja, korisnik biva obavije�ten o konkretnostima
ovog povratka.

### Administracija korisnika
Admin ima mogu�nost pristupa sistemu kroz koji mo�e da pregleda korisnike i artikle. Kada otvori profil korisnika
on ima mogu�nost da tog korisnika banuje. Kada otvori artikal on mo�e da uklanja neodgovaraju�e kritike za taj
artikal.

### Podno�enje zahtjeva
Uposlenici tog biznisa imaju mogu�nost kroz svoje profile da podnose zahtjeve za razne svrhe kao �to su
nabavka robe, premje�tanje robe sa jednog mjesta na drugo, dodavanje lokacija na sistem mapa(vanjski sistem),
itd. Osim toga drugi uposlenici/admini mogu da odobravaju ili odbijaju ove zahtjeve ili sistem sam mo�e da
to uradi ukoliko se zahtjev tog tipa automatski procesira.

## Funkcionalnosti
- Login/Registracija korisnika u aplikaciji
- Izmjena profilnih podataka
- Kupovanje premium membershipa za budu�e popuste
- Podno�enje zahtjeva za povratak neodgovaraju�e robe
- Pregled kolekcije(prethodno kupljenih artikala kroz prodavnicu)
- Pregled liste ponu�enih artikala i osnovnih informacija o tim artiklima
- Pregled detaljnijih informacija o artiklu, kritika od strane drugih korisnika i sl.
- Dodavanje artikala u korpu i sklanjanje stvari iz te korpe
- Kupovina artikala uz navo�enje informacija o konkretnostima kupovine
- Mogu�nost kupovanja kreditnom karticom
- Mogu�nost kupovanja bilo po�tom ili rezervisanja artikla na odre�enoj prodajnoj lokaciji ili skladi�tu te dolazak po artikal
- Dodavanje komentara i ocjena na artikle u prodavnici
- Pregled prodajnih mjesta kroz integrisani sistem mapa
- Pregled preporu�enih artikala na osnovu prethodnih transakcija izvr�enih od svih korisnika
- Promovisanje novog materijala na glavnoj stranici
- Sistem za offline prodaju spregnut sa online prodavnicom
- Podno�enje raznih administrativnih zahtjeva(od strane uposlenika) za razli�ite fizikalne probleme(premje�tanje, nabavka robe, i sl.)
- Podno�enje zahtjeva(od strane zaposlenika) koji se ti�u aplikacije
- Manuelna obrada zahtjeva od strane drugog uposlenika / admina
- Sistem administracije nad korisnicima i kritikama 
- Sistem za fizikalno skeniranje kreditnih kartica

## Akteri
- Korisnik usluga: To je osoba koja ima mogu�nosti pregleda, kupovine i povratka robe unutar online prodavnice.
- Uposlenik: On je zadu�en za razne administrativne poslove na poslovnim mjestima, te za komunikaciju u vidu
zahtjeva kroz aplikaciju sa drugim poslovnicama i administratorima. Oni u isto vrijeme podnosi i obra�uje odgovaraju�e
zahtjeve ovisno od svojih obaveza.
- Administrator: To je osoba koja je istovremeno uposlenik, ali uz to ima dodatne ovlasti koje se ti�u administracije
stranice kroz sklanjanje nepo�eljnih(uvredljivih, spam i sl.) komentara te nepo�eljnih korisnika.
- Kriti�ar: Osoba �iji je zadatak da daje ocjene za robu koju prodaje firma. Komentari kriti�ara su istaknuti i
svrha je da korisnici dobiju mi�ljenje od osobe koja ima iskustva i kvalificirana je da govori o prednostima i manama
artikala.