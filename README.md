# Hall-Of-Fame-Test

## Запуск проекта

```sh
docker-compose up -d
dotnet ef database update --project HallOfFame.Infrastructure --startup-project HallOfFame.API
```
url: http://127.0.0.1:8080/swagger/index.html
