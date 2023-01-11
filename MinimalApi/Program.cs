using Microsoft.AspNetCore.Mvc;
using MinimalApi.Models;
using MinimalAPI.RouteGroups;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



var mapGroup = app.MapGroup("/products").ProductsAPI();

app.Run();
