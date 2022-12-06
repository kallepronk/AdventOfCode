FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["day-5/day-5.csproj", "day-5/"]
RUN dotnet restore "day-5/day-5.csproj"
COPY . .
WORKDIR "/src/day-5"
RUN dotnet build "day-5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "day-5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "day-5.dll"]
