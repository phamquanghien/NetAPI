# Su dung image .NET SDK de build ung dung
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy cac file csproj và restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy toan bo noi dung cua du an va build
COPY . .
RUN dotnet publish -c Release -o out

# Tao image runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Mo cong can thiet
EXPOSE 80

# Khoi chay ung dung khi container bat dau
ENTRYPOINT ["dotnet", "NetAPI.dll"]