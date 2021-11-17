FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Products.Service/Products.Service.csproj", "Products.Service/"]
RUN dotnet restore "Products.Service/Products.Service.csproj"
COPY . .
WORKDIR "/src/Products.Service"
RUN dotnet build "Products.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Products.Service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Products.Service.dll"]
