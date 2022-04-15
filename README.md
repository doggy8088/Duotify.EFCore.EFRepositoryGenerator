# Duotify.EFCore.EFRepositoryGenerator

This .NET Global tool is a supplemental tool for generating EFCore Repository Pattern.

## Installation

```sh
dotnet tool install -g Duotify.EFCore.EFRepositoryGenerator
```

## Usage

1. Usage information

    ```sh
    efr
    ```

    > `efr` is stands for **Entity Framework Repository Pattern generator**.

1. List all the DbContext class in the project

    ```sh
    efr list
    ```

2. Generating all the repositories for the entity model.

    ```sh
    efr generate -c ContosoUniversityContext -o Models
    ```

    > This command will build existing project first. Only buildable project can generate.

    Show generating files 

    ```sh
    efr generate -c ContosoUniversityContext -o Models -v
    ```

    Overwrite existing files

    ```sh
    efr generate -c ContosoUniversityContext -o Models -v -f
    ```

## Build & Publish

1. Change `<PackageVersion>` and `<Version>` property in `*.csproj` file

2. Build & Pack & Publish

    ```sh
    dotnet pack -c Release
    dotnet nuget push bin\Release\Duotify.EFCore.EFRepositoryGenerator.1.0.0.nupkg --api-key YourApiKeyFromNuGetOrg --source https://api.nuget.org/v3/index.json
    ```
