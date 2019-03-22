FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["src/Magicodes.IdentityServer.Host/Magicodes.IdentityServer.Host.csproj", "src/Magicodes.IdentityServer.Host/"]
COPY ["src/Magicodes.Simple.Services.Core/Magicodes.Simple.Services.Core.csproj", "src/Magicodes.Simple.Services.Core/"]
RUN dotnet restore "src/Magicodes.IdentityServer.Host/Magicodes.IdentityServer.Host.csproj"
COPY . .
WORKDIR "/src/src/Magicodes.IdentityServer.Host"
RUN dotnet build "Magicodes.IdentityServer.Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Magicodes.IdentityServer.Host.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Magicodes.IdentityServer.Host.dll"]
