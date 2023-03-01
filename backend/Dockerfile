# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./SubjectManagementSystem.API/SubjectManagementSystem.API.csproj" --disable-parallel
RUN dotnet publish "./SubjectManagementSystem.API/SubjectManagementSystem.API.csproj" -c release -o /app --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000-5001

ENTRYPOINT [ "dotnet", "SubjectManagementSystem.API.dll" ]