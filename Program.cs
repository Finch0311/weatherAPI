using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using weatherAPI;

string key = File.ReadAllText("jsconfig1.json");

string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

Console.WriteLine("Enter your zip code.");
var zipCode = Console.ReadLine();

var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

Console.WriteLine();

Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F.");

