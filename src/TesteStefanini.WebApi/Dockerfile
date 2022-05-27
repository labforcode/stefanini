FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS http://+:80
ENV ASPNETCORE_ENVIRONMENT: "Development"
ENV TZ=America/Sao_Paulo

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone
WORKDIR /
COPY ["src/TesteStefanini.WebApi/TesteStefanini.WebApi.csproj", "src/TesteStefanini.WebApi/"]
COPY ["src/TesteStefanini.Cadastros.Aplicacoes/TesteStefanini.Cadastros.Aplicacoes.csproj", "src/TesteStefanini.Cadastros.Aplicacoes/"]
COPY ["src/TesteStefanini.Cadastros.Dominios/TesteStefanini.Cadastros.Dominios.csproj", "src/TesteStefanini.Cadastros.Dominios/"]
COPY ["src/TesteStefanini.Cadastros.Infra.Data/TesteStefanini.Cadastros.Infra.Data.csproj", "src/TesteStefanini.Cadastros.Infra.Data/"]
COPY ["src/TesteStefanini.Cadastros.Infra.CrossCutting/TesteStefanini.Cadastros.Infra.CrossCutting.csproj", "src/TesteStefanini.Cadastros.Infra.CrossCutting/"]

RUN dotnet restore "src/TesteStefanini.WebApi/TesteStefanini.WebApi.csproj"
COPY . .
WORKDIR "/src/TesteStefanini.WebApi"
RUN dotnet build "TesteStefanini.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TesteStefanini.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TesteStefanini.WebApi.dll"]