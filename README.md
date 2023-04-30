# PirosBiros
PirosBiros weboldalhoz tartozó admin alkalmazás útmutató

Adminisztrációs felület, mellyel a weboldalról kapott API-n keresztül, a webshopon található különboző termékek árait tudjuk megváltoztatni.

A HotCakes felületéről kapott API kulccsal és a weboldal IP cimének összeköttetésével hozzáférést szerzünk a weboldalunk termékeinek adataira kategóriánként, majd a megkapott választ JSON struktúrába mentve kiiratjuk a DataRow-elembe - ezt egy külön függvényként elsőként az API meghivása után végezzük. 

Eze függvényt, a kereső TextBox változtatásakor folyamatosan frissitjük, kategóriától függően igy a nevéhez legközelebb álló terméket kapja a felhasználó.

Az új designelemként megjelenő, már implementált 4 kategóriagomb szerepe a következő - a fentebb meghivott keresőfüggvénnyel tandemben segitik az adott termék minél könnyebb megtalálását. Ezt egyszerűen az API "selectedCategorie" argumentumának változtatásával teszi, annak megfelelően, hogy a felhasználú mit választ: repülő, vonat, autó és kiegészitő.

A DataGridView elemben való kattintással kiválasztott elemnek ezután megjelenik a neve, is jelezve, hogy mégis mit választott ki a felhasználó - ezután megadhatjuk a kivánt új árat is, mely validságát egy csak számokat befogadó Regex biztositja számunkra, igy a fals input-okat nem fogadja el, mint például a betűket sem.

Végül a felhasználó ha frissiteni kivánja az árakat, azt a FRISSIT! gombra kattintva megteheti - ezzel pedig egy idejűleg a webshop felületén is megújul az oldal.
