# Követelmény specifikáció

### Áttekintés

Az alklamazásunk árusítás és tárolás céljából készült. Rendelkezik egy bejelentkeztető felülettel amelyben
a jogosult személy be tud lépni az alkalmazás telepítését követően. A Szűrőfelület a validálás után megjelenik
és az adott feltételek/pontok szerint lehet szűrni az alkalmazásban található adatok igénybevételével.


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

Kivonat az 1999. évi LXXVI. szerzői jogi törvényből:
	<p>*1.§* 	(2) Szerzői jogi védelem alá tartozik – függetlenül attól, hogy e törvény megnevezi-e – 
				az irodalom, a tudomány és a művészet minden alkotása. Ilyen alkotásnak minősül különösen: (...)</p>
			<p> c) a *számítógépi programalkotás és a hozzá tartozó dokumentáció (a továbbiakban: szoftver) akár forráskódban, akár tárgykódban vagy bármilyen más formában* rögzített minden fajtája, ideértve a felhasználói programot és az operációs rendszert is.</p>
	(...) 	<p>(3) A szerzői jogi védelem az alkotást a szerző szellemi tevékenységéből fakadó egyéni, eredeti jellege alapján illeti meg. A védelem nem függ mennyiségi, minőségi, esztétikai jellemzőktől vagy az alkotás színvonalára vonatkozó értékítélettől.</p>
	(...)
	*4.$* 	(1) A szerzői jog *azt illeti, aki a művet megalkotta* (szerző).
			(2) *Szerzői jogi védelem* alatt áll – az eredeti mű szerzőjét megillető jogok sérelme nélkül – más szerző művének átdolgozása, feldolgozása vagy fordítása is, ha annak egyéni, eredeti jellege van.
	(...)
	*5.§* 	(1) Több szerző közös művére, ha annak részei nem használhatók fel önállóan, a szerzői jog együttesen és – kétség esetén – egyenlő arányban illeti meg a szerzőtársakat; a szerzői jog megsértése ellen azonban bármelyik szerzőtárs önállóan is felléphet. (...)
	*13.§* 		A szerző személyhez fűződő jogát sérti művének a becsületére vagy jóhírnevére sérelmes mindenfajta eltorzítása, megcsonkítása, megváltoztatása és a művel kapcsolatos más ilyen jellegű visszaélés.(...)
	*42.§* 	(1) Felhasználási szerződés alapján a szerző engedélyt ad művének a felhasználására, a felhasználó pedig köteles ennek fejében díjat fizetni. (...)
	*59.§* 	(1) Eltérő megállapodás hiányában a szerző kizárólagos joga nem terjed ki a többszörözésre, az átdolgozásra, a feldolgozásra, a fordításra, a szoftver bármely más módosítására – ideértve a hiba kijavítását is –, valamint ezek eredményének többszörözésére annyiban, amennyiben e felhasználási cselekményeket a szoftvert jogszerűen megszerző személy a szoftver rendeltetésével összhangban végzi.
			(2) A felhasználási szerződésben sem zárható ki, hogy a felhasználó egy biztonsági másolatot készíthessen a szoftverről, ha az a felhasználáshoz szükséges.
			(3) Aki a szoftver valamely példányának felhasználására jogosult, a szerző engedélye nélkül is megfigyelheti és tanulmányozhatja a szoftver működését, továbbá kipróbálhatja a szoftvert annak betáplálása, képernyőn való megjelenítése, futtatása, továbbítása vagy tárolása során abból a célból, hogy a szoftver valamely elemének alapjául szolgáló elgondolást vagy elvet megismerje.
			(Forrás: NJT)

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

Az Alkalmazás Felhasználói 18 éven felüli ismeretekkel rendelkező személyek lehetnek. Az Alkalmazás díjmentesen vehető igénybe,
Az Alkalmazás letöltéséért és használatáért az adatforgalmat biztosító szolgáltató külön díjat számíthat fel. Az ezzel kapcsolatos esetlegesen
felmerülő költségek a Felhasználót terhelik.

### Felelősségi szabályok

Az Alkalmazáshoz kapcsolódó adatbázis módosítása kizárólag az Üzemeltető által, illetve az Alkalmazást üzemeltető webkiszolgálón keresztül
lehetséges. Bármilyen külső, nem az Alkalmazás részeként elérhető eszközzel történő beavatkozás a Felhasználó azonnali kizárását eredményezi.

