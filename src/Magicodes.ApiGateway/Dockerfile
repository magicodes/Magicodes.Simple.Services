FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["src/Magicodes.ApiGateway/Magicodes.ApiGateway.Host.csproj", "src/Magicodes.ApiGateway/"]
RUN dotnet restore "src/Magicodes.ApiGateway/Magicodes.ApiGateway.Host.csproj"
COPY . .
WORKDIR "/src/src/Magicodes.ApiGateway"
RUN dotnet build "Magicodes.ApiGateway.Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Magicodes.ApiGateway.Host.csproj" -c Release -o /app


FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Magicodes.ApiGateway.Host.dll"]

