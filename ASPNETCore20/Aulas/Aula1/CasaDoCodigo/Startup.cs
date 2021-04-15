using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CasaDoCodigo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Você acabou de desenvolver o modelo de dados e também o contexto do Entity Framework Core através da classe ApplicationContext, que implementa a classe-base DbContext, para realizar as operações para obter/gravar dados no seu banco de dados Sql Server através das entidades da aplicação.
            string connectionString = Configuration.GetConnectionString("Default");

            services.AddMvc();
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));

            services.AddTransient<DataService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Pedido}/{action=Carrossel}/{id?}");
            });

            //cria o banco de dados e seus objetos (tabelas, campos, índices, etc) usando apenas as entidades e mapeamentos da aplicação.
            //serviceProvider.GetService<ApplicationContext>().Database.EnsureCreated(); //Garante que o banco de dados foi criado ao iniciar a aplicação. Uma vez que o banco de dados foi gerado através do método EnsureCreated(), a aplicação não pode mais usar migrations.Por isso, a não ser que uma aplicação seja pequena e destinada a testes, é recomendável usar sempre o método Migrate().

            //método Migrate() realiza exatamente a mesma tarefa, porém usando apenas as migrações da aplicação.
            //serviceProvider.GetService<ApplicationContext>().Database.Migrate(); //Garante que o banco de dados foi criado ao iniciar a aplicação
            serviceProvider.GetService<DataService>().InicializaDB(); //Garante que o banco de dados foi criado ao iniciar a aplicação
        }
    }

    class DataService
    {
        private readonly ApplicationContext context;

        public DataService(ApplicationContext context)
        {
            this.context = context;
        }

        public void InicializaDB()
        {
            context.Database.EnsureCreated();
        }
    }
}
