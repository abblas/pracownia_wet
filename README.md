# pracownia_wet
# Dokumentacja techniczna aplikacji Przychodnia weterynaryjna

## Temat i cel biznesowy aplikacji
Aplikacja "Przychodnia weterynaryjna "VetAnimal" jest oprogramowaniem pozwalającym na zarządzanie przychodnią weterynaryjną.
Jej głównym celem jest umożliwienie personelowi przychodni obsługi wizyt pacjentów, zarządania danymi pacjentów, właścicieli oraz lekarzy, w oparciu o dane w bazie danych.
Wszystkie dostępne opcje w aplikacji są określone na podstawie dostępu w oparciu o system logowania.
Każdy użytkownik ma przypisaną do siebie rolę (administrator, kierownik przychodni, kierownik recepcji, recepcjonista oraz lekarz) i na ich podstawie zostaje zapewniony odpowiedni poziom dostępu do funkcji aplikacji.

## Użyte technologie
- Język programowania C#
- Framework: Windows Forms (WinForms)
- IDE: Visual Studio
- Format plików: Pliki tekstowe (TXT) jako baza danych
- Paradygmat: Programowanie obiektowe (struktura klas, dziedziczenie, hermetyzacja, polimorfizm)

## Lista funkcjonalności
1. Logowanie
   - Autoryzacja użytkowników w oparciu o login, hasło, dostęp poprzez odpowiednią rolę.
   - Obsługa pięciu ról: Administrator, Kierownik przychodni, Kierownik recepcji, Lekarz
     
2. Zarządzanie wizytami
   - Dodawanie nowych wizyt (dostępne dla wszystkich użytkowników prócz Lekarzy)
   - Edycja istniejących wizyt
   - Usuwanie wizyt (dostępne dla wszystkich użytkowników prócz Lekarzy)
   - Wyświetlanie listy wizyt
  
3. Zarządzanie pacjentami
   - Dodanie nowych pacjentów (dostępne dla wszystkich użytkowników prócz Lekarzy)
   - Przypisywanie właścicieli do pacjentów
   - Edycja istniejących pacjentów (dostępne dla wszystkich użytkowników prócz Lekarzy i Recepcjonistów)
   - Usuwanie pacjentów (dostępne dla wszystkich użytkowników prócz Lekarzy i Recepcjonistów)
   - Wyświetlanie listy pacjentów
  
4. Zarządzanie właścicielami
   - Dodanie nowych właścicieli (dostępne dla wszystkich użytkowników prócz Lekarzy)
   - Edycja istniejących właścicieli (dostępne dla wszystkich użytkowników prócz Lekarzy i Recepcjonistów)
   - Usuwanie właścicieli (dostępne dla wszystkich użytkowników prócz Lekarzy i Recepcjonistów)
   - Wyświetlanie listy właścicieli

5. Zarządzanie lekarzami
   - Dodanie nowych lekarzy (dostępne dla Administratorów oraz Kierowników przychodni)
   - Edycja istniejących lekarzy (dostępne dla Administratorów oraz Kierowników przychodni)
   - Usuwanie lekarzy (dostępne dla Administratorów oraz Kierowników przychodni)
   - Wyświetlanie listy lekarzy
     
6. Wylogowanie
   - Funkcja umożliwiająca wylogowanie bieżącego użytkownika i przejście do ekranu logowania

7. Wyjście
   - Funkcja umożliwiająca zamknięcie aplikacji
     
## Zrzuty ekranu
1. Ekran logowania: Formularz umożliwiający zalogowanie się do aplikacji.
2. Menu główne: Główne okno aplikacji z przyciskami do zarządzania wizytami, pacjentami, właścicielami i lekarzami
3. Zarządzanie wizytami: Wyświetlanie, dodawanie, edycja i usuwanie wizyt.
4. Zarządzanie pacjentami Wyświetlanie, dodawanie, edycja i usuwanie pacjentów.
5. Zarządzanie właścicielami: Wyświetlanie, dodawanie, edycja i usuwanie właścicieli.
6. Zarządzanie lekarzami: Wyświetlanie, dodawanie, edycja i usuwanie lekarzy.
   
## Instalacja i uruchomienie
1. Należy pobrać zawartość folderu "Instalka do przychodni"
2. Po pobraniu folderu wraz z jego zawartością należy uruchomić plik o nazwie "przychodnia.exe"
3. Program gotowy do użycia

## Opis architektury
Główne elementy paradygmatu obiektowego

1. Struktura klas 
  - Klasy modelujące dane:
      Klient.cs – przechowuje informacje o właścicielach pacjentów.
      Lekarz.cs – reprezentuje lekarzy w systemie.
      Pacjent.cs – przechowuje dane o pacjentach.
      Wizyta.cs – reprezentuje wizyty w przychodni.
      Uzytkownik.cs – definiuje użytkowników aplikacji oraz różnicuje ich role (administrator, kierownik przychodni, kierownik recepcji, recepcjonista oraz lekarz).
    
  - Klasy funkcjonalne (logika aplikacji):
      Logowanie.cs – odpowiada za proces logowania użytkowników.
      Menu_Wizyty.cs, Menu_Lekarze.cs, Menu_Pacjenci.cs, Menu_Wlascicieli.cs – obsługują funkcje dla poszczególnych sekcji aplikacji (zarządzanie wizytami, lekarzami, pacjentami itp.).
      Przychodnia.cs – pełni rolę głównego okna aplikacji.
    
  - Klasa główna:
      Program.cs – zawiera punkt wejścia aplikacji (Main), inicjalizuje logowanie i główne okno aplikacji.
    
2. Dziedziczenie
  - Klasa Osoba jest klasą bazową dla klas Lekarz oraz Klient. Dziedziczy wspólne właściwości takie jak:
      Imię
      Nazwisko
      Płeć
  - Klasa Użytkownik jest klasą bazową dla klas specyficznych ról, takich jak:
      Administrator
      Kierownik przychodni
      Kierownik recepcji
      Recepcjonista
      Lekarz

3. Polimorfizm
   - Metoda Zaloguj w klasie Użytkownik została nadpisana w klasach dziedziczących, aby obsługiwać specyficzne zachowanie dla każdej roli.

4. Hermetyzacja
   - Pola takie jak: Login, Hasło i Rola są prywatne, a dostęp do nich jest realizowany przez właściwości.

## Diagram klas UML
Diagram klas UML przedstawia relacje między klasami ich metody i właściwości.
(Diagram w formie kodu napisany w programie Visual Studio Code oraz wygenerowany w formie graficzniej w programie PlantUML zostanie dołączony w plikach diagram klas.puml, diagram klas.png)

## Autorzy
Łukasz Chodzicki, Jakub Piasecki
 

