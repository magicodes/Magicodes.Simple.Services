FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["src/Services.Test2/Services.Test2.csproj", "src/Services.Test2/"]
RUN dotnet restore "src/Services.Test2/Services.Test2.csproj"
COPY . .
WORKDIR "/src/src/Services.Test2"
RUN dotnet build "Services.Test2.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Services.Test2.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Services.Test2.dll"]