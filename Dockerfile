#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Api.Application/application.csproj", "Api.Application/"]
COPY ["src/Api.Domain/Domain.csproj", "Api.Domain/"]
COPY ["src/Api.Service/Service.csproj", "Api.Service/"]
COPY ["src/Api.Data/Data.csproj", "Api.Data/"]
COPY ["src/Api.CrossCutting/CrossCutting.csproj", "Api.CrossCutting/"]
RUN dotnet restore "Api.Application/application.csproj"
COPY . .
WORKDIR "/src/src/Api.Application"
RUN dotnet build "application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "application.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "application.dll"]