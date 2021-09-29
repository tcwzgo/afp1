### Áttekintés





### Jelenlegi helyzet
 
Videojátékokkal foglalkozó boltunkban megnőtt a beérkező megrendelések, megkeresések száma,
ami a papíron történő leltárazást teszi egyre komplikáltabbá, időigényesebbé. A konkurens cégek is
a korábbiakban implementáltattak hasonló rendszereket, amelyek hosszútávon tekintve beválni látszanak,
a piacon úttörővé, sőt egyenesen követendővé nőtték ki magukat.
A cégvezetés számára a jelenlegi helyzet modernnek, mitöbb környezetkímélőnek 
egyáltalán nem mondható, ugyanis még mindig papírformán	vezetjük a termékeink forgalmát.

### Vágyálomrendszer

Szükségessé vált egy offline szoftveres informatikai rendszer kiépítése, amely lehetővé teszi, hogy
a megérkező termékekhez megfelelő információkat rögzíteni tudjunk, így a későbbiekben lépést 
tudjunk tartani a játékipar nemcsak régebbi, de legújabb megjelenéseivel is.
Nem titkolt célunk, hogy a többi cég által kitaposott úton, immáron kódban implementált,
szoftveres megoldásokkal is nyitni tudjunk egy szélesebb piac felé. 
	- Maga a szoftver egy leltárprogram videojátékokra kidolgozott implementációja.
	- Szükséges, hogy az applikáció akkor is funkcionáljon, amikor a raktár egyébként nem üzemel (bárhonnan el tudjuk indítani).
	- Legyen belépési feltétel, kötelező megadni egy felhasználónevet.
	- Tartalmaz egy bejelentkező felületet, amely természetesen csak akkor enged betekintést, amikor validáltuk a bejelentkezést.
	- Ismeretlen NE tudjon hozzáférni!
	- Lehessen akkor is hozzáférni, ha az adatbázis/adatbázis-szerver nem működik, "sima" tagolt fájlból is legyen képes adatot megjeleníteni.
	- Tudjuk nyomon követni a rendszeridőt (naplózás szempontjából fontos)
	- Jó lenne, ha adatbázis-kapcsolatot használhatnánk a későbbiekben a játékok tárolására.
	- Egyelőre szimpla fájlos megoldás is megteszi.
	- Jó lenne, ha meg tudnánk nézni esetleg a belépések időpontjait naplózás szempontjából.

### Elvárások
 
Egy leltárazó program ahol, tudunk módosítani a státuszukon (készleten, eladva, elfogadásra vár), 
lapozás funkció (görgetéssel előre-hátra lapoz) szűrés platform, 
ár alapján keresés cikkszám, név alapján szükség lesz tervezett takarításokra is, 
az elkelt játékokat pl. vétel után egy hónappal már nincs értelme tárolni,csak számlákon

## Követelménylista

|    Modul    	| ID |       Név        		|                                                        Kifejtés                                                        		|
|-------------	|----|--------------------------|-------------------------------------------------------------------------------------------------------------------------------|
| Authority 	| K1 | Bejelentkező felület		| Van egy minimális bejelentkeztető felület, amin felhasználónév + jelszó kombinációval be tudunk lépni (egyfelhasználós)		|
| Interface   	| K2 | Felhasználói felület   	| Ne legyen túlgondolva, pár gomb felvételre, törlésre, módosításra.												   			|
| Datastore 	| K3 | Adattárolási mód 		| Férjen el minimális tárhelyen (kis cég, kis tárhely).																			|
| Datastore 	| K4 | Tervezett karbantartás	| Előző pontból következik, időszakosan pucoljuk is a tárhelyet (fájlból a felesleges rekordok eltávolítása)    				|
| Datastore 	| K5 | Adatbázis        		| Itt tároljuk a játék nevét, platformját , árát, megjelenés dátumát, beérkezés dátumát, cikkszámát, darabszámát, Steam-kulcsát |
| Interface   	| L1 | Keresés          		| Lehetőleg tudjon a felhasználó keresni termékekre minimum név alapján. 														|
| Interface   	| L2 | Szűrés      				| Lehetőleg tudjon a felhasználó szűrni termékekre ár, platformok alapján.                                                      |
| Interface 	| L3 | Rendezés         		| A felhasználó tudjon rendezni ár, név, cikkszám szerint.                              										|
| Feature   	| F1 | Rendszeridő      		| Mutasson rendszeridőt a képernyő valamely kevésbé feltűnő részén.								 								|

### Rendszerre vonatkozó törvények