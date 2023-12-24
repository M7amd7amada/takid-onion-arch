using Takid.Api.Extensions;

var app = WebApplication.CreateBuilder().ConfigureServices().Build();

app.UseExceptionHandler("/error");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();