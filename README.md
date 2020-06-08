# IO-nieRekrutacja
Console app, Repository design pattern

    Solucję podzielić na osobne projekty – abstrakcja, serwisy, repozytoria, baza danych, testy
    Abstrakcja do wszystkiego, gdzie się da to trzeba ja zastosować
    Wstrzykiwanie zależności – proponuje Autofac, wstrzykiwanie przez Konstuktor
    Context musi być wstrzykiwany, ograniczamy new do minimum w aplikacji
    Obsługa transakcji w Context, konieczne metody Save, Rollback
    UnityOfWork, przynajmniej dwóch repozytoriów
    Obsługa zewnętrznego loggera, przy pomocy prostego interface ILogger, w końcu nie wiem z czego będziemy korzystać
    Projekt testów nie musi korzystać z żadnego frameworka, chodzi tylko o to czy jest możliwe proste napisanie kodu-metody, który będzie testował dwie wybrane metody w serwisie, a ta wiedza da nam informację, czy nie mamy gdzieś twardych połączeń
    
Niech aplikacja na podstawie naciśniętego klawisza będzie wywoływała operacje na bazie:
Q - zamknięcie programu
1 – add nowego obiektu encji
2 – aktualizacja obiektu encji
3 – usunięcie obiektu encji z bazy
