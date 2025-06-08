FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY DockerizedProject.csproj ./
RUN dotnet restore DockerizedProject.csproj

COPY . . 
RUN dotnet publish DockerizedProject.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish .

ENV coursename="Docker"

ENTRYPOINT ["dotnet", "DockerizedProject.dll"]