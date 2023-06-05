var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/customs_duty", (decimal price) =>
{
    decimal customsDuty = CalculateCustomsDuty(price);
    return $"Customs duty: {customsDuty}ˆ";
});

decimal CalculateCustomsDuty(decimal price)
{   
    decimal customsDuty = price > 200m ? (price - 200m) * 0.15m : 0m;
    return customsDuty;
}

app.Run();
