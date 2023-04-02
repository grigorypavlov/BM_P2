# Aufgabenstellung
Du bist Entwickler in einem Unternehmen, das eine Software entwickeln möchte, die eine Todo-Liste verwaltet..

## Entitäten
Folgendes sind die Entitäten, die in der App vorkommen sollen:
- Todo-Liste (Sammelbecken für Todo-Items)
- Todo-Item (Einzelne Aufgabe, die in einer Todo-Liste enthalten sein kann)
- TodoRepository (Speichert die Todo-Listen mit den enthaltenen Todo-Items)

## Funktionen
Die App soll folgende Funktionen haben:
- Erstellen einer Todo-Liste
- Hinzufügen eines Todo-Items zu einer Todo-Liste
- Entfernen eines Todo-Items aus einer Todo-Liste
- Speichern der Todo-Listen mit den darin enthaltenen Todo-Items im TodoRepository
- Laden der Todo-Listen und der darin enthaltenen Todo-Items aus dem TodoRepository
- Ausgabe der Todo-Listen und Todo-Items in der Konsole
- Finalisieren eines Todo-Items
- Finalisieren einer Todo-Liste

## States
![States](
./Pictures/States.jpg)

## Klassendiagramm
![Klassendiagramm](
./Pictures/Klassendiagramm.jpg)

## Aufgaben
Du sollst nun in der Main Methode ein Repository und eine Todo-Liste "Waesche" erstellen, die folgende Items enthält:
- Item 1:
  - Description: Wäsche waschen
  - State: Created
- Item 2:
  - Description: Wäsche aufhängen
  - State: Created
- Item 3:
  - Description: Wäsche zusammenlegen
  - State: Created
- Item 4:
  - Description: Wäsche in den Schrank legen
  - State: Created

Eine zweite Liste "Auto" soll erstellt werden, die folgende Items enthält:
- Item 1:
  - Description: Auto waschen
  - State: Created
- Item 2:
  - Description: Auto polieren
  - State: Created
- Item 3:
  - Description: Auto wachsen
  - State: Created

Nun sollen die Items soweit angepasst werden, dass sie alle im State Approved sind und somit im Repository gespeichert werden können.

### Einschränkungen
- Du darfst keine weiteren Klassen erstellen
- TodoListen dürfen nur gespeichert werden, wenn sie Items enthalten, die mindestens im State Approved sind.
- Möglicherweise musst du die Klassen noch anpassen, damit die Aufgabenstellung erfüllt werden kann.

