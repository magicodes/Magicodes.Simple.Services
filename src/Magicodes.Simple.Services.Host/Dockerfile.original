FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Magicodes.Simple.Services.Host/Magicodes.Simple.Services.Host.csproj", "Magicodes.Simple.Services.Host/"]
RUN dotnet restore "Magicodes.Simple.Services.Host/Magicodes.Simple.Services.Host.csproj"
COPY . .
WORKDIR "/src/Magicodes.Simple.Services.Host"
RUN dotnet build "Magicodes.Simple.Services.Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Magicodes.Simple.Services.Host.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Magicodes.Simple.Services.Host.dll"]