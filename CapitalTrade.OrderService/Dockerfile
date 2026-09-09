# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["CapitalTrade.OrderService.csproj", "./"]
RUN dotnet restore "CapitalTrade.OrderService.csproj"

COPY . .
RUN dotnet publish "CapitalTrade.OrderService.csproj" \
    -c Release \
    -o /app/publish \
    /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "CapitalTrade.OrderService.dll"]