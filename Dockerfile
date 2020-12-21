FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY retornaValorImovel.Api/*.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY retornaValorImovel.Api/. ./
RUN dotnet publish --framework netcoreapp3 --configuration Release --output out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "retornaValorImovel.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet retornaValorImovel.dll