# MBank Recruitment Task
Napotkane problemy i ich rozwiązania:

1. Miałem problem z załadowaniem danych z pliku xml. Miałem gotowe dane w plikach .csv i użyłem internetowego convertera do plików xml. Być może wygenerowane pliki były niepoprawne, koniec końców użyłem plików .csv.

2.Problem z czytaniem zmiennych w docker.compose.override.yml. Jeżeli odpalone zostały kontenery Postgres,RabbitMq i pgadmin oraz odpalono programy F1.API orad Seed to prawidłowo zostają pobierane dane do bazy danych z plików csv. Natomiast odpalenie całego docker-compose, sprawia że ignorowane są Zmienne connectionstring w pliku docker-compose-override.yml.
