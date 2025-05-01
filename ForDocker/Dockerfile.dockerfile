# Используем официальный образ SDK для сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копируем файлы проекта и восстанавливаем зависимости
COPY ["ForDocker.csproj", "."]
RUN dotnet restore "ForDocker.csproj"

# Копируем все файлы и собираем приложение
COPY . .
RUN dotnet build "ForDocker.csproj" -c Release -o /app/build
RUN dotnet publish "ForDocker.csproj" -c Release -o /app/publish

# Используем runtime образ для финального образа
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Указываем точку входа
ENTRYPOINT ["dotnet", "ForDocker.dll"]