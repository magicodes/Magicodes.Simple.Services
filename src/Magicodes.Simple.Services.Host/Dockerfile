FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["src/Magicodes.Simple.Services.Host/Magicodes.Simple.Services.Host.csproj", "src/Magicodes.Simple.Services.Host/"]
COPY ["src/Magicodes.Simple.Services.Core/Magicodes.Simple.Services.Core.csproj", "src/Magicodes.Simple.Services.Core/"]
RUN dotnet restore "src/Magicodes.Simple.Services.Host/Magicodes.Simple.Services.Host.csproj"
COPY . .
WORKDIR "/src/src/Magicodes.Simple.Services.Host"
RUN dotnet build "Magicodes.Simple.Services.Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Magicodes.Simple.Services.Host.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Magicodes.Simple.Services.Host.dll"]
