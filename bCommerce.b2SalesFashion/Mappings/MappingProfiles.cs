using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bCommerce.b2SalesFashion.Models;
using SCommerce.b2SalesFashion.ViewModels;

namespace SCommerce.b2SalesFashion.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Domain.Entities.Fabricante.Fabricante, FabricanteViewModels>().ReverseMap();
            CreateMap<Domain.Entities.Fornecedor.Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Produto.Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Produto.CategoriaProduto, CategoriaProdutoViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Produto.Categoria, CategoriaViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Produto.Categoria, CategoriaLojaViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Produto.ProdutoImagem, ProdutoImagemViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Produto.Propriedade, PropriedadeViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Produto.ProdutoPropriedade, ProdutoPropriedadeViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Produto.PropriedadeValor, PropriedadeValorViewModel>().ReverseMap();
        }
    }
}
