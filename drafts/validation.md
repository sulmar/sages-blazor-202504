# Zadanie: Walidacja Produktu w Blazorze

## Cel:
Twoim zadaniem jest stworzenie formularza do dodawania produktów w aplikacji **Blazor**, który wykorzystuje walidację opartą na **DataAnnotations** lub **Fluent Validations**. Formularz powinien umożliwiać wprowadzenie danych produktu oraz ich poprawną walidację przed zapisaniem.

## Wymagania funkcjonalne:
Formularz powinien zawierać następujące pola:
- **Nazwa produktu** (wymagana, maksymalnie 100 znaków).
- **Kod produktu** (wymagany, musi pasować do formatu ABC-1234).
- **Cena** (wymagana, większa niż 0, maksymalnie 1 999.99).
- **Opis** (wymagany, maksymalnie 50 znaków).
- **Data ważności** (wymagana, musi być w przyszłości).

## Walidacja:

Użyj adnotacji [Required], [StringLength], [Range], [RegularExpression] oraz własnej walidacji dla daty ważności.

Jeśli użytkownik poda błędne dane, formularz powinien wyświetlać odpowiednie komunikaty błędów.

Obsługa formularza:

Po poprawnym wypełnieniu formularza w konsoli (Console.WriteLine) powinien pojawić się komunikat: "Produkt zapisany poprawnie!".

Nie zapisujemy danych do bazy – skupiamy się wyłącznie na walidacji.
