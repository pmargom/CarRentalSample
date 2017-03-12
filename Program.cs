using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new WebHostBuilder()
                .UseKestrel()                       // web server cross-platform incluido por defecto al usar dotnet new
                .UseStartup<Program>();             // indicamos la clase que se usará como punto de entrada
            
            // la siguiente instrucción es opcional, es solo cambiar la ruta por defecto
            // la ruta por defecto es: http://localhost:5000"
            builder.UseUrls("http://localhost:8000");

            // la siguiente instrucción es opcional. Sirve para cambiar el numero de threads o procesos
            // que atenderán las peticiones. Permite destinar más recursos de CPU para anteder peticiones HTTP
            builder.UseKestrel(options => {
                options.ThreadCount = 4;
            });

            var host = builder.Build();
            host.Run();
        }

        // Método usado para registrar todo tipo de servicios (dependencias) que serán usados por nuestra aplicación
        public void ConfigureServices(IServiceCollection services) {

            // Indicamos que queremos usar las dependencias necesarias para hacer uso del framework MVC
            services.AddMvc();
        }

        // Método usado para indicar como la aplicación responderá a las peticiones  HTTP
        public void Configure(IApplicationBuilder app) {

            // Aquí se incluirán los uso de los diferentes middleware's que vaya
            // necesitando nuestra aplicación
            // El siguiente middleware es para indicar el tipo de rutas que se permitirán
            // en los endpoints del api
            app.UseMvcWithDefaultRoute();
            
        }

    }

}
