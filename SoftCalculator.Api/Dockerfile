FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["SoftCalculator.Api/SoftCalculator.Api.csproj", "SoftCalculator.Api/"]
RUN dotnet restore "SoftCalculator.Api/SoftCalculator.Api.csproj"
COPY . .
WORKDIR "/src/SoftCalculator.Api"
RUN dotnet build "SoftCalculator.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SoftCalculator.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SoftCalculator.Api.dll"]