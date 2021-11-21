# Webbshoppen
Oskar och Almas webbshop

API

För att sidan skall fungera som det är tänkt så måste api köras i bakgrunden som administratör och möjligtvis så måste localhost adresserna i api och klient uppdateras. 
Api sparar produkter som läggs till genom klienten i en textfil lokalt på c://webbshoppenTemp.txt. 
Finns metoder för att både spara och updatera produkter på api från klientens admin sida men har i dagsläget inte fått HttpDelete att fungera. 

Klient (webbapplikation)

Manuellt tillagda produkter hämtas automatiskt från API men i testsyfte finns en produktkatalog med över 500 artiklar under Admin/Get test products.
Använder cookies för att spara varukorgen
Cookie disclaimer kommer finnas i botten på hemsidan första gången man öppnar sidan. 


// Oskar och Alma
