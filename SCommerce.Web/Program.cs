using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Linq;

namespace SCommerce.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SCommerce.Infra.Data.EF.ScContext scContext = new SCommerce.Infra.Data.EF.ScContext();
            if (scContext.Empregado.Where(x => x.Usuario.Equals("Admin")).Count() == 0)
            {
                SCommerce.Domain.Entities.Empregado.Empregado empregado = new SCommerce.Domain.Entities.Empregado.Empregado(Guid.NewGuid())
                {
                    Usuario = "Admin",
                    Cadastro = DateTime.Now,
                    Atualizado = DateTime.Now,
                    Nome = "Administrador",
                    Senha = Utils.StringExtension.ConvertToMD5("Admin")
                };
                scContext.Empregado.Add(empregado);
                scContext.SaveChanges();
            }
            if(scContext.Loja.Count() == 0)
            {
                Domain.Entities.CadastroBase.Loja loja = new Domain.Entities.CadastroBase.Loja(Guid.NewGuid())
                {
                    Ativa  = true,
                    Atualizado = DateTime.Now,
                    Cadatro = DateTime.Now,
                    Deletada = false,
                    Nome = "Stack Commerce"
                };
                scContext.Loja.Add(loja);
                scContext.SaveChanges();
            }
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
