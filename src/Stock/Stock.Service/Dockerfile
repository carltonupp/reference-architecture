FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Stock.Service/Stock.Service.fsproj", "Stock.Service/"]
RUN dotnet restore "Stock.Service/Stock.Service.fsproj"
COPY . .
WORKDIR "/src/Stock.Service"
RUN dotnet build "Stock.Service.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Stock.Service.fsproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Stock.Service.dll"]
