# Interfocus POC

## Generate SQL from DbContext

dotnet ef dbcontext script -o s.sql

## Run tests

dotnet test --logger:"console;verbosity=detailed"
dotnet test --logger:"console;verbosity=detailed" --filter "FullyQualifiedName~UnitTests"
