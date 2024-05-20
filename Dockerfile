# Use the base Windows Server Core image from Microsoft
FROM mcr.microsoft.com/windows/servercore:ltsc2022

# Set the working directory inside the container
WORKDIR /app

# Copy the HelloCD.exe file from the host to the container
COPY HelloCD.exe .

# Define the entry point for the container
ENTRYPOINT ["HelloCD.exe"]
