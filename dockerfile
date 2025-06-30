FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["PersonalWebsite.csproj", "."]
RUN dotnet restore "PersonalWebsite.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build  -c Release -o /app/build

FROM build AS publish
RUN dotnet publish  -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# Explicitly ensure wwwroot is copied
COPY --from=publish /app/publish/wwwroot ./wwwroot
ENTRYPOINT ["dotnet", "PersonalWebsite.dll"]
