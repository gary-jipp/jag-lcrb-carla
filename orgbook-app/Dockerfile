FROM node:18-alpine

# Set the working directory inside the container
WORKDIR /app

# Copy files to the working directory
COPY app .

# Install dependencies
RUN npm install

ARG BUILD_NUMBER
ENV BUILD_NUMBER=${BUILD_NUMBER}

# Command to run the application
ENTRYPOINT ["node", "index.js"]