# PirosBiros
PirosBiros weboldalhoz tartozó admin alkalmazás útmutató

//Summary
Adminisztrációs felület, mellyel a weboldalról kapott API-n keresztül, a webshopon található különboző termékek árait tudjuk megváltoztatni.

A HotCakes felületéről kapott API kulccsal és a weboldal IP cimének összeköttetésével hozzáférést szerzünk a weboldalunk termékeinek adataira kategóriánként, majd a megkapott választ JSON struktúrába mentve kiiratjuk a ListBox-elembe - ezt egy külön függvényként elsőként az API meghivása után végezzük. 

A következő függvényben hasonló módszerrel járunk el, itt azonban a különálló termékeket szedjük le az API segitségével, amelyeket egy DataTable elembe helyezünk el, amelybe a termékek különböző adatait külön-külön oszlopokba helyezzük ki: név, ár és azonositó. 

Ezután az előzőkben megnevezett elemekkel való felhasználói interrakcióknak megfelelően jár el a program, attól függően, hogy az mit ad meg, valamint hogy menti-e azt a felhasználó.
