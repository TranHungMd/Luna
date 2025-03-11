# Sử dụng .NET SDK để build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy file csproj và khôi phục dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy toàn bộ source code vào container
COPY . ./
RUN dotnet publish -c Release -o out

# Sử dụng ASP.NET runtime để chạy ứng dụng
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Mở cổng để container có thể truy cập
EXPOSE 8080

# Chạy ứng dụng
ENTRYPOINT ["dotnet", "Luna.dll"]
