# Hall-Of-Fame-Test

## Запуск проекта

```sh
docker-compose up -d
dotnet ef database update --project HallOfFame.Infrastructure --startup-project HallOfFame.API
