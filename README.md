# Transman ist eine Logistik Demoanwendung

![build status](https://github.com/WFeneberg/Transman/actions/workflows/main.yml/badge.svg)

In ihr versuche ich den Domain Driven Design Ansatz umzusetzen. Von Anfang an wird auf Test Driven Design gesetzt um eine möglichst hohe Testabdeckung zu erreichen.

## Techstack:

.Net Framework 8 später 9 </br>
Entity Framework Core 8/9 </br>

Evolutionary Architecture: </br>
https://github.com/evolutionary-architecture/evolutionary-architecture-by-example </br>

UI: </br>
Avalonia UI </br>
https://avaloniaui.net/ </br>
Basiert auch auf SkiaSharp, ähnlich wie flutter </br>

SkiaSharp: </br>
https://github.com/mono/SkiaSharp </br>
C# Port von google: https://skia.org/ </br>

Printing/Reporting: </br>
https://github.com/QuestPDF/QuestPDF </br>
basiert auch auf Skia </br>

Datenbank: </br>
SQLite: Treiber build in .Net </br>
Postgresql: https://www.npgsql.org/ </br>

Internes Event Messaging System: https://github.com/jbogard/MediatR

## Lernziele:

- Hexagonale Architektur/Onion Architektur mit Domain Driven Design (DDD):

![image](https://github.com/user-attachments/assets/9052ed14-fd2f-4708-a7e5-28c149de58fb)

Versuch sauber zu trennen (Slicing)

![image](https://github.com/user-attachments/assets/fd8659ea-02d6-4426-bf13-7f4b5b16e409)

- Wissen EF Core verbessern (Code First Ansatz) </br>
- Test Driven Development mit hoher Coverage sowohl Unit, Integration als auch Architecture Tests </br>
- Avalonia UI Cross Plattform (Service orientiert (DI) wie bei ASP.Net Core) </br>
- Postgresql/SQlite</br> 
</br>
- Möglichst offene Architektur, die sich weiterentwickeln kann. Von einem Monolithen zu einem Modolithen bis hin zu einer Microservice Architektur. </br>
  https://entwickler.de/software-architektur/microservices-oder-monolithen-beides </br>
- Nur OpenSource Komponenten </br>
</br>
- Github Wissen verbessern, insbesonder Github Actions </br>
</br>
Mal schauen, wie weit ich komme :-) 



