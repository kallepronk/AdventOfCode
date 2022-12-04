FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["day-4/day-4.csproj", "day-4/"]
RUN dotnet restore "day-4/day-4.csproj"
COPY . .
WORKDIR "/src/day-4"
RUN dotnet build "day-4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "day-4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "day-4.dll"]
