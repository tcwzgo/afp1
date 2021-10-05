###Rendszerteszt###

###Program lefutásának feltételei###

##Login form##
- A szoftvernek induláskor a "LoginForm" ablakot kell létrehoznia és megjelenítenie.
	- az ablakban 3 Label objektum található fő feladatuk a címkézés -> ezek nem változnak
	- található még 2 TextBox, amely a felhasználói inputokat hivatalos kezelni
	- az utóbbi két mezőben csak "admin-admin" (felhasználó-jelszó) kombinációt fogadunk el
	- a jelszó TB-nek rejtve kell lennie
	- amely esetben a belépni kívánó fél helytelen kombinációval szeretne belépni, egy MessageBox objektum jelzi ezt számára
	- helyes kombináció esetén a "Login" Button objektumra kattintva a szoftver inicializálja és megjeleníti a "MainForm" ablakot
	
##Main form##
- Az előzőekben taglaltak szerint kell lefutnia
- Ez a szoftver fő része amely a következő modulokat tartalmazza:
	- Két fő részt definiáltunk amelyek az "Input" és "Output"
	- Az Input régió minden olyan elemet tartalmaz ahol a rendszergazda bemenetet/szűrési paramétert tud megadni és ezeket a megfelelő "vezérlőkkel" (gombokkal) lekérdezni az Output régióba
		- Tartalmaz egy terjedelmesebb részt ehol SerialNum és Name szempontok alapján tudunk szőrni -> ugyanitt tudunk hozzáadni és törölni -> ezeket a funkciókat 2 gomb vezérli
			- a hozzáadaást az "Add Item" míg a törlést a "Remove Item" kezeli -> ezek a Lista adatszerkezetből törlik az Outputban fizikailag kiválasztott eleme(ke)t, majd frissítik az Output modul DataGridView példány kimenetét, amely az adatokat hivatott megjeleníteni
			- a szűrést a "Search by Name & Serial Number" vezérlő hivatott elvégezni -> ez egy lambda Where() feltétel alapján frissíti a fent említett megjelenítő osztály példányát a keresési feltételeknek megfelelően
				

		
		