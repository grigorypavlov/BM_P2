FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Library.Host/Library.Host.csproj", "Library.Host/"]
RUN dotnet restore "Library.Host/Library.Host.csproj"
COPY . .
WORKDIR "/src/Library.Host"
RUN dotnet build "Library.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Library.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Library.Host.dll"]
