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
            app.MapControllerRoute(
                  name: "default",
                  // pattern /*UrlPath*/:"Hamada/{controller}/{action}/{id?}"// static Segment
                  //pattern /*UrlPath*/: "Hamada/XXX{controller}/{action}/{id?}"// Mixed Segment
                  // pattern /* UrlPath*/: "{controller =Movies}/{action = GetMovie}/{id?}"// constructor + action + default
                  pattern /* UrlPath*/: "{controller}/{action}/{id:int?}"//  constructor + action + default + constraints

              );

            #endregion
            app.Run();
        }
    }
}
