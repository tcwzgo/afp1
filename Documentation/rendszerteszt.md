## Rendszerteszt

### Program lefutásának feltételei


### Alap adatok, választott adatszerkezet
- A megvalósításhoz mindenképpen a dinamikus adatszerkezetek között keresgéltünk és  végül a List-re jutottunk
- Egy terméket 9 formális paraméterrel tárolunk "Product" néven
- A szoftvernek képesnek kell lennie termékek tárolására, felvételére, törlésére, szűrésére a lent taglaltak szerint

### Login form
- A szoftvernek induláskor a "LoginForm" ablakot kell létrehoznia és megjelenítenie.
	- az ablakban 3 Label objektum található fő feladatuk a címkézés -> ezek nem változnak
	- található még 2 TextBox, amely a felhasználói inputokat hivatalos kezelni
	- az utóbbi két mezőben csak "admin-admin" (felhasználó-jelszó) kombinációt fogadunk el
	- a jelszó TB-nek rejtve kell lennie
	- amely esetben a belépni kívánó fél helytelen kombinációval szeretne belépni, egy MessageBox objektum jelzi ezt számára
	- helyes kombináció esetén a "Login" Button objektumra kattintva a szoftver inicializálja és megjeleníti a "MainForm" ablakot
	
### Main form
- Az előzőekben taglaltak szerint kell lefutnia
- Ez a szoftver fő része amely a következő modulokat tartalmazza:
	- Két fő részt definiáltunk amelyek az "Input" és "Output"
	- Az Input régió minden olyan elemet tartalmaz ahol a rendszergazda bemenetet/szűrési paramétert tud megadni és ezeket a megfelelő "vezérlőkkel" (gombokkal) lekérdezni az Output régióba
		- Tartalmaz egy terjedelmesebb részt ehol SerialNum és Name szempontok alapján tudunk szőrni -> ugyanitt tudunk hozzáadni és törölni -> ezeket a funkciókat 2 gomb vezérli
			- a hozzáadaást az "Add Item" míg a törlést a "Remove Item" kezeli -> ezek a Lista adatszerkezetből törlik az Outputban fizikailag kiválasztott eleme(ke)t, majd frissítik az Output modul DataGridView példány kimenetét, amely az adatokat hivatott megjeleníteni
			- a szűrést a "Search by Name & Serial Number" vezérlő hivatott elvégezni -> ez egy lambda Where() feltétel alapján frissíti a fent említett megjelenítő osztály példányát a keresési feltételeknek megfelelően
			- illetve a "Clear" gomb kiüríti a már említett szűrési paramétereket (értékek üres string-re állítva)
		- Illetve még Input regióhoz tartozó rész egy extra rendező elem
			- ez tartalmaz 3 mezőt amelyre kattintva kiválasztjuk a rendezés feltételét (Filter by), ez egy ListBox objektum aminek megvizsgáljuk a kiválasztott elemét a "Filter" esemény hatására
			- legördülő menük (ComboBox-ok) segítik a felhasználást, mindig az lesz figyelembe véve amelyet a ListBox-ból kiválasztunk
			- a megfelelő paraméterek bevitele után a Filter gomb kattintására kerül a sor, amely hatására egy gomb nyomás eseménye fut le amelyben a két fenti paraméter szerint rendezünk
			- ehhez tartozik egy "Reset" amely a szűrési feltételeket megszünteti, oly módon, hogy a DataGridView.DataSource property-ét a használt adatszerkezet eredeti formájára állítja
			- ezen menük mellett létrehoztunk egy egyszerű mindenki által ismert Sorting funkciót is (ASC-DESC) amely vagy növekvő vagy csökkenő sorrendbe állítja a termékeket (a Lista adatszerkezet metódusaival valósul meg a rendezés)
	- Az Output rész jóval egyszerűbb hiszen itt csak a kívánt elemeket jelenítjük meg:
		- a megjelenítő felület egy FlowLayoutPanel amely AutoScroll attribútumát True-ra állítva elérjük az ablak görgetéssel való mozgatását
		- DataGridView objektumot használunk a termékek megjelenítésére
		- default-on az összes tárolt elemet meg kell jelenítenünk
		- illetve a szűrés-kódok végén a DataGridView.DataSource property-t kell beállítanunk az adott feltételnek megfelelően
		
		
				

		
		