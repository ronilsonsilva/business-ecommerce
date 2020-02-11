using SCommerce.Domain.Interfaces.Repositories.Empregado;
using SCommerce.Infra.Data.EF;
using System;
using System.Linq;

namespace SCommerce.Infra.Data.Repositories.Empregado
{
    public class EmpregadoRepository : RepositoryBase<Domain.Entities.Empregado.Empregado>, IEmpregadoRepository
    {
        private readonly ScContext Db = new ScContext();

        /// <summary>
        /// Verifica Log in do usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public Domain.Entities.Empregado.Empregado Login(string usuario, string senha)
        {
            try
            {
                if (usuario != null && senha != null)
                {
                    return Db.Empregado.Where(x => x.Usuario.Equals(usuario) && x.Senha.Equals(senha)).FirstOrDefault();
                }
                return null;
            }
            catch (System.Exception erro)
            {
                throw erro;
            }
        }
    }
}
