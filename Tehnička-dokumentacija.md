# Slučajevi korištenja
### Use Case Diagram 
<img src="https://i.ibb.co/ThkWmPh/Use-case-dijagram.jpg" width="700" />

Prema dijagramu korisnici sustava su Korisnik, Administrator i Zaposlenik. Na temelju njihovih zahtjeva stvorili smo sljedeće dijagrame korištenja: Registracija i prijava u sustav, Dodavanje zaposlenika, Uklanjanje zaposlenika, Mijenjanje prava zaposlenika, Lista proizvodam, Narudžba za servis, Pregled proizvoda, Unos geodetskih uređaja, Ažuriranje geodetskih uređaja i Narudžba proizvoda.
Aplikacija ima već predefiniranog Administratora koji ima mogućnost dodati zaposlenika u organizacijsku jedinicu servisiranja. Tako ga može i ukloniti te promjeniti prava u aplikaciji. Zaposlenik nije u mogućnosti samostalno se registrirati u aplikaciju to već radi Administrator. Unos i ažuriranje geodetskih uređaja će se provoditi u ulozi zaposlenika kao što i naručivanje proizvoda te odobravanje narudžbe. Kupac može preko aplikacije predbilježiti svoj uređaj za servis, kod unosa kvara aplikacija nudi već najčešće kvarove i sl. Kupac dobiva odmah slobodne termine kad može donijeti uređaj. Isto tako ima mogoćnost pregleda svih dostupnih uređaja, dodatnog pribora i softvera. 


# Dijagrami slijeda
### Dijagram slijeda "Registracija i prijava u sustav"
<img src="https://i.ibb.co/9HVkV34/Registracija-i-prijava.jpg" width="700" />

Da bi se koristila aplikacija svaki korisnik se prvo mora registrirati u sustav. Korisnik šalje zahtjev za registraciju te mu se prikazuje forma za registraciju u sustav. Kako bi se uspješno registrirao u sustav potrebno je unijeti svoje podatke kao što su ime, prezime, korisničko ime, lozinka... Ukoliko nešto nije popunio javlja se greška i vraća ga opet na formu za registraciju da popuni nedostajaće polje. Kada se korisnik uspješno registrirao vraća se na početnu formu gdje se nalazi forma za prijavu korisnika. Korisnik upiše svoje korisničko ime i lozinku koju je naveo u registraciji. Ako korisnik unese pogrešne podatke javlja se greška i vraća ga na prijavu. Kad je ispravno unio svoje podatke korisnik može koristiti aplikaciju.

### Dijagram slijeda "Unos zaposlenika i uređivanje njegovih prava"
<img src="https://i.ibb.co/R2QNm8t/Unos-i-ure-ivanje-zaposlenika.jpg" width="700" />

Korisnik, koji ima prava administratora u aplikaciju se prijavljuje sa svojim korisničkim imenom i lozinkom. Odabire formu za unos zaposlenika te se mu otvora obrazac za registraciju korisnika. Kada je uspješno popunio sva polja zaposlenik se sprema u bazu podataka. Administrator vidi popis svih zaposlenih s pripadnim pravima. Ima mogućnost dodati i promjeniti prava svakog zaposlenik te ukloniti zaposlenika. 

### Dijagram slijeda "Unos i ažuriranje geodetskih uređaja"
<img src="https://image.ibb.co/nRuwbx/dslijeda_unos.png" width="700" />

Zaposlenik najprije odabire formu za unos, inicijalizira se objekt i prikazuje se forma za unos. Zatim se prikazuju postojeći unosi koji se nalaze u bazi podataka. Zaposlenik tada može odabrati unos novih geodetskih uređaja ili brisanje postojećih. Ako se izvršava novi unos, zaposlenik unosi podatke i aplikacija ih prenosi modulu za unos. Zatim se izvršava SQL upit za unos prosljeđenih podataka u bazu. Kad je unos izvršen, zaposlenik se obavještava o uspješnom unosu. Zahtjev za brisanje unosa izvršava se na sličan način kao i unos novog zapisa, samo što kod brisanja zaposlenik šalje podatke o unosu kojeg želi izbrisati. Odabirom opcije za izlaz, šalje se zahtjev za izlaz, odnosno zatvaranje forme. Na kraju se objekt dealocira.  

