namespace RhinoForge.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Welcome to RhinoForge API 🚛");

            app.Run();
        }
    }
}