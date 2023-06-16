# DVC.Net

[![Publish NuGet Package](https://github.com/itamadev/DVC.Net/actions/workflows/nuget-push.yml/badge.svg)](https://github.com/itamadev/DVC.Net/actions/workflows/nuget-push.yml)
[![DVC.Net Badge](https://img.shields.io/nuget/v/DVC.Net?label=DVC.Net)](https://www.nuget.org/packages/DVC.Net)

.NET Binding to DVC by iterative.ai utilizing DVC in C# based software

## Installation

### NuGet

```bash
dotnet add package DVC.Net
```

### Manual

Download the latest release from the [releases page](https://github.com/itamadev/DVC.Net/releases)

## Usage

### Basic Usage

```csharp
using DVC.Net;

// Create a new DVC instance
var dvc = new Client();
dvc.Pull();
```

## License

This project is licensed under the Apache License - see the [LICENSE](./LICENSE) file for details
