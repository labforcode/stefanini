## Migration

1 - Setar o projeto de Infra.Data como principal a ser executado

2- Pelo PowerShell, entrar na pasta C:\dev\Estudos\back\TesteStefanini\src\TesteStefanini.Cadastros.Infra.Data

3 - Executar o comando abaixo para setar o Ambiente em que deseja fazer o Migration
$Env:ASPNETCORE_ENVIRONMENT = "Development"


4 - Então, executar o comando abaixo para gerar o Migration, de acordo com o ambiente setado anteriormente
dotnet ef migrations add development --context DbStefanini -s C:\dev\Estudos\back\TesteStefanini\src\TesteStefanini.WebApi --verbose

5 - Após a geração do Migration, executar o comando abaixo para atualizar a DataBase
dotnet ef database update --context DbStefanini -s C:\dev\Estudos\back\TesteStefanini\src\TesteStefanini.WebApi --verbose


## Criar uma rede especial em modo bridge
docker network create --gateway 172.18.0.1 --subnet 172.18.0.0/16 dev-local

## Criar o volume
docker volume create pg-stefanini

## Executar o container do Postgres para a API Tecnomyl
docker run -ti --network=dev-local --ip 172.18.0.176 -p 5434:1433 -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=st3fan1n1@!" -d mcr.microsoft.com/mssql/server




