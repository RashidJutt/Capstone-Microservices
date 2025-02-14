FROM node:20.18.0-alpine as build
WORKDIR /app
COPY package.json .
RUN npm install
COPY . .
RUN npx ng build -c=production
FROM nginx:1.27.4-alpine
COPY --from=build /app/dist/web-client/browser /usr/share/nginx/html
COPY docker-dev/nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 80