Ha a Felhasználó az Alkalmazást használat közben bezárja, vagy ha a kapcsolat (bármely okból) megszakad a kiszolgáló webhelyével,
abban az esetben az adatok elvesztéséért a Tulajdonos semmilyen felelősséget nem vállal. A Tulajdonos és az Üzemeltető a rendelkezésére álló
eszközökkel biztosítja, hogy az Alkalmazás használata technikai szempontból biztonságosnak minősüljön.

Az Alkalmazáshoz való csatlakozás miatt bekövetkező károkért, az internetes hálózat esetleges üzemkimaradásából, 
az elérési út hibájából, bármely nem várt technikai hibából eredő adatvesztésért, vírusból, vagy más károkért a Tulajdonos nem felelős. 
A Felhasználóknak minden esetben fel kell mérniük, hogy rendelkeznek-e az Alkalmazás használatához szükséges ismeretekkel, 
technikai követelményekkel és teljesítményekkel.
A Tulajdonos fenntartja magának a jogot arra, hogy amennyiben valamely Felhasználó részéről bármilyen manipulációt, tömegesen generált letöltést,
illetve az Alkalmazás szellemével bármilyen módon összeférhetetlen vagy azt sértő magatartást tapasztal, 
vagy ennek megalapozott gyanúja felmerül, úgy a Felhasználót azonnali hatállyal kizárja az Alkalmazás felhasználói köréből.




### Technikai követelmények
Az Alkalmazás használatához szükséges technikai feltételek: Windows 10 operációs rendszer valamint minimum 400 MB szabad tárhely. 
A technikai feltételeket az Alkalmazás letöltéséhez és használatához a Felhasználónak kell teljesítenie. A technikai feltételek nem teljesüléséért a Tulajdonos nem vonható felelősségre.
Ugyanígy nem vonható felelősségre a Tulajdonos az Alkalmazás használatából a készüléken bekövetkező adatvesztésért, meghibásodásért. 
A Tulajdonos kizár minden kártérítési felelősséget az Alkalmazáshoz csatlakozó minden külső szerver által nyújtott
vagy megjelenített adattal, információval kapcsolatban is.

Az Alkalmazás telepítéssel vehető használatba.


### Garancia és kártérítés

Az Alkalmazás használatához a felhasználói oldalon szükséges – fent meghatározott vagy bármely egyéb - technikai feltételeket a Felhasználónak kell biztosítania, teljesítenie.
Ezen technikai feltételek nem teljesüléséért a Tulajdonos nem vonható felelősségre. Ugyanígy nem vonható felelősségre a Tulajdonos az Alkalmazás használatából adódóan, 
a készüléken bekövetkező adatvesztésért, meghibásodásért. A Tulajdonos kizár minden kártérítési felelősséget az Alkalmazáshoz csatlakozó minden külső szoftver által nyújtott
vagy megjelenített adattal, információval kapcsolatban. A Tulajdonos nem vállal garanciát az Alkalmazás megszakításmentes működéséért, 
valamint vis major hibákért. Az ebből eredő adatvesztésért, tartalom vesztésért a Tulajdonos szintén nem tartozik kártérítési felelősséggel.



### Egyéb rendelkezések

Jelen Felhasználási Feltételekben nem szabályozott kérdésekben a hatályos jogszabályok – különösen,
de nem kizárólagosan a Polgári Törvénykönyvről szóló 2013. évi V. törvény, az Európai Parlament és Tanács 2016. április 27-i (EU) 2016/679 Rendelete
a természetes személyeknek a személyes adatok kezelése tekintetében történő védelméről és az ilyen adatok szabad áramlásáról, valamint a 95/46/EK 
irányelv hatályon kívül helyezéséről, az információs önrendelkezési jogról és az információ szabadságról szóló 2011. évi CXII. törvény, a szerzői jogról
szóló 1999. évi LXXVI. törvény, valamint az elektronikus kereskedelmi szolgáltatások, valamint az információs társadalommal összefüggő szolgáltatások
egyes kérdéseiről szóló 2001. évi CVIII. törvény – rendelkezései az irányadóak.


### Kapcsolat
Az Alkalmazás üzemeltetését és támogatását az Üzemeltető végzi munkanapokon, 8:00 és 16:00 között
Az Alkalmazás működésével kapcsolatban a fejlesztők közös NTBSLHK@gmail.com e-mail címére küldheti a kérdéseit, amelyre
az Üzemeltető a fentebb említett időszakban válaszol.


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

