FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

# Copy binaries from local relative path to WORKDIR in image
COPY bin/Release/net6.0/publish/ ./

ENV ASPNETCORE_URLS=http://+:80

EXPOSE 80

ENTRYPOINT ["dotnet", "DockerWebApi.dll"]

# Run this command in a command prompt window to build the image:
# docker build -t docker-web-api .

# Run the image in a container with this command
# docker run -p 80:80 -it --rm docker-web-api

# To try the web service in a browser load this URL:
# http://localhost/api/square/6