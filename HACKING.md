# Development Environment Setup

This project was initialized and is managed using `dotnet` CLI on Windows. Steps were adapted from the [documentation](https://ldm-community.github.io/docs/development-guide/getting-started/making-your-first-plugin/#making-a-plugin-from-scratch)

`$ dotnet new classlib -n Sentinel; cd Sentinel`

`$ dotnet add Sentinel.csproj reference .\libs\Assembly-CSharp.dll`

`$ dotnet new gitignore`

## Building the Plugin

`$ dotnet build`