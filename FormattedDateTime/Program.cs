using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/current_datetime", (HttpContext context) =>
{
    var culture = new CultureInfo(context.Request.Query["language"].ToString());
    var currentDateTime = DateTime.Now;

    string formattedDateTime = currentDateTime.ToString("F", culture);

    return formattedDateTime;
});

app.Run();


//   /current_datetime?language = fr
//   /current_datetime?language = az
//   /current_datetime?language = aa
