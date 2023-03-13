FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Constructors/Constructors.csproj", "Constructors/"]
RUN dotnet restore "Constructors/Constructors.csproj"
COPY . .
WORKDIR "/src/Constructors"
RUN dotnet build "Constructors.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Constructors.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Constructors.dll"]
