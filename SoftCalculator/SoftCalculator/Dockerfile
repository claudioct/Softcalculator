FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["SoftCalculator/SoftCalculator.csproj", "SoftCalculator/"]
RUN dotnet restore "SoftCalculator/SoftCalculator.csproj"
COPY . .
WORKDIR "/src/SoftCalculator"
RUN dotnet build "SoftCalculator.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SoftCalculator.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SoftCalculator.dll"]