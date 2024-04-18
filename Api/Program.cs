namespace Clean.Api;

public class Program{

    public static void Main(string[] args){
        try{
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.ConfigureServices().ConfigurePipeline();

            app.Run();

        }catch(Exception e){
            throw new Exception(e.Message);
        }
    }
}