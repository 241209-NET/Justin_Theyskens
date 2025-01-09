#this is a comment
#What does this app need to run?

# ================================

# To Build:
# SDK / compiler - FROM command
# Project Dependencies - RUN dotnet restore
# Source code - COPy + WORKDIR
# Build / Compile the App

# --------------------------

# To Run:
# Runetime environment
# run the exe file/ compiled code

# ====================================

# FROM: the img to work off of - the base image
# name has 2 parts: 1) The Name, 2) The Tag
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Set a working directory
# if it exists, navigate to it,
# otherwise, create it
WORKDIR /app

# Copy from src -> dest
COPY ./ ./

# RUN to execute a command in the image creation
# if not .sln, dotnet restore ./Name.API/
# to locate the .csproj file
RUN dotnet restore

# Build / compile the App
# dotnet build is for development
# dotnet publish is designed to build for release.
RUN dotnet publish -c Release -o ./out

# ---Second stage to Run the App----


# ASP.NET comes with a kestrel server
# can run a Web App.
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Set a working directory
WORKDIR /app

# Set an alias
# Copy everything from the output directory
COPY --from=build /app/out ./

# ENTRYPOINT: The first or default action to take
# when the container is STARTED
# RUN commands start when container is BUILT
ENTRYPOINT ["dotnet", "./ProjectName.API.dll"]

#docker build -t name:latest ./Dockerfile ( or just .)