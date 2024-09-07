namespace Project_Structure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webApplicationBuilder = WebApplication.CreateBuilder();



            #region Configure Services

            webApplicationBuilder.Services.AddControllersWithViews();

            #endregion

            var app = webApplicationBuilder.Build();

            #region Configure
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //Middle Ware
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Home/Error");
            }
            app.UseRouting();


            app.MapGet("/", () => "Hello World!");



            app.MapGet("/Hamada", async (context) =>
            {
                await context.Response.WriteAsync("Hello Hamada!");
            });

            #endregion
            app.Run();
        }
    }
}
