FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["src/Services.Test1/Services.Test1.csproj", "src/Services.Test1/"]
RUN dotnet restore "src/Services.Test1/Services.Test1.csproj"
COPY . .
WORKDIR "/src/src/Services.Test1"
RUN dotnet build "Services.Test1.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Services.Test1.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Services.Test1.dll"]