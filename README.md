# GestionSmart Backend (.NET)

Este repositorio contiene el backend de la aplicación GestionSmart, desarrollado en .NET, que utiliza ASP.NET Core y Entity Framework Core para el acceso a datos.

## Tabla de Contenidos

- [Tecnologías Utilizadas](#tecnologías-utilizadas)
- [Requisitos](#requisitos)
- [Instalación y Ejecución](#instalación-y-ejecución)
- [Configuración de la Base de Datos](#configuración-de-la-base-de-datos)
- [Dockerfile, AWS ECR y AWS App Runner](#dockerfile-aws-ecr-y-aws-app-runner)
- [Notas Adicionales](#notas-adicionales)

## Tecnologías Utilizadas

- **Lenguaje y Plataforma:** [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) con [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) *(o la versión que utilices)*
- **Framework:** [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0)
- **Acceso a Datos:** [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)  
  La configuración se realiza mediante el `DbContext` definido en el proyecto.

## Requisitos

- [Git](https://git-scm.com/)
- [.NET SDK 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) (o la versión requerida)
- [Docker](https://www.docker.com/)
- [AWS CLI](https://aws.amazon.com/cli/) configurado para interactuar con AWS ECR y App Runner

## Instalación y Ejecución

1. **Clonar el repositorio:**
   ```bash
   git clone https://github.com/tu_usuario/tu_repositorio.git
   cd tu_repositorio/backend

