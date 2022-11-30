# Devs Final Project
To create this project I used the following commands:

`dotnet new sln`

`dotnet new webapi -o <Project path/name>`

`dotnet sln add <Project path/name>`

## If you want to test the image try this commands
Note that you need docker installed.

1. `docker build . -t <image name>`
2. `docker run --name <container name> -p <any available port>:80 -d <image name>`

Finally run `docker ps` to check the container created

Open with a browser http://localhost:8080
