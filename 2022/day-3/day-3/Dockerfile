FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["day-3/day-3.csproj", "day-3/"]
RUN dotnet restore "day-3/day-3.csproj"
COPY . .
WORKDIR "/src/day-3"
RUN dotnet build "day-3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "day-3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "day-3.dll"]
