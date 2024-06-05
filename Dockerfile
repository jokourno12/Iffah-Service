# Use the official ASP.NET Core runtime image as a base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Copy the published output of the ASP.NET Core application into the container
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["iffah_service.csproj", "."]
RUN dotnet restore "./iffah_service.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "iffah_service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "iffah_service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "iffah_service.dll"]
