const weatherapi = "https://api.met.no/weatherapi/locationforecast/2.0/?lat=59.93&lon=10.72&altitude=90";

const response = await fetch(weatherApi);
const data = await response.json();

console.log(response);

const currentTemperature = data.properties.timeseries[0].data.instant.details.air_temperature;
console.log(currentTemperature);

const temperatureDisplay = document.getElementById("temperature");
temperatureDisplay.textcontent = currentTemperature;