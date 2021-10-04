## Rendszerterv

### A rendszer célja

A rendszer célja, hogy a cégeknek és magánszemélyeknek bemutassuk a raktározási/szűrési funkciókat és ezáltal utat nyitni azoknak akik eme rendszerek iránt érdeklődnek.
A Felhasználó bejelentkezés után választhat a megjelnített funkciók közül, és ezáltal belemerülhet a raktározási implementációk használatába.
Egy teszt állomány van feltöltve a rendszerbe, Excel formátumban, amivel a Felhasználó adott szűrési lehetőséget jeleníthet meg. Célunk között van, hogy minél több platformra
akár telefonos felületre is implementáljuk ezt az alkalmazást. A rendszernek továbbá van egy olyan lehetősége, hogy adatokat vigyen fel a már meglévő adatokhoz.


### Projektterv

Résztvevők és főbb szerepköreik: 
- Nagy-Tóth Bence: Rendszer kigondolása, listázás megvalósítása, beolvasás a fájlból, háttérmunkák végzése a DLL fájl megfelelő igénybevételével.
- Hegyi Krisztián: Login/Mainform GUI kigondolása és megvalósítása, Gombok készítésében és megvalósításában való segítség.
- Sipos Levente: Login funkció megvalósítása, közreműködés a gombok megfelelő működése érdekében.

### Üzleti folyamatok modellje

A felhasználó az első indításkor meg kell addnia a felhasználó nevét és a jelszavát (amit a rendszer kialakított számára). Ha esetleg a Felhasználó 
módosított a raktár listáján az automatikusan mentésre kerül számára.


### Követelmények

Funkcionális követelmények: - Adatok eltárolása - Felhasználó által hozzáadott adatok tárolása - Gombok működése 
- Input mezők megfelelő működése 

Nem funkcionális követelmények: -Felhasználóbarát felület, átlátható - Szűrés, keresés gyors és letisztul működése - Optimálisság

Törvényi előírások, szabványok: - GDPR-nak való megfelelés - Általános információk - Szellemi tulajdon - Használat - Felelősségi szabályok -
Technikai követelmények - Garancia és kártérítés - 2013. évi V. törvény - Európai Parlament és Tanács 2016. április 27-i (EU) 2016/679 Rendelete
- 2011. évi CXII. törvény - a szerzői jogról szóló 1999. évi LXXVI. törvény - 2001. évi CVIII. törvény

### Architekturális terv

A rendszerhez szükség van egy fájl-ra, ebben az esetben Microsoft Excel-t használunk.
Bejelentkezés után elérhetőek lesznek az adott beépített funkciók.

### Implementációs terv


#### Windows Desktop Application

A terv a Visual Studio C# használatát/ismeretét írja elő, mivel könnyen használható.
Az alkalmazás felhasználói oldalát asztali alkalmazásnak tervezzük.

### Funkcionális terv

















### Fizikai környezet

- Az alkalmazás Windows operációs rendszerre készült
- Nincsenek megvásárolt komponenseink
- Nincsenek alkalmazáson belüli mikrotranzakciók
- Használt alkalmazások és Fejlesztői környezetek:
- Microsoft Excel
- Visual Studio 

### Absztrakt domain modell

A rendszert a felhasználó egy Windowsos alkalmazáson keresztül érheti majd el, aminek az elkészítését C# nyelven tervezzük. A felület
lehetővé teszi majd a felhasználó számára a név és a jelszó megadásával a bejelentkezést. A felhasználó választhat a beépített funkciók közül.
Amennyiben a felhasználó keresni szeretne ezt név alapján és serial number alapján teheti meg, valamint ha hozzászeretne adni a raktári listához 
abban az esetben ki kell tölteni az input mezők összes tartalmát. Szűrési funkciók beérkezési idő alapján, ár alapján. Az adatok Excel táblázatban
vannak és lesznek eltárolva.

### Teszt terv








### Telepítési terv

A Felhasználó a web oldalunkat felkeresve töltheti le az alkalmazást.
Windows 10-es operációs rendszerre érdemes telepíteni, annak érdekében hogy az alkalmazás tökéletesen működjön.
Sikeres telepítés után az alkalmazás már rögtön kipróbálható.


### Karbantartási terv

Adaptive Maintenance: A program naprakészen tartása és finomhangolása. Perfective Maintenance: A szoftver hosszútávú használata érdekében végzett módosítások, 
új funkciók, a szoftver teljesítményének és működési megbízhatóságának javítása.
Preventive Maintenance: Olyan problémák elhárítása, amelyek még nem tűnnek fontosnak, de később komoly problémákat okozhatnak.
Az alkalmazás folyamatos üzemeltetése és karbantartása, mely magában foglalja a programhibák elhárítását,
a belső igények változása miatti módosításokat,  valamint a környezeti feltételek változása miatt megfogalmazott program-, 
illetve állomány módosítási igényeket. Ellenőrizni kell, hogy a jövőben kiadott Microsoft Windows verziókkal 
kompatibilis-e az alkalmazás.  A jövőben szükség lehet új hardware implementációra igénynövekedés esetén.
Karbantartás Corrective Maintenance: A felhasználók által felfedezett és "user reportban" elküldött hibák kijavítása.