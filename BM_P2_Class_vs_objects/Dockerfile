FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BM_P2_Class_vs_objects/BM_P2_Class_vs_objects.csproj", "BM_P2_Class_vs_objects/"]
RUN dotnet restore "BM_P2_Class_vs_objects/BM_P2_Class_vs_objects.csproj"
COPY . .
WORKDIR "/src/BM_P2_Class_vs_objects"
RUN dotnet build "BM_P2_Class_vs_objects.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BM_P2_Class_vs_objects.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BM_P2_Class_vs_objects.dll"]
