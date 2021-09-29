# Követelmény specifikáció

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

## Rendszerre vonatkozó törvények

### Általános Információk
Az Alkalmazásnak a használatát és a hozzáférését megelőzi az alkalmazandó jogszabályok és a jelen Felhasználási Feltételek
és Adatkezelési tájékoztatóknak az elolvasása és értelmezése. Amennyiben az alkalmazást letöltők vagy használók (a későbbiekben: a Felhasználók)
elfogadják és teljesítik az imént említett Felhasználási Feltételeket abban az esetben az alkalmazás használata engedélyezett. Amennyiben ezen
Adatkezelési Tájékoztatót és a Felhasználói Feltételek nem fogadják el, abban az esetben a Felhasználó nem jogosult arra hogy az alkalmazást használhassa.

A jelenlegi Felhasználási Feltételekre a magyar jog az irányadó, tekintet nélkül a nemzetközi magánjog előírásaira. Az Alkalmazás Felhasználói
kifejezetten hozzájárulnak ahhoz, hogy a jogvitákra a magyar hatóságoknak és bíróságoknak legyen kizárólags joghatóságuk a magyar jog alapján.



### Szellemi tulajdon

Az Alkalmazás és valamennyi kapcsolódó védjegy, szerzői jogi alkotás és egyéb - akár bejegyzett, akár be nem jegyzett - szellemi tulajdon
(a továbbiakban együttesen: Szellemi Tulajdon) tulajdonosa az EKE és/vagy EKE Szolgáltató, valamint az alkalmazáshoz kedvezményt nyújtó
partnerek. A Felhasználók az Alkalmazást a Szellemi Tulajdon maximális tiszteletben tartásával jogosultak használni. 

A Szellemi Tulajdon kiterjed különösen, de nem kizárólagosan valamennyi szoftverre, logóra, márkajelre, márkanévre, fényképre, szövegre, grafikára, adatbázisra.
A Szellemi Tulajdonnak tilos bárminemű megsértése, bitorlása, másolása, átdolgozása és tilos azt bármilyen egyéb módon megsérteni,
azt jogosulatlanul felhasználni, továbbadni, megterhelni, azzal bármilyen módon rendelkezni, visszaélni. 

Ezen szabályok megsértése az Alkalmazás használati lehetőségeinek azonnali hatályú megszüntetése mellett a megfelelő jogi lépések megtételét
– beleértve esetleges büntetőjogi lépések megtételét is – vonja maga után a Felhasználóval, más jogsértő személlyel szemben a Tulajdonos és/vagy a 
Szellemi Tulajdon egyéb jogosultjai által.


### Használat









### Felelősségi szabályok















### Technikai követelmények












### Garancia és kártérítés












### Egyéb rendelkezések













### Kapcsolat




### Jelenlegi üzleti folyamatok





### Igényelt üzleti folyamatok




### Követelménylista














### Fogalomtár
-
-
-
-
-
-
-

