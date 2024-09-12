FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

COPY ./PayMart.Domain.Payments/PayMart.Domain.Payments.csproj ./PayMart.Domain.Payments/
COPY ./PayMart.Infrastructure.Payments/PayMart.Infrastructure.Payments.csproj ./PayMart.Infrastructure.Payments/
COPY ./PayMart.API.Payments/PayMart.API.Payments.csproj ./PayMart.API.Payments/
RUN dotnet restore ./PayMart.API.Payments/PayMart.API.Payments.csproj

COPY ./PayMart.Domain.Payments ./PayMart.Domain.Payments/
COPY ./PayMart.Infrastructure.Payments ./PayMart.Infrastructure.Payments/
COPY ./PayMart.API.Payments ./PayMart.API.Payments/

WORKDIR /app/PayMart.API.Payments
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/PayMart.API.Payments/out .

EXPOSE 5004

ENTRYPOINT ["dotnet", "PayMart.API.Payments.dll"]
