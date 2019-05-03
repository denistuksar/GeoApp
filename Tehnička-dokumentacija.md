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

# Dijagrami aktivnosti
### Dijagram aktivnosti „Registracija i prijava u sustav“
<img src="https://i.ibb.co/svYyyFx/Registracija-i-prijava-u-sustav-AD.jpg" width="700" />

Kako bi se započelo korištenje aplikacije „GeoApp“ potrebno je na početku obaviti registraciju u sustav. Iz dijagrama aktivnosti „Registracija i prijava u sustav“ vidljivo je da se počinje od korisnika aplikacije. Korisnik postavlja zahtjev za registraciju u sustav. Inicijalizira se forma za registraciju. Kod registracije je potrebno unjeti odgovarajuće podatke. Popunjava se baza podataka sa unjetim podacima i vraća korisnika na formu za prijavu. Kod prijave je potrebno unjeti odgovarajuće podatke. Ukoliko je uneseno pogreško korisničko ime ili lozinka prikazuje se poruka o greški prilikom prijave. Ukoliko je sve u redu i korisnik može koristiti aplikaciju može se preći na forme za unos geodetskih uređaja