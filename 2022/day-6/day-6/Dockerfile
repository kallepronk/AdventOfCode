FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["day-6/day-6.csproj", "day-6/"]
RUN dotnet restore "day-6/day-6.csproj"
COPY . .
WORKDIR "/src/day-6"
RUN dotnet build "day-6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "day-6.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "day-6.dll"]
