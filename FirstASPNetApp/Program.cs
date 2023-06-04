var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/new_year", () =>
{
    var currentDate = DateTime.Today;
    var newYearDate = new DateTime(currentDate.Year + 1, 1, 1);
    var daysUntilNewYear = (newYearDate - currentDate).Days;

    return $"До Нового года осталось {daysUntilNewYear} дней";
});

app.Run();