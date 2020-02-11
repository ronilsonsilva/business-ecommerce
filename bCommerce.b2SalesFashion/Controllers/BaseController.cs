using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.Fabricante;
using SCommerce.Domain.Interfaces.Repositories.Produto;

namespace bCommerce.b2SalesFashion.Controllers
{
    public class BaseController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IProdutoImagemRepository _produtoImagemRepository;
        private readonly IProdutoPropriedadeRepository _produtoPropriedadeRepository;
        private readonly IFabricanteRepository _fabricanteRepository;
        private readonly IPropriedadeRepository _propriedadeRepository;
        private readonly ILojaRepository _lojaRepository;
        private readonly IMapper _mapper;

        public BaseController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository, IProdutoImagemRepository produtoImagemRepository, IProdutoPropriedadeRepository produtoPropriedadeRepository, IFabricanteRepository fabricanteRepository, IPropriedadeRepository propriedadeRepository, ILojaRepository lojaRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
            _produtoImagemRepository = produtoImagemRepository;
            _produtoPropriedadeRepository = produtoPropriedadeRepository;
            _fabricanteRepository = fabricanteRepository;
            _propriedadeRepository = propriedadeRepository;
            _lojaRepository = lojaRepository;
            _mapper = mapper;
        }

        public void CarregarDados()
        {
            try
            {
                ViewBag.Categorias = _mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaRepository.GetAll());
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}