# 3-layer architecture in C# (3-Lags Arkitektur)

A small car registry ("3-lags arkitektur" is Danish for *three-layer architecture*), built to practise
separating an application into presentation, business logic and data access layers. Each layer is its
own project, and the layers only talk to each other through DTOs.

## Architecture

```
┌──────────────────────────┐
│ 3-Lags Arkitektur (WPF)  │  Presentation – MainWindow
└────────────┬─────────────┘
             │ DTO.Car
┌────────────▼─────────────┐
│ BusinessLogic            │  CarBLL – rules and orchestration
└────────────┬─────────────┘
             │ DTO.Car
┌────────────▼─────────────┐
│ CarDataAccess            │  CarRepository, CarMapper (entity ↔ DTO)
│                          │  CarContext (Entity Framework), CarInitializer (seed data)
└────────────┬─────────────┘
             ▼
        SQL Server / LocalDB
```

## Projects

| Project | Responsibility |
|---|---|
| `3-Lags Arkitektur` | WPF user interface |
| `BusinessLogic` | `CarBLL`, the only entry point the UI uses |
| `DTO` | Plain `Car` data-transfer object shared between layers |
| `CarDataAccess` | EF6 `DbContext`, entity model, repository and mapper |

## Tech

C# · WPF · Entity Framework 6 · .NET Framework 4.7.2

## Running it

Open `3-Lags Arkitektur.sln` in **Visual Studio**, restore NuGet packages, set the WPF project as the startup
project and press **F5**. The database is created and seeded on first run.
