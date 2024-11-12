# Transman ist eine Logistik Demoanwendung

![build status](https://github.com/WFeneberg/Transman/actions/workflows/main.yml/badge.svg)

In ihr versuche ich den Domain Driven Design Ansatz umzusetzen. Von Anfang an wird auf Test Driven Design gesetzt um eine möglichst hohe Testabdeckung zu erreichen.

## Techstack:

.Net Framework 8 später 9
Entity Framework Core 8/9

Evolutionary Architecture:
https://github.com/evolutionary-architecture/evolutionary-architecture-by-example

UI:
Avalonia UI
https://avaloniaui.net/
Basiert auch auf SkiaSharp, ähnlich wie flutter

SkiaSharp:
https://github.com/mono/SkiaSharp
C# Port von google: https://skia.org/

Printing/Reporting:
https://github.com/QuestPDF/QuestPDF
basiert auch auf Skia

Datenbank:
SQLite: Treiber build in .Net
Postgresql: https://www.npgsql.org/

Internes Event Messaging System: https://github.com/jbogard/MediatR

## Lernziele:

- Hexagonale Architektur/Onion Architektur mit Domain Driven Design (DDD):

![image](https://github.com/user-attachments/assets/9052ed14-fd2f-4708-a7e5-28c149de58fb)

Versuch sauber zu trennen (Slicing)

![image](https://github.com/user-attachments/assets/fd8659ea-02d6-4426-bf13-7f4b5b16e409)

- Wissen EF Core verbessern (Code First Ansatz)
- Test Driven Development mit hoher Coverage sowohl Unit, Integration als auch Architecture Tests
- Avalonia UI Cross Plattform (Service orientiert (DI) wie bei ASP.Net Core)
- Postgresql/SQlite

- Möglichst offene Architektur, die sich weiterentwickeln kann. Von einem Monolithen zu einem Modolithen bis hin zu einer Microservice Architektur.
  https://entwickler.de/software-architektur/microservices-oder-monolithen-beides einer Modolithen

Mal schauen, wie weit ich komme :-) 



