# MBank Recruitment Task

Problems and solutions:

1. I was not able to fully containerized my application.

I've created docker-compose with embeded Docker orchiestrator tool. It contains: 
services:
 - f1.api
 - f1db.postgres
 - pgadmin
 - rabbitmq
 - seed
 For some reason f1.api container and seed container don't use passed environments like db connectionstring and rabbitMQ connectionString, so after running the 
  $docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up -d  command I turn off the seed and f1.api container and run multiple startup projects containig Seed and F1.API projects.
  I also run client application with ng serve command, localhost:4200.

2. I've had also problems with reading XML files. Maybe because I've created them with an online converter based on csv files. It is possible that those files were not valid.


