var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

DateTime CurrentDate = DateTime.Now;
int DayOfYear = CurrentDate.DayOfYear;

app.MapGet("/", () => $"����� �������� ��� � ����: {DayOfYear}");

app.Run();
