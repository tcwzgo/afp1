# Funkcionális specifikáció

### Áttekintés

A funkcionális specifikáció	folyamán konstatáljuk, hogy konkrétan milyen célokra, 
milyen felhasználási területre készül a termékünk, az általunk fejlesztett szoftver.
A követelményspecifikációban lefektetett kritériumoknak megfeleltetjük a szoftver
jövőbeli funkcióit, amelyeket természetesen a megrendelőnk tudására is adunk.
Ezek alapján a megrendelő képes lesz saját legjobb belátása szerint eldönteni,
szerződik-e kis csapatunkkal a termék kidolgozásának, tesztelési fázisának, 
végül annak értékesítésének, átadásának idejére, avagy nem tart igényt rá.

### Jelenlegi helyzet

Videojátékokkal foglalkozó boltunkban megnőtt a beérkező megrendelések, megkeresések száma,
ami a papíron történő leltárazást teszi egyre komplikáltabbá, időigényesebbé.

### Vágyálom rendszer

- Kell egy adatbázis a háttér adatoknak
- Grafikus felület -> WinForm App
- Szűrők, a termékek egyesével ezek szerint kilistázva vagy összeszámolva (pl.: mennyi rpg játék van)
- Adatbázis implementációja: Fájlban (xls, txt, csv, stb...)
- Fel tudunk venni termékeket ( játéknév, platformok, ár, megjelenés dátuma, beérkezés dátuma, cikkszám, darabszám, Steam-kulcs (ha van) ) --> ezek már kvázi adatbázis-mezők

### Elvárások

Egy leltárazó program ahol, tudunk módosítani a státuszukon (készleten, eladva, elfogadásra vár), 
lapozás funkció (görgetéssel előre-hátra lapoz) szűrés platform, 
ár alapján keresés cikkszám, név alapján szükség lesz tervezett takarításokra is, 
az elkelt játékokat pl. vétel után egy hónappal már nincs értelme tárolni,csak számlákon

### A rendszer céljai és nem céljai

Projektünk egy leltározó szoftvert valósít meg (hasonló mint például egy SAP). 
Ebben tudunk szűrni többféle feltétel szerint, 
mint pl.: idő, zsáner, ár, platform, megjelenés dátuma, cikkszám. 
A program *nem* egy webshop-ként funkcionál tehát nem valósítunk meg benne pl.: kosár funkciót/vásárlás funkciót.
Rendszerünk célja továbbá, hogy legyen letisztult, gyors és hatékony a fentebb definiált rutinokban!

### Jelenlegi üzleti folyamatok modellje
A követelményspecifikációban kifejtett elvek teljes mértékben érvényesülnek ezen dokumentum soraiban is.
A megfelelő sorok megtalálhatók a másik dokumentum ugyanezen elnevezésű fejezetében 
(értsd: Jelenlegi üzleti folyamatok, 164.sortól kezdődően)

### Igényelt üzleti folyamatok modellje
A követelményspecifikációban kifejtett elvek teljes mértékben érvényesülnek ezen dokumentum soraiban is.
A megfelelő sorok megtalálhatók a másik dokumentum ugyanezen elnevezésű fejezetében 
(értsd: Igényelt üzleti folyamatok, 171.sortól kezdődően)

### Követelménylista

A követelményspecifikációban taglaltak szerint fogunk eljárni a tervezés során.
Szigorúan betartjuk a felénk benyújtott követelményeket, amennyiben a szerződés megköttetik.
Ezen elvektől bármilyen formájú eltérés esetén az Ügyfélnek jogában áll panasszal fordulni hozzánk.
Ugyanakkor fontos azt is megemlítenünk, hogy a fejlesztő csapatnak is jogában áll ezen elvekre hivatkozva fellebbezni a vevő félnél.



### Használati esetek (use-case)
A felhasználónak elsőnek be kell jelentkezni amennyiben tudatában van a rendszernek a validáló adataival abban az esetben
a belépés engedélyezett, amennyiben nem tudja ezeket az adatok a rendszer nem engedi tovább.
Amennyiben a belépés sikeres volt a rendszer azonnal megjeleníti számára a szoftvernek az összes funkcióit.
A felhasználó jogosult arra, hogy adatokat szűrjön az összes beépített funkció használatával.
Ezek után megtekintheti az így elkészült adatoknak a listáját.



### Képernyő tervek

Az első kapu a szoftverünkben egy bejelentkezési felület, amely megakadályoz bármilyen illetéktelen bejelentkezést
Szerkezetileg egy minimális méretű ablakról van szó, amely két kitöldendő mezőt tartalmaz és egy bejelentkezés gombot
Ez az utóbbi juttat el minket a főprogramhoz, amely alapértelmezetten megjeleníti az összes tárolt terméket.
Ezt két további régióra oszthatjuk fel vízszintesen -> felül vannak a szűrők, alul pedig maga a listázó/megjelenítő felület.
A szűrőket legördülő menükkel valósítjuk meg (persze ahol ez értelmezhető).
A szűrök kitöltése után a "Keresés" gombra kattintva megjelennek előttünk a megfelelő tételek.
Funkciója még egy hozzáadás, amely egy újabb ablakot hív elő, ahol a megfelelő paraméterekkel fel tudunk venni egy újabb terméket.

### Fogalomtár

- Grafikus felhasználói felület: a számítógép és ember közti kapcsolatot megvalósító elemek összessége. 
- Platform: Olyan rendszer amelyen az adott játék/szoftver elindítható.
- Szűrés: Adott gomb lenyomása esetén itt lesz lehetőség szűrni valamilyen feltétel alapján.
- PLayStation: Konzolos játékok számára készült gépezet amely mára már világméretűre nőtte ki magát.
 




