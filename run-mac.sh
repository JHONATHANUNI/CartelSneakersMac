#!/bin/zsh
export DOTNET_ROOT=/opt/homebrew/opt/dotnet@8/libexec
export PATH=/opt/homebrew/opt/dotnet@8/bin:$PATH
exec dotnet run --project "$(dirname "$0")/UrbanKicksMac.csproj" --urls http://localhost:5187
