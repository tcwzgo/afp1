**Jelenlegi helyzet**

Videojátékokkal foglalkozó boltunkban megnőtt a beérkező megrendelések, megkeresések száma,
ami a papíron történő leltárazást teszi egyre komplikáltabbá, időigényesebbé.

**Vágyálom rendszer**

- Kell egy adatbázis a háttér adatoknak
- Grafikus felület -> WinForm App
- Szűrők, a termékek egyesével ezek szerint kilistázva vagy összeszámolva (pl.: mennyi rpg játék van)
- Adatbázis implementációja: Fájlban (xls, txt, stb...)
- Fel tudunk venni termékeket ( játéknév, platformok, ár, megjelenés dátuma, beérkezés dátuma, cikkszám, darabszám, Steam-kulcs (ha van) ) --> ezek már kvázi adatbázis-mezők

**Elvárások**

Egy leltárazó program ahol, tudunk módosítani a státuszukon (készleten, eladva, elfogadásra vár), 
lapozás funkció (görgetéssel előre-hátra lapoz) szűrés platform, 
ár alapján keresés cikkszám, név alapján szükség lesz tervezett takarításokra is, 
az elkelt játékokat pl. vétel után egy hónappal már nincs értelme tárolni,csak számlákon
