#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Rent_A_Car.WebAPI/Rent_A_Car.WebAPI.csproj", "Rent_A_Car.WebAPI/"]
COPY ["Rent_A_Car.Model/Rent_A_Car.Model.csproj", "Rent_A_Car.Model/"]
RUN dotnet restore "Rent_A_Car.WebAPI/Rent_A_Car.WebAPI.csproj"
COPY . .
WORKDIR "/src/Rent_A_Car.WebAPI"
RUN dotnet build "Rent_A_Car.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rent_A_Car.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rent_A_Car.WebAPI.dll"]