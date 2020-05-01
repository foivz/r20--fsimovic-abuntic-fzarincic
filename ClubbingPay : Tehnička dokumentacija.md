# ClubbingPay : Tehnička dokumentacija
Članovi tima:
* Ante Buntić
* Fran Šimović
* Filip Žarinčić
## Uvod
ClubbingPay je desktop aplikacija koja služi za izdavanje računa i praćenje rada u noćnim klubovima. U aplikaciji se zapolenik dodaje od strane administratora odnosno nadređenog. Svaki zaposlenik ima vlastitu indentifikacijsku karticu koja mu služi za prijavu u sustav, te nakon toga slijedi izdavanje računa. Svi računi se bilježe u centralizitanoj bazi podataka. Aplikacija sadržavi statistiku u obliku grafova za praćenje rada kluba i stanja zaliha, koja omogućuje naručivanje artikala.

## ERA dijagram
U nastavku se nalazi ERA model za naš projekt koji će biti implementiran na dodjeljenom serveru kao MS SQL baza podataka.
![ERA dijagram](https://i.imgur.com/duXgfO2.png)
ERA dijagram sadrži sljedeće entitete: 

* **Primka** - dokument koji se kreira kod zaprimanja robe na skladište.  
* **StavkaPrimke** - slabi entitet koji povezuje primku i artikl.  
* **Artikl** - sadrži popis svih artikala sa količinom koja postoji.  
* **KategorijaArtikla** - šifrarnik kategorija artikala.  
* **Račun** - dokument koji se kreira kod prodaje robe.  
* **Stavka računa** - slabi entitet koji povezuje entitete račun i artikl.  
* **Narudžbenica** - dokument koji se kreira kod narudžbe robe.  
* **Stavka narudžbenice** - slabi entitet koji povezuje entitete narudžbenica i artikl.  
* **Zaposlenik** - sadrži sve informacije o zaposleniku.  

## Dijagrami slučajeva korištenja
Dijagram slučajeva korištenja koji objedinjuje sve slučajeve korištenja. Imamo zaposlenike koji su zapravo korisnici aplikacije te specijalizaciju zaposlenika koju predstavlja administrator. Administrator bi trebao imati mogućnosti koje nema obični zaposlenik. Prije ikakve aktivnosti potrebna je prijava koja je uključena u sve ostale slučajeve korištenja. Također određeni slučajevi korištenja su prošireni drugim slučajevima korištenja
![Usecase dijagram](https://i.imgur.com/pe7dswD.jpg)

Dijagram slučajeva korištenja - Ante Buntić:
![Usecase dijagram - Ante Buntić](https://i.imgur.com/cHsTgxO.png)

Dijagram slučajeva korištenja - Fran Šimović:
![Usecase dijagram - Fran Šimović](https://i.imgur.com/EKkeccT.jpg)

Dijagram slučajeva korištenja - Filip Žarinčić:
![Usecase dijagram - Filip Žarinčić](https://i.imgur.com/d7yFe3l.jpg)