### Dijagram slijeda "Naručivanje proizvoda te odobravanje narudžbe"
<img src="https://image.ibb.co/eWaVoc/Narudzba.png" width="700" />

Prilikom kreiranja novih narudžbi kupac najprije odabire formu za narudžbu. Zatim se prikazuje forma za kreiranje narudžbe i iz baze podataka dohvaća se lista artikla. Nakon toga kupac odabire artikle. Stavke se dodaju na narudžbu i pohranjuju se. Kad su unešeni željeni artikli, narudžba se potvrđuje te se sprema u bazu. Na kraju se forma zatvara i objekt se dealocira.

# Dijagrami aktivnosti
### Dijagram aktivnosti „Registracija i prijava u sustav“
<img src="https://i.ibb.co/svYyyFx/Registracija-i-prijava-u-sustav-AD.jpg" width="700" />

Kako bi se započelo korištenje aplikacije „GeoApp“ potrebno je na početku obaviti registraciju u sustav. Iz dijagrama aktivnosti „Registracija i prijava u sustav“ vidljivo je da se počinje od korisnika aplikacije. Korisnik postavlja zahtjev za registraciju u sustav. Inicijalizira se forma za registraciju. Kod registracije je potrebno unjeti odgovarajuće podatke. Popunjava se baza podataka sa unjetim podacima i vraća korisnika na formu za prijavu. Kod prijave je potrebno unjeti odgovarajuće podatke. Ukoliko je uneseno pogreško korisničko ime ili lozinka prikazuje se poruka o greški prilikom prijave. Ukoliko je sve u redu i korisnik može koristiti aplikaciju može se preći na forme za unos geodetskih uređaja

### Dijagram aktivnosti „Unos i ažuriranje geodetskih uređaja“
<img src="https://image.ibb.co/bQVAMx/Unos_i_ure_ivanje_zaposlenika_AD.jpg" width="700" />

Dijagram aktivnosti „Unos zaposlenika i uređivanje njegovih prava“ započinje odabirom forme za unos zaposlenika. Inicijalizira se forma za unos zaposlenika te se prikaže forma gdje se upisuju podaci zaposlenika. Nakon što se unese zaposlenik u bazu podataka odlazi se u formu za dodavanje/mijenjanje prava zaposlenika. Gdje Administrator može mijenjati/dati željeno pravo zaposleniku. S time je proces završen i vraća se na početnu formu.

# ERA model
![ERA](https://image.ibb.co/mtHw6x/ERA.png)

ERA model sastoji se od osam entiteta. To su: Korisnik, Uloga, Ovlasti, Odobravanje narudžbe, Narudžba, Artikl, Uređaj_Servis i Stavke narudžbe. U tablici korisnik nalaze se korisnici aplikacije i oni su opisani sljedećim atributima: Uloga, Ime, Prezime, OIB, Adresa, E-mail, Broj telefona, Korisničko ime i lozinka. Svaki korisnik ima ulogu. Uloga ima atribute: Ovlasti, Naziv i Opis. Uloge mogu biti: Administrator, Zaposlenik i Kupac. Svaka uloga ima ovlasti. U tablici ovlasti nalaze se sljedeći atributi: Unos artikla, Ažuriranje artikla, Brisanje artikla i Odobravanje narudžbe. Svi atributi imaju tip bit, koji poprima vrijednost 1 ako uloga ima određenu ovlast, ili 0 ako uloga nema određenu ovlast. U tablici Artikli spremaju se geodestki uređaji i oprema. Atributi su: Naziv, Opis, Proizvođač, Cijena, Serijski broj. Stavke narudžbe spremaju se u tablici Stavke narudžbe, čiji atributi su: ID narudžbe, uređaj koji je servisiran ili Artikl i Količina. U tablici Narudžba nalazi se ID korisnika, Datum i Vrijeme narudžbe. Tablica Uređaj_Servis sadrži informacije u uređaju koji je donešen na servis. Atributi tablice su: ID korisnika, Naziv, Model, Proizvođač, Serijski broj, Opis kvara i QR kod. U tablici Odobravanje narudžbe nalazi se ID korisnika koji odobrava narudžbu i ID narudžbe koja se odobrava.