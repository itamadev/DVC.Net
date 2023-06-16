# DVC.Net
.NET Binding to the Iterative's DVC utilizing DVC in C# based software

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
