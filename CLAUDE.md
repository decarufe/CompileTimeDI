# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a C# demo project comparing three different Compile Time Dependency Injection (CTDI) solutions:
1. **StrongInject** - Uses partial classes with `[Register]` attributes
2. **Jab** - Uses partial classes with `[ServiceProvider]` and service attributes
3. **ThunderboltIoc** - Uses inheritance from `ThunderboltRegistration` base class

## Architecture

- **Services/**: Shared service interfaces and implementations (`IGreetingService`, `IOutput`)
- **DemoJab/**: Jab implementation with `JabServiceProvider` 
- **DemoStrongInject/**: StrongInject implementation with `StrongInjectContainer`
- **DemoThunderbolt/**: ThunderboltIoc implementation with `MyThunderboltRegistration`
- **Tests/**: Unit tests using xUnit, FluentAssertions, and Moq

Each demo project follows the same pattern:
- References the shared `Services` project
- Implements DI container configuration specific to that framework
- Contains a console application (`Program.cs`) demonstrating usage

## Common Commands

### Build
```bash
dotnet build
# or for specific configuration
dotnet build -c Release
```

### Run Demo Applications
```bash
# Run individual demos
dotnet run --project DemoJab
dotnet run --project DemoStrongInject  
dotnet run --project DemoThunderbolt
```

### Test
```bash
# Run all tests
dotnet test
# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"
```

### Clean
```bash
dotnet clean
```

## Key Technologies

- **.NET 6.0** with nullable reference types enabled
- **xUnit** for testing with FluentAssertions and Moq
- **Jab 0.6.4** for compile-time DI
- **StrongInject 1.4.3** for compile-time DI  
- **ThunderboltIoc 1.2.3** for compile-time DI

## DI Container Patterns

Each framework uses different approaches for service registration:

**Jab**: Attribute-based on partial service provider class
**StrongInject**: Attribute-based on partial container class implementing `IAsyncContainer<T>`
**ThunderboltIoc**: Method-based registration in `Register()` override

All demos register the same services:
- `IGreetingService` → `GreetingService` (Transient)
- `IOutput` → `ConsoleOutput` (Transient)