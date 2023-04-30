# PirosBiros
PirosBiros weboldalhoz tartozó admin alkalmazás útmutató

Adminisztrációs felület, mellyel a weboldalról kapott API-n keresztül, a webshopon található különboző termékek árait tudjuk megváltoztatni, kategóriánként bontva.

A HotCakes felületéről kapott API kulccsal és a weboldal IP cimének összeköttetésével hozzáférést szerzünk a weboldalunk termékeinek adataira kategóriánként, majd a megkapott választ JSON struktúrába mentve kiiratjuk a DataRow-elembe - ezt egy külön függvényként elsőként az API meghivása után végezzük. 

A négy különböző kategória gombjára való kattintás hatására, a fentebb emlitett kategóriára szűrhetünk - repülő, vonat, autó és kiegészitők.

A kereső TextBox-ba való beirás hatására az előzőkben megemlitett függvény kerül meghivásra, minden beirt betű esetén - igy az folyamatosan frissül.

A gombokkal kiválasztott kategória szerinti cellázott elembe való kattintás hatására kijelölhetünk termékeket, melyek árait megváltoztathatjuk és elmenthetjük. Ennek validáltságát, egy csak számokat befogadó Regex-re bizzuk, igy fals információ nem kerülhet be a weboldalra mint ár. Ezután a mentés gombra kattintva, meggyőződhetünk termékünk árának frissitéséről, amely a webshopon is pillanatokon belül frissülni fog.
