# Rent_A_Car
 Rent a car windows form app, xamarin app, and web api,
 
Za pokretanje UWP-a (Mobilne aplikacije), potrebno je komentarisati app.UseHttpsRedirection(); unutar Startup.cs klase i onemoguciti ssl unutar WebAPI propertija,

Za pokretanje Win UI potrebno je potrebno je odkomentarisati app.UseHttpsRedirection(); unutar Startup.cs klase i omoguciti ssl unutar WebAPI propertija,

U projektu se nalazi seeder koji automatski kreira bazu i puni je incijalnim podacima (tabela zaposlenici: admin i zaposlenik, a tabela klijent: klijent i klijen2).

Pristupni podaci za WinUI su: korisničko ime: admin, pass:test, korisničko ime:zaposlenik, pass:test
Pristupni podaci za Xamarin su: korisničko ime: klijent, pass:test, korisničko ime: klijent2, pass test

Prilikom pokretanja komande docker-compose up dobijemo poruku "the framework microsoft.windowsdesktop.app version 3.1.0 was not found" ali aplikacija radi bez problema.
