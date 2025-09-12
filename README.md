# SurfTimer.Shared

**SurfTimer.Shared** is a shared .NET 8 class library used across the *SurfTimer* solution.  
It provides a centralized foundation for common logic and data structures, ensuring consistent behavior between different projects.

## ✨ Features
- **DTOs and Entities**: Strongly-typed models representing SurfTimer data.
- **Custom Data Types & Handlers**: Type-safe conversions and helpers for specialized values.
- **Database Integration**: Built-in support for [MySqlConnector](https://mysqlconnector.net/) and [Dapper](https://www.learndapper.com).
- **Code Reuse**: Centralizes logic shared by both the API and the Counter-Strike 2 plugin.

## 🔗 Dependencies
Both [`SurfTimer.Api`](https://github.com/tslashd/SurfTimer.Api) and [`SurfTimer.Plugin`](https://github.com/CS2Surf/Timer) (also called *Timer*) rely on this library.  
They **will NOT work** without it, as it contains the core definitions required to interact with the database and exchange data.

