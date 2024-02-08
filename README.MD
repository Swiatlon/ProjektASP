# Dokumentacja projektu

## Technologie użyte w projekcie

- ASP.NET Core 6.0
- Entity Framework Core (do zarządzania bazą danych)
- SQLite (jako baza danych)
- JavaScript (do obsługi interakcji klienta)

Dodatkowe biblioteki:
- Microsoft.AspNetCore.Identity.EntityFrameworkCore (do obsługi uwierzytelniania i autoryzacji)
- Newtonsoft.Json (do serializacji i deserializacji danych)

## Dane przykładowych użytkowników

W związku z zastosowaniem modułu uwierzytelniania i autoryzacji dostarczonego przez ASP.NET Core Identity, aplikacja zawiera funkcjonalność zarządzania użytkownikami. Przykładowi użytkownicy mogą być dodawani poprzez rejestrację lub ręczne dodanie przez administratora.

Dane logowania: 

User: </br>
Login: user@wsei.edu.pl
Hasło USER123!

Admin: </br>
Login: admin@wsei.edu.pl
Hasło ADMIN123!

## Proces uruchomienia aplikacji w wersji deweloperskiej

1. **Klonowanie repozytorium:** Sklonuj repozytorium projektu z platformy GitHub. 

    ```bash
    git clone https://github.com/Swiatlon/ProjektASP.git
    ```

2. **Migracja bazy danych:** Przed pierwszym uruchomieniem aplikacji, wykonaj migrację bazy danych, aby utworzyć lub zaktualizować schemat bazy danych. Wykonaj poniższe polecenia w konsoli:

    ```bash
    dotnet ef database update
    ```

3. **Uruchomienie aplikacji:** Po wykonaniu migracji, uruchom aplikację za pomocą polecenia:

    ```bash
    dotnet run
    ```

    Aplikacja zostanie uruchomiona lokalnie i będzie dostępna pod adresem `https://localhost:port` w przeglądarce internetowej.

## Opis funkcji aplikacji

### Produkcja i zarządzanie producentami (Produkty/Producenci)
1. **Dodawanie producentów:** Tylko administratorzy mogą dodawać nowych producentów poprzez formularz, w którym wprowadzają nazwę, opis oraz wybierają adres z listy dostępnych adresów.
2. **Edycja producentów:** Administratorzy mają możliwość edycji istniejących danych producentów, takich jak nazwa i opis.
3. **Wyświetlanie szczegółów producenta:** Użytkownicy mogą przeglądać szczegółowe informacje o każdym producencie, takie jak nazwa, opis oraz powiązane adresy. Jednakże tylko administratorzy mają dostęp do funkcji edycji tych danych.
4. **Usuwanie producentów:** Tylko administratorzy mogą usuwać producentów z systemu, co skutkuje usunięciem wszystkich powiązanych z nimi danych.

### Uwierzytelnianie i autoryzacja użytkowników
1. **Rejestracja użytkowników:** Nowi użytkownicy mogą się zarejestrować, podając podstawowe informacje, takie jak adres e-mail i hasło. Po zarejestrowaniu są traktowani jako standardowi użytkownicy.
2. **Logowanie użytkowników:** Zarejestrowani użytkownicy mogą logować się do systemu, podając swoje dane uwierzytelniające.

### Interakcje z klientem za pomocą JavaScript
1. **Filtrowanie danych:** Na stronach aplikacji użytkownicy mogą filtrować dane, np. listę producentów, wprowadzając odpowiednie kryteria w pola formularzy.
2. **Pobieranie danych z API:** Aplikacja wykorzystuje JavaScript do komunikacji z API w celu pobierania danych, takich jak lista producentów pasujących do określonego filtru.
3. **Dynamiczne wyświetlanie danych:** Zastosowanie JavaScript umożliwia dynamiczne wyświetlanie danych na stronach aplikacji bez konieczności odświeżania całej strony.

To tylko kilka z funkcji, które zapewnia ta aplikacja. Dzięki nim użytkownicy mogą wygodnie zarządzać danymi oraz korzystać z różnych możliwości oferowanych przez system.

## Link do repozytorium z kodem aplikacji

[Link do repozytorium GitHub](https://github.com/Swiatlon/ProjektASP)