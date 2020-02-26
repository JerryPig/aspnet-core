#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/ZCms.Web.Host/ZCms.Web.Host.csproj", "src/ZCms.Web.Host/"]
COPY ["src/ZCms.Web.Core/ZCms.Web.Core.csproj", "src/ZCms.Web.Core/"]
COPY ["src/ZCms.Application/ZCms.Application.csproj", "src/ZCms.Application/"]
COPY ["src/ZCms.Core/ZCms.Core.csproj", "src/ZCms.Core/"]
COPY ["src/ZCms.EntityFrameworkCore/ZCms.EntityFrameworkCore.csproj", "src/ZCms.EntityFrameworkCore/"]
RUN dotnet restore "src/ZCms.Web.Host/ZCms.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/ZCms.Web.Host"
RUN dotnet build "ZCms.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ZCms.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ZCms.Web.Host.dll"]