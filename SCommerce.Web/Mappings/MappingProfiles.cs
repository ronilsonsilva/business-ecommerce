using AutoMapper;
using SCommerce.Web.Areas.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Mappings
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
            CreateMap<Domain.Entities.Produto.ProdutoImagem, ProdutoImagemViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Produto.Propriedade, PropriedadeViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Produto.ProdutoPropriedade, ProdutoPropriedadeViewModel>().ReverseMap();
            CreateMap<Domain.Entities.Produto.PropriedadeValor, PropriedadeValorViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CMS.CMSLoja, CMSLojaViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CMS.CMSRedeSocial, CMSRedeSocialViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CMS.CMSWhatsApp, CMSWhatsAppViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CMS.CMSSlidePrincipal, CMSSlidePrincipalViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CMS.CMSEnderecoLoja, CMSEnderecoLojaViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CadastroBase.ContatoLojaEmail, ContatoLojaEmailViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CadastroBase.ContatoLojaEndereco, ContatoLojaEnderecoViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CadastroBase.ContatoLojaTelefone, ContatoLojaTelefoneViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CadastroBase.ContatoLojaRedeSocial, ContatoLojaRedeSocialViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CadastroBase.ContatoEmail, ContatoEmailViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CadastroBase.ContatoTelefone, ContatoTelefoneViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CadastroBase.Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Domain.Entities.CadastroBase.ContatoRedeSocial, ContatoRedeSocialViewModel>().ReverseMap();
        }
    }
}
