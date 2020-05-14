PROJEKTNA DOKUMENTACIJA
---------------------------
* RAZVOJNI PRISTUP - Ok, odabran vodopadni model.
* PROJEKTNI PLAN - Ok, relativno dobro prati faze modela.
* PONUDA - 

TEHNIČKA DOKUMENTACIJA
---------------------------
* SRS - Nije po IEEE SRS-u.
* USE CASE - Previše nepotrebnih include-ova i extendova. Npr. zašto bi evidenciju zaposlenika proširivalo kreiranje identifikacijske kartice.
* DIJAGRAMI AKTIVNOSTI I SLIJEDA - nemojte opisivati više funkcionalnosti na istom dijagramu slijeda. Možete maknuti bazu podataka sa dijagrama slijeda i aktivnosti (osim ako ne pozivate nekakvu procedure ili trigger).
* DIJAGRAM KLASA - Veza između GenericRepository i interface-a IGenericRepository nije nasljeđivanje nego realizacija. Također, ClubbingPayDbContext ne bi trebao realizirati IGenericRepository. Umjesto toga IGenericRepository sadrži DbContext. Provjerite korištenje kompozicija na dijagramu. Kompozicija je prejaka veza za odnos forme i neke klase poslovne logike. Npr. sučelje IPrimkarepository ne definira niti jednu metodu/svojstvo.
* ERA DIJAGRAM - podaci dobavljača trebaju ići u tablicu dobavljači a ne u primke i narudžbenice. Što je datum dospijeća za primku? Primka može imati 1 ili više, a ne 0 ili više stavki. Pogrešan smjer veze između Narudžbenice i StavkeNarudžbe.

IMPLEMENTACIJA
---------------------------
Samo kreiran projekt

OSTALI ARTEFAKTI
---------------------------


BODOVI
----------------
10 bodova.
