# Etapa 1: Compilar y publicar la aplicación con .NET 8.0
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar el archivo .csproj y restaurar dependencias
COPY WebApplication1.csproj .
RUN dotnet restore WebApplication1.csproj

# Copiar todo el código y publicar en modo Release
COPY . .
RUN dotnet publish WebApplication1.csproj -c Release -o /app/publish

# Etapa 2: Ejecutar la aplicación con .NET 8.0 Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Fuerza a la app a escuchar en 0.0.0.0:80
ENV ASPNETCORE_URLS=http://0.0.0.0:80

COPY --from=build /app/publish .

EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "WebApplication1.dll"]
