FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
# COPY *.csproj .
COPY . .
RUN dotnet restore

RUN dotnet build

# run tests on docker build
RUN dotnet test

# run tests on docker run
# ENTRYPOINT ["dotnet", "test"]
# # copy and build everything else
# COPY . .
# WORKDIR /app
# RUN dotnet publish -c Release -o out --no-restore


# FROM mcr.microsoft.com/dotnet/framework/runtime:4.8 AS runtime
# WORKDIR /app
# COPY --from=build /app/out ./
# ENTRYPOINT ["dotnetapp.exe"]