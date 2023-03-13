FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SW03/SW03.csproj", "SW03/"]
RUN dotnet restore "SW03/SW03.csproj"
COPY . .
WORKDIR "/src/SW03"
RUN dotnet build "SW03.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SW03.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SW03.dll"]
