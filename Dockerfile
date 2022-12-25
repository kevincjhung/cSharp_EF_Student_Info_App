FROM mcr.microsoft.com/dotnet/aspnet:5.0 as base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 as build
COPY . /src
WORKDIR /src
RUN ls
RUN dotnet build 'Assign1.csproj' -c Release -o /app/build

FROM build AS publish
RUN dotnet publish 'Assign1.csproj' -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Assign1.dll"]