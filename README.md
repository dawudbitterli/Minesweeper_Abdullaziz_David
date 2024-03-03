Userstories:

Userstory 1: Der Spieler startet das Spiel und trägt sein Namen ein damit beim Highscore sein Name angezeigt wird
Userstory 2: Der Spieler macht einen Spielzug rückgängig um wieder an der vorherigen Spielsituation zu sein
Userstory 3: Der Spieler kann ein verdecktes Spielfeld eintippen um es aufdecken zu lassen
Userstory 4: Der Spieler sieht seine Aktuelle Zeit damit er einschätzen kann wie lange er gebraucht hat oder wie lange er schon an der Partie dran ist
Userstory 5: Der Spieler kann mit einem Ausrufezeichen an erster Stelle im Eingabefeld eine Fahne auf ein verdecktes Feld setzen um zu kennzeichnen das sich dort eine Mine befindet
Userstory 6: Der Spieler kann verschiedene Schwierigkeitsgrade wählen um das Spielerlebnis aufregender zu gestalten
Userstory 7: Der Minesweeper generiert automatisch eine individuelle Karte damit das Spiel nicht langweilig wird
Userstory 8: Wenn der Spieler eine Mine aufdeckt ist das Spiel vorbei und er kann neu starten damit es eine Herausforderung ist
Userstory 9: Der Spieler deckt Felder auf die je nach dem wie viele Minen sich darum befinden eine bestimmte Zahl anzeigen damit er das Spiel auch gewinnen kann
Userstory 10: Wenn der Spieler ein Feld ohne Zahl aufdeckt, wird ein Fläche aufgedeckt, die die gleichen voraussetzungen erfüllen, damit es der Spieler einfacher hat und schneller weiter kommt


Akzeptanzkriterien:

Userstory 1: 
-  Es erscheint ein Namenleiste in dem man seinen Namen hinein schreibt.
-  Es gibt einen Zeichenlimit von 15 Buchstaben.
-  Es werden nur UTF-8 Zeichen akzeptiert.
-  Mit der Entertaste bestätigt man seine Eingabe.

Userstory 2: 
-  Pro gestartetes Spiel hat man Zwei Wiederholungen bei Niederlage.
-  Mit der R Taste kann man wiederholen.
-  Das Feld verändert sich bei einer Wiederholung
-  Bei Wiederholung wird eine Strafzeit dazugerechnet.

Userstory 3:
-  Die Eingabe muss ein gültiges Feld sein.
-  Das Eingabefeld ist limitiert auf 4 Zeichen
-  Das aufgedeckte Feld zeigt eine Zahl an, wenn eine Mine es umgibt
-  Das aufgedeckte Feld zeigt ein M an, wenn es eine Mine ist.

Userstory 4:
-  Der Timer stoppt wenn man eine Mine aufgedeckt hat.
-  Es gibt eine Strafzeit 20 Sekunden falls man wiederholt.
-  Der Timer stellt den Highscore dar.
-  Der Timer wird in Sekunden dargestellt.

Userstory 5: 
-  Das Fahnensymbol ist ein Ausrufezeichen.
-  Das Ausrufezeichen muss an erster Stelle in der Eingabe stehen, um eine Fahne zu setzten.
-  Eingabe wird ungültig wenn ein Ausrufezeichen an einer anderen Stelle steht.
-  Falls kein Ausrufezeichen in der Zeichenkette steht wird auch keine Markierung gesetzt.

Userstory 6:
-  Die Auswahl wird nachdem man seinen Name geschrieben hat gezeigt.
-  Die Schwierigkeit wird mit den Zahlen 1, 2, 3 gewählt
-  Die Eins wird die einfachste Stufe, Die Zwei die Mittlere Stufe und Drei die schwerste Stufe.
-  Eine ungültige Auswahl wird nicht akzeptiert

Userstory 7:
-  Es wird immer Random die Karte generiert.
-  Der Spieler erhält eine Karte mit den Anzahl Minen die er ausgewählt hat.
-  Es können nicht mehr Minen generiert werden als Ausgewählt.
-  Es wird geschaut das nicht zwei Minen auf einem Feld generiert werden.

Userstory 8:
- Es wird ein M Symbol gezeigt auf dem Jeweiligen Feld der Mine